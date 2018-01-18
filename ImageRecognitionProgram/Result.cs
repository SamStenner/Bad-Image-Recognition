// Class: Result
using System.Collections.Generic;
using System.Drawing;

namespace ImageIdentifier {

    public class Result {
        public string objName = "Unknown";                           // Defines object name
        public string objParent = "Unknown";                         // Defines parent object
        public HSV Colour = new HSV(Color.Black);                    // Defines average colour
        public double[] Variation = new double[3] { 0, 0, 0 };       // Defines average colour variation
        public double[] Direction = new double[3];                   // Defines average orientation
        public double Density = 0.25;                                // Defines average density
        public double Confidence = 0;                                // Defines confidence level
        public List<string> List = new List<string>();               // Defines list of possible responses

        // Clears current results
        public void Clear() {
            objName = "Unknown";                                     // Resets name
            objParent = "Unknown";                                   // Resets type
            HSV Colour = new HSV(Color.Black);                       // Sets colour to be black
            Variation = new double[3] { 30, 0.2, 0.2 };              // Sets array for default variation
            Direction = new double[3];                               // Empty array for direction
            Density = 0.25;                                          // Sets default density
            Confidence = 0;                                          // Sets default confidence
            List = new List<string>();                               // Empties list of responses
        }

        // Converts possible responses to a string
        public string ListToString() {
            string each = string.Empty;      // Creates empty string
            foreach (string type in List) {  // Loops list
                each += type + "/";          // Concatenates list, adds slash
            }
            each = each.TrimEnd('/');        // Removes extra slash
            return each;                     // Returns list
        }

        // Converts HSV Colour to intelligible text
        public string ColourToText() {
            if (Colour.sat > 0.3) {            // If colour is saturated...
                if (Colour.val > 0.05) {       // If colour isn't dark...
                    if (Colour.hue >= 340 || Colour.hue < 15)                    // ----------
                        return Colour.sat > 0.4 ? "Red" : "Pink";                //
                    if (Colour.hue >= 15 && Colour.hue < 34)                     //
                        return Colour.val > 0.5 ? "Orange" : "Brown";            //
                    if (Colour.hue >= 34 && Colour.hue < 78)                     //
                        return Colour.sat > 0.55 ? "Yellow" : "Brown";           // Sets colour
                    if (Colour.hue >= 78 && Colour.hue < 160)                    // based on
                        return Colour.val > 0.55 ? "Light Green" : "Dark Green"; // HSV values
                    if (Colour.hue >= 160 && Colour.hue < 260)                   //
                        return Colour.val > 0.65 ? "Light Blue" : "Dark Blue";   //
                    if (Colour.hue >= 260 && Colour.hue < 285)                   //
                        return "Purple";                                         // 
                    if (Colour.hue >= 285 && Colour.hue < 340)                   //
                        return "Pink";                                           // ----------
                } else {                      // If colour is very dark
                    return "Black";           // Set to black
                }
            } else {                          // Else colour not saturated...
                if (Colour.val > 0.7)         // If colour is bright...
                    return "White";
                if (Colour.val > 0.4)         // If colour is somewhat bright
                    return "Grey";
                else                          // Else colour is not bright
                    return "Black";        
            }
            return "[Unknown Colour]";
        }

        // Saves all text to a text file
        public string ToFile() {
            string all = "Results:\n\nObjects:\n";         // String to write
            foreach (string type in List) {                // Loops through responses
                all += "- " + type + "\n";                 // Adds each response, line separated
            }
            // The following code adds all the attributes to the string
            all += "\nConfidence: " + Confidence + "%\n";
            Color RGB = Colour.ToRGB();
            all += "\nColour:\n" + "      HSV: " + Colour.hue + ", " + Colour.sat + ", " + Colour.val + "\n" +
                                   "      RGB: " + RGB.R + ", " + RGB.G + ", " + RGB.B + "\n";
            all += "\nDirection:\n" + "      Vertical: " + Direction[0] + "%\n" +
                                      "      Horizontal: " + Direction[1] + "%\n" +
                                      "      Diagonal: " + Direction[2] + "%\n";
            return all; // Returns the string
        }

        // Converts responses to a dictionary
        public Dictionary<string, string> GetValues() {
            Dictionary<string, string> values = new Dictionary<string, string>();            // Defines empty dict
            values.Add("Colour", Colour.hue + "," + Colour.sat + "," + Colour.val);          // ------------------ 
            values.Add("Variation", Variation[0] + "," + Variation[1] + "," + Variation[2]); // Adds all the result
            values.Add("Direction", Direction[0] + "," + Direction[1] + "," + Direction[2]); // data to dictionary
            values.Add("Density", Density.ToString());                                       // ------------------
            return values;                                                                   // Returns dictionary
        }

    }
}
