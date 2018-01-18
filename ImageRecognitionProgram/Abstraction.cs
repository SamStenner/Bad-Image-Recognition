// Class: Abstraction
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Security.Cryptography;

namespace ImageIdentifier {
    public partial class MainForm : Form {

        // Identifies the salient region using average colour
        private void GetColour() {
            Fitmap fmpOrg = new Fitmap((Bitmap)picOriginal.Image);      // Converts original image to a fitmap
            int rows = fmpOrg.height;                                   // Defines row counter as the image height in pixels
            int cols = fmpOrg.width;                                    // Defines column counter as the image width in pixels
            HSVImage hsvImage = new HSVImage(fmpOrg);                   // Creates an HSV matrix of the original image
            GreyImage saliencyMap = new GreyImage(cols, rows);          // Creates a blank saliency map of the original image
            HSV avHSV = hsvImage.Average();                             // Calculates the average HSV of all the pixels in the matrix
            double avHue = avHSV.hue;                                   // ---
            double avSat = avHSV.sat;                                   // Defines average HSV values as the attributes of the average HSV
            double avVal = avHSV.val;                                   // ---
            double mxValue = 0;                                         // Defines the max Variance as zero
            double[] varies = new double[3];                            // Defines an array for the Variances
            for (int row = 0; row < rows; row++) {                      // Loops through each row of the matrix
                for (int col = 0; col < cols; col++) {                  // Loops through each column of the matrix
                    varies = GetVariance(hsvImage.map[col, row],        //
                                         avHue, avSat, avVal);          // Finds the variation between the HSV of the pixels
                    if (varies[0] + varies[1] + varies[2] > mxValue) {  // Tests to see if sum of Variances exceeds the current max
                        mxValue = varies[0] + varies[1] + varies[2];    // If so, it sets the new max to sum of that Variance
                    }
                }
            }
            mxValue /= 255;                                                      // Divides to convert to bytes
            for (int row = 0; row < rows; row++){                                // Loops through each row of the matrix
                for (int col = 0; col < cols; col++){                            // Loops through each column of the matrix
                    varies = GetVariance(hsvImage.map[col, row],                 //
                             avHue, avSat, avVal);                               // Finds the variation between the HSV of the pixels
                    saliencyMap.Map[col, row] = (byte)((varies[0] + varies[1] +  // Sets the saliency of that pixel to be the sum of the
                                                varies[2]) / mxValue);           // variances, divided by the maximum Variance
                }
            }
            double threshold = saliencyMap.Average();                 // Defines the average intensity using the saliency map average
            HSVImage foreground = new HSVImage(fmpOrg);               // Creates another HSV matrix of the original image
            HSVImage background = new HSVImage(fmpOrg);               // Creates another HSV matrix of the original image
            HSVImage binary = new HSVImage(cols, rows);               // Creates another HSV matrix for the binary image
            int rTotal = 0, gTotal = 0, bTotal = 0, usedPixels = 0;   // Defines total RGB values
            int[] mapR = new int[256];                                // ---
            int[] mapG = new int[256];                                // Creates an integer array to count colour amounts
            int[] mapB = new int[256];                                // ---
            Color current = new Color();                              // Colour object for checking the current colour
            for (int row = 0; row < rows; row++) {                    // Loops through each row of the saliency map
                for (int col = 0; col < cols; col++) {                // Loops through each column of the saliency map
                    if (saliencyMap.Map[col, row] < threshold) {      // Checks whether the current pixel meets the threshold
                        foreground.map[col, row] = new HSV();         // If not, it sets it to white
                        binary.map[col, row] = new HSV();             // Sets the pixel to white in the binary image
                    } else {                                          // If the saliency value does meet the threshold
                        binary.map[col, row] = new HSV(Color.Black);  // Sets the pixel to black in the binary image
                        background.map[col, row] = new HSV();         // Sets the background pixel to blank
                        current = fmpOrg.GetPixel(col, row);          // Finds the current pixel in the original image
                        rTotal +=  current.R;                         // ---
                        gTotal += current.G;                          // If so, it adds the RGB values to the RGB totals
                        bTotal += current.B;                          // ---
                        mapR[current.R]++;                            // ---
                        mapG[current.G]++;                            // Increments the amount of each colour in each map
                        mapB[current.B]++;                            // ---
                        usedPixels++;                                 // Increments the counter of how many pixels were 'successful'
                    }
                }
            }
            UpdateRGB(mapR, mapG, mapB, rTotal, gTotal, bTotal);                 // Updates the graphics
            HSV avCol = new HSV(Color.FromArgb((rTotal / usedPixels),            // Defines a new HSV to store average colour
                               (gTotal / usedPixels), (bTotal / usedPixels)));
            Results.Colour = avCol;                                              // Sets the hue result to the average hue 
            Results.Variation = new double[3] { 30, 0.2, 0.2 };                  // Sets default variation
            bmpAnalysed = foreground.ToBitmap();                                 // Puts analysed image on the form
            picMain.Image = bmpAnalysed;                                         // Sets the picture box image to the new image as a bitmap
            picSaliency.Image = saliencyMap.ToBitmap();                          // Updates the saliency map image
            picBinary.Image = binary.ToBitmap();                                 // Updates the binary pixel image
            picHeatmap.Image = saliencyMap.ToHeatmap();                          // Updates the heatmap image
            Results.Density = Math.Round((double)usedPixels                      // Sets average density
                              / (double)(rows * cols), 2);
        }

