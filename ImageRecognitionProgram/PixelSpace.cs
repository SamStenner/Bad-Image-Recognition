// Class: Pixel Space
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageIdentifier {

    public class Fitmap {

        private byte[] pixels;           // Array of bytes for the pixels
        private Bitmap bitmap;           // Original bitmap
        private BitmapData bitmapData;   // Bitmap data
        private IntPtr ptrFirstPixel;    // Memory pointer
        private int bytes;               // Bytes per pixel
        private int stride;              // Jump between pixels
        public int height;               // Image height
        public int width;                // Image width

        // Constructor: Takes bitmap
        public Fitmap(Bitmap bmp) {
            Create(bmp);
        }

        // Constructor: Takes dimensions
        public Fitmap(int width, int height) {
            Bitmap bmp = new Bitmap(width, height);         // Creates empty bitmaps
            using(Graphics g = Graphics.FromImage(bmp)) {   // Creates graphics object
                g.Clear(Color.White);                       // Colours the bitmap white
            }
            Create(bmp);                                    // Creates the fitmap
        }

        // Creates the fitmap
        public void Create(Bitmap bmp) {
            bitmap = bmp;                                                   // Sets the bitmap object
            height = bitmap.Height;                                         // Sets the height
            width = bitmap.Width;                                           // Sets the width
            LockBits();                                                     // Puts bits into memory
            stride = bitmapData.Stride;                                     // Finds the stride
            pixels = new byte[stride * height];                             // Creates array for pixels
            ptrFirstPixel = bitmapData.Scan0;                               // Gets memory pointer for first pixel
            bytes = Image.GetPixelFormatSize(bitmapData.PixelFormat) / 8;   // Finds the colour depth
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);          // Copies data from memory to pixel array
            UnlockBits();                                                   // Unlocks memory data
        }

        // Gets pixel colour
        public Color GetPixel(int x, int y) {
            y *= stride;                                // Locates y coordinate
            x *= bytes;                                 // Locates x coordinate
            return Color.FromArgb(pixels[y + x + 2],    // Converts to colour by
                                  pixels[y + x + 1],    // accessing the adjacent
                                  pixels[y + x + 0]);   // byte data
        }

        // Sets pixel colour
        public void SetPixel(int x, int y, Color colour) {
            y *= stride;                                     // Locates y coordinate
            x *= bytes;                                      // Locates x coordinate
            pixels[y + x + 2] = colour.R;                    // Sets the pixel colour
            pixels[y + x + 1] = colour.G;                    // channels to that of
            pixels[y + x + 0] = colour.B;                    // the specified colour
        }

        // Return the bitmap
        public Bitmap ToBitmap() {
            return bitmap;
        }

        // Locks data to memory
        public void LockBits() {
            if (pixels != null) {                                            // If image not empty
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);       // Copies current data from memory to pixel array
            }
            bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), // Applies the bitmap data to an object
                         ImageLockMode.ReadWrite, bitmap.PixelFormat);
        }

        // Unlocks data from memory
        public void UnlockBits() {
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);          // Copies pixel array data to memory
            bitmap.UnlockBits(bitmapData);                                  // Releases the bitmapData data
        }
    }

    public class HSV {
        public double hue = 0, sat = 0, val = 0;                         // The publicly accessible Hue, Saturation and Value

        // Constructor: takes raw values
        public HSV(double H, double S, double V) {
            hue = H;                                                     // ---
            sat = S;                                                     // Sets the class variables as that from constructor
            val = V;                                                     // ---
        }

        // Constructor: converts from RGB colour
        public HSV(Color colour) {
            int max = Math.Max(colour.R, Math.Max(colour.G, colour.B));  // Finds maximum of RGB
            int min = Math.Min(colour.R, Math.Min(colour.G, colour.B));  // Finds minimum of RGB
            hue = (int)colour.GetHue();                                  // Hue defined using built in System.Drawing namespace
            sat = Math.Round((max == 0) ? 0 : 1 - (1d * min / max), 2);  // Gets saturation using mathematical formula
            val = Math.Round(max / 255d, 2);                             // Gets value using mathematical formula
        }

        // Constructor: Creates blank pixel
        public HSV() {
            hue = 0;  // ----------------------------------
            sat = 0;  // These are the HSV values for white
            val = 1;  // ----------------------------------
        }

        // Converts HSV to RGB
        public Color ToRGB() {               
            double value = val;                                          // Gets brightness
            int hueSegment = Convert.ToInt32(Math.Floor(hue / 60)) % 6;  // Converts hue range to be between 0 and 5 (inclusive)
            double f = hue / 60 - Math.Floor(hue / 60);                  // Finds the factorial part of the hue
            value *= 255;                                                // Converts value from between [0,1] to full byte, [0,255]
            int v = Convert.ToInt32(value);                              // ----------------------------
            int p = Convert.ToInt32(value * (1 - sat));                  // Same process as the formula,
            int q = Convert.ToInt32(value * (1 - f * sat));              // just simplified
            int t = Convert.ToInt32(value * (1 - (1 - f) * sat));        // ----------------------------
            switch (hueSegment) {                                        // Checks hue range
                case 0:                                                  // If: 000° ≤ H < 060°
                    return Color.FromArgb(v, t, p);                      // Return output
                case 1:                                                  // If: 060° ≤ H < 120°
                    return Color.FromArgb(q, v, p);                      // Return output 
                case 2:                                                  // If: 120° ≤ H < 180°
                    return Color.FromArgb(p, v, t);                      // Return output
                case 3:                                                  // If: 180° ≤ H < 240°
                    return Color.FromArgb(p, q, v);                      // Return output
                case 4:                                                  // If: 240° ≤ H < 300°
                    return Color.FromArgb(t, p, v);                      // Return output
                default:                                                 // If: 300° ≤ H < 360°
                    return Color.FromArgb(v, p, q);                      // Return output
            }
        }                                     
    }

    public class HSVImage {

        public HSV[,] map;        // Publically accessible 2D pixel map
        private int rows, cols;   // Rows and Columns

        // Constructor: Takes dimensions
        public HSVImage(int width, int height) {
            rows = height;                          // Sets rows
            cols = width;                           // Sets columns
            map = new HSV[cols, rows];              // Makes map that size
        }

        // Constructor: Takes fitmap
        public HSVImage(Fitmap fmp) {
            rows = fmp.height;                                           // Sets rows
            cols = fmp.width;                                            // Sets height
            map = new HSV[cols, rows];                                   // Makes map that size
            for (int row = 0; row < fmp.height; row++) {                 // Loops through rows
                for (int col = 0; col < fmp.width; col++) {              // Loops through columns
                    map[col, row] = new HSV(fmp.GetPixel(col, row));     // Sets pixel colour to that of fitmap colour
                }
            }
        }

        // Gets average HSV of image
        public HSV Average() {
            double avH = 0, avS = 0, avV = 0;               // Sets initial values
            for (int row = 0; row < rows; row++) {          // Loops through rows
                for (int col = 0; col < cols; col++) {      // Loops through columns
                    avH += map[col, row].hue / 2.0;         // Constrains hue, then adds to counter
                    avS += map[col, row].sat * 255;         // Constrains saturation, then adds to counter
                    avV += map[col, row].val * 255;         // Constrains brightness, then adds to counter
                }
            }
            avH /= (rows * cols);                           // -----------------------------------
            avS /= (rows * cols);                           // Divides counter by number of pixels
            avV /= (rows * cols);                           // -----------------------------------
            HSV average = new HSV(avH, avS, avV);           // Defines average as a HSV of average attributes
            return average;                                 // Returns the average
        }

        // Converts to a bitmap
        public Bitmap ToBitmap() {
            Fitmap fmp = new Fitmap(cols, rows);                // Defines empty fitmap
            HSV current = new HSV();                            // HSV pixel to contain current pixel data
            fmp.LockBits();                                     // Locks the bits
            for (int row = 0; row < rows; row++) {              // Loops through rows
                for (int col = 0; col < cols; col++) {          // Loops through columns
                    current = map[col, row];                    // Retrieves subject pixel
                    fmp.SetPixel(col, row, current.ToRGB());    // Sets fitmap pixel to that pixel
                }
            }
            fmp.UnlockBits();                                   // Releases bits from memory
            return fmp.ToBitmap();                              // Returns the bitmap of the fitmap
        }

    }

    public class GreyImage {

        public byte[,] Map;      // Publically accessible 2D pixel map
        private int rows, cols;  // Rows and Columns

        // Constructor: Takes dimensions
        public GreyImage(int width, int height) {
            rows = height;                         // Sets rows
            cols = width;                          // Sets columns
            Map = new byte[width, height];         // Makes map that size
        }

        // Gets the average shade of grey
        public byte Average() {
            int total = 0;                              // Initial counter
            for (int row = 0; row < rows; row++) {      // Loops through rows
                for (int col = 0; col < cols; col++) {  // Loops through columns
                    total += (int)Map[col, row];        // Adds greyness to counter
                }
            }
            return (byte)(total / (rows * cols));       // Returns average
        }

        // Converts to bitmap
        public Bitmap ToBitmap() {
            Fitmap fmp = new Fitmap(cols, rows);                                       // Defines empty fitmap 
            byte current;                                                              // Grey pixel to contain current pixe data
            fmp.LockBits();                                                            // Locks the bits
            for (int row = 0; row < rows; row++) {                                     // Loops through rows
                for (int col = 0; col < cols; col++) {                                 // Loops through columns
                    current = Map[col, row];                                           // Retrieves subject pixel
                    fmp.SetPixel(col, row, Color.FromArgb(current, current, current)); // Sets fitmap pixel to that pixel
                }
            }
            fmp.UnlockBits();                                                          // Release bits from memory
            return fmp.ToBitmap();                                                     // Returns the bitmap of te fitmp
        }

        // Converts to heatmap
        public Bitmap ToHeatmap() {
            HSVImage Heatmap = new HSVImage(cols, rows);                               // Defines empty HSV Image 
            for (int row = 0; row < rows; row++) {                                     // Loops through rows
                for (int col = 0; col < cols; col++) {                                 // Loops through columns
                    Heatmap.map[col, row] = new HSV(255 - Map[col, row], 1, 1);        // Converts greyscale value to HSV value
                }                                                                      // where hue is between red and blue
            }
            return Heatmap.ToBitmap();                                                 // Returns the bitmap of the HSV Image
        }

    }

}
