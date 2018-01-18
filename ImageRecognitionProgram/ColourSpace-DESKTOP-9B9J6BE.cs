using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImageIdentifier {

    public class Fitmap {

        private byte[] pixels;
        private BitmapData bitmapData;
        private Bitmap bitmap;
        private IntPtr ptrFirstPixel;
        private int Stride;
        public int Height;
        public int Width;

        public Fitmap(Bitmap bmp) {
            Create(bmp);
        }

        public Fitmap(int width, int height) {
            Bitmap bmp = new Bitmap(width, height);
            Create(bmp);
        }

        public void Create(Bitmap bmp) {
            bitmap = bmp;
            Height = bitmap.Height;
            Width = bitmap.Width;
            LockBits();
            Stride = bitmapData.Stride;
            pixels = new byte[Stride * Height];
            ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            UnlockBits();
        }

        public Color GetPixel(int x, int y) {
            y *= Stride;
            x *= Image.GetPixelFormatSize(bitmapData.PixelFormat) / 8;
            return Color.FromArgb(pixels[y + x + 2],
                                  pixels[y + x + 1],
                                  pixels[y + x]);
        }

        public void SetPixel(int x, int y, Color colour) {
            y *= Stride;
            x *= Image.GetPixelFormatSize(bitmapData.PixelFormat) / 8;
            pixels[y + x + 2] = colour.R;
            pixels[y + x + 1] = colour.G;
            pixels[y + x] = colour.B;
        }

        public Bitmap ToBitmap() {
            return bitmap;
        }

        public void LockBits() {
            if (pixels != null) {
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            }
            bitmapData = bitmap.LockBits(new Rectangle(0, 0, Width, Height),
                         ImageLockMode.ReadWrite, bitmap.PixelFormat);
        }

        public void UnlockBits() {
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            bitmap.UnlockBits(bitmapData);
        }
    }

    public class HSV {
        public double H = 0, S = 0, V = 0;                               // The publicly accessable Hue, Saturation and Value

        public HSV(double Hue, double Saturation, double Value) {
            H = Hue;                                                     // ---
            S = Saturation;                                              // Sets the class variables as that from constructor
            V = Value;                                                   //
        }      // 1st HSV Constructor, takes raw values

        public HSV(Color colour) {
            int max = Math.Max(colour.R, Math.Max(colour.G, colour.B));  // Finds maximum of RGB
            int min = Math.Min(colour.R, Math.Min(colour.G, colour.B));  // Finds minimum of RGB
            H = (int)colour.GetHue();                                    // Hue defined using built in System.Drawing namespace
            S = Math.Round((max == 0) ? 0 : 1d - (1d * min / max), 2);   // Gets saturation using mathematical formula
            V = Math.Round(max / 255d, 2);                               // Gets value using mathematical formula
        }                                     // 2nd HSV Constructor, converts from RGB colour

        public HSV() {
            H = 0;
            S = 0;
            V = 1;
        }                                                 // 3rd HSV Constructor, creates blank pixel

        public Color ToRGB() {                                           // Function to convert HSV pixel to RGB pixel                   
            double value = V;                                            // Source: http://www.poynton.com/PDFs/coloureq.pdf
            int hueSegment = Convert.ToInt32(Math.Floor(H / 60)) % 6;    // Converts hue range to be between 0 and 5
            double f = H / 60 - Math.Floor(H / 60);                      // Finds the factorial part of the hue
            value *= 255;                                                // Converts value from between [0,1] to full byte, [0,255]
            int v = Convert.ToInt32(value);                              // 
            int p = Convert.ToInt32(value * (1 - S));                    //
            int q = Convert.ToInt32(value * (1 - f * S));                //
            int t = Convert.ToInt32(value * (1 - (1 - f) * S));          //
            switch (hueSegment) {                                        // Checks hue range
                case 0:                                                  // If: 000° ≤ H < 060°
                return Color.FromArgb(v, t, p);
                case 1:                                                  // If: 060° ≤ H < 120°
                return Color.FromArgb(q, v, p);
                case 2:                                                  // If: 120° ≤ H < 180°
                return Color.FromArgb(p, v, t);
                case 3:                                                  // If: 180° ≤ H < 240°
                return Color.FromArgb(p, q, v);
                case 4:                                                  // If: 240° ≤ H < 300°
                return Color.FromArgb(t, p, v);
                default:                                                 // If: 300° ≤ H < 360°
                return Color.FromArgb(v, p, q);
            }
        }                                         // Converts HSV to RGB

    }

    public class HSVImage {

        public HSV[,] Map;
        private int rows, cols;

        public HSVImage(int width, int height) {
            rows = height;
            cols = width;
            Map = new HSV[cols, rows];
        }

        public HSVImage(Fitmap fmp) {
            rows = fmp.Height;
            cols = fmp.Width;
            Map = new HSV[cols, rows];
            for (int row = 0; row < fmp.Height; row++) {
                for (int col = 0; col < fmp.Width; col++) {
                    Map[col, row] = new HSV(fmp.GetPixel(col, row));
                }
            }
        }

        public HSV Average() {
            double avH = 0, avS = 0, avV = 0;
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    avH += Map[col, row].H / 2.0;
                    avS += Map[col, row].S * 255;
                    avV += Map[col, row].V * 255;
                }
            }
            avH /= (rows * cols);
            avS /= (rows * cols);
            avV /= (rows * cols);
            HSV average = new HSV(avH, avS, avV);
            return average;
        }

        public Bitmap ToBitmap() {
            Fitmap fmp = new Fitmap(cols, rows);
            HSV current = new HSV();
            fmp.LockBits();
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    current = Map[col, row];
                    fmp.SetPixel(col, row, current.ToRGB());
                }
            }
            fmp.UnlockBits();
            Bitmap bmp = fmp.ToBitmap();
            Bitmap bmp2 = new Bitmap(bmp);
            MessageBox.Show(bmp2.GetPixel(0, 0).ToString());
            return bmp2;
        }

    }

    public class GreyImage {

        public byte[,] Map;
        private int rows, cols;

        public GreyImage(int width, int height) {
            rows = height;
            cols = width;
            Map = new byte[width, height];
        }

        public Bitmap ToBitmap() {
            Bitmap converted = new Bitmap(cols, rows);
            byte current;
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    current = Map[col, row];
                    converted.SetPixel(col, row, Color.FromArgb(current, current, current));
                }
            }
            return converted;
        }

        public byte Average() {
            int total = 0;
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    total += (int)Map[col, row];
                }
            }
            return (byte)(total / (rows * cols));
        }

        public Bitmap ToHeatmap() {
            HSVImage Heatmap = new HSVImage(cols, rows);
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    Heatmap.Map[col, row] = new HSV(255 - Map[col, row], 1, 1);
                }
            }
            return Heatmap.ToBitmap();
        }

    }

}