        // Identifies salient region's average orientation
        private void GetDirection() {
            double cannyThreshold = 230;                                 // Defines the upper limit for the Canny
            double cannyThresholdLinking = 100;                          // Defines the lower limit for the Canny (Ratio between 2 & 3)
            Mat cannyEdges = new Mat();                                  // The matrix used to record the edges                           
            Mat matrix = new Mat();                                      // Temporary drawable matrix
            Image<Bgr, byte> img = new Image<Bgr, byte>
                                   ((Bitmap)(picMain.Image));            // The original bitmap converted to an Emgu Image
            Image<Bgr, byte> cleanImg = img;                             // Creates a clean copy
            img = img.SmoothGaussian(5);                                 // Smooths out the image to remove noise (5x5 Kernal)
            CvInvoke.CvtColor(img, matrix, ColorConversion.Bgr2Gray);    // Converts entire image to grey, records on uimage
            CvInvoke.Canny(matrix, cannyEdges,
                           cannyThreshold, cannyThresholdLinking);       // Finds the edges, writes them to the cannyEdges matrix
            LineSegment2D[] lines = CvInvoke.HoughLinesP(cannyEdges,     // Uses Hough Transform to create array of the lines
                            1, Math.PI / 45.0, 15, 30, 10);              // Standard values used for finding lines
            LineSegment2D flat = new LineSegment2D(new Point(0, 0),      // Defines a flat line to compare other lines to
                                 new Point(1, 0));
            double vertical = 0, horizontal = 0, diagonal = 0;           // Defines counters for the average orientation
            HSV res = new HSV((Results.Colour.hue + 180) % 360, 1, 1);   // Finds the opposite colour to the average of the image
            Color lineCol = res.ToRGB();                                 // Sets line colour to that to make lines easily visible
            double angle = 0;                                            // Sets angle initially to zero
            foreach (LineSegment2D line in lines) {                      // Loops through every line found
                angle = Math.Abs(                                        // Gets the angle between the line found and the horizontal
                        line.GetExteriorAngleDegree(flat)) % 180;        // to be absolute difference, normalised between 0° & 180°
                angle = angle > 90 ? 180 - angle : angle;                // If angle larger than 90°, subtract from 180°. Else, leave it
                if (angle < 30)                                          // If the angle is less than 30°
                    horizontal += line.Length;                           // It is horizontal, so add the 'magnitude' of the line
                else if (angle >= 60) {                                  // etc...
                    vertical += line.Length;                             // --
                } else {                                                 // --
                    diagonal += line.Length;                             // --
                }
                cleanImg.Draw(line, new Bgr(lineCol.B,
                              lineCol.G, lineCol.R), 1);                 // Draws the line to the fresh copy of the original image
            }
            Results.Direction[0] = Math.Round(vertical / (vertical +     // Sets vertical value to percentage of total lines that
                                   horizontal + diagonal), 3) * 100;     // were vertical
            Results.Direction[1] = Math.Round(horizontal / (vertical +   // etc...
                                   horizontal + diagonal), 3) * 100;     // --
            Results.Direction[2] = Math.Round(diagonal / (vertical +     // --
                                   horizontal + diagonal), 3) * 100;     // --
            picLines.Image = cleanImg.Bitmap;                            // Updates line image
            picEdges.Image = cannyEdges.Bitmap;                          // Updates edge image
        }

        // Determines the sum of square's Variance
        private double[] GetVariance(HSV current, double mnHue,
                                     double mnSat, double mnVal) {
            double[] vals = new double[3];                               // Defines array to store the Variances
            double dif0 = (current.hue * (255 / 360)) - mnHue;           // Finds difference between hue and average hue (Then converts to 0 ≤ H ≤ 255)
            double dif1 = (current.sat * 255) - mnSat;                   // Gets difference between saturation and average saturation, converts 0 ≤ S ≤ 255)
            double dif2 = (current.val * 255) - mnVal;                   // Gets difference between brightness and average brightness, converts 0 ≤ V ≤ 255)
            vals[0] = dif0 * dif0 * 4;                                   // ---
            vals[1] = dif1 * dif1 * 3;                                   // Sets the array of values to the squares of the differences (the Variances)
            vals[2] = dif2 * dif2 * 5;                                   // ---
            return vals;                                                 // Returns the array
        }

        // Generates an MD5 hash
        private string GetHash(Stream plain) {
            using (var md5 = MD5.Create()) {                         // Instantiates an MD5 object
                byte[] array = md5.ComputeHash(plain);               // Computes a byte array (the hash) of the file
                StringBuilder hash = new StringBuilder();            // Creates a string builder object
                for (int i = 0; i < array.Length; i++) {             // Reads every byte in the array
                    hash.Append(array[i].ToString("x2"));            // Converts to bytes t strings and adds to total string
                }
                plain.Dispose();                                     // Closes the connection to the plain text file
                return hash.ToString();                              // Returns the hash as a string
            }
        }

        // Updates the hash in the settings
        private void UpdateHash() {
            string path = Directory.GetCurrentDirectory() + "/templates.xml";     // Defines the default template path
            ImageIdentifier.Properties.Settings.Default.hash                      // Sets the hash for the current template
                            = GetHash(File.OpenRead(path));
        }

    }
}