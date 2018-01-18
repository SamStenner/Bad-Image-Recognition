// Class: Determiner
using System;
using System.Collections.Generic;

namespace ImageIdentifier
{
    public partial class XMLInterface {

        // Merge Sort for sorting scores
        private List<KeyValuePair<string, double>> MergeSort(
                                  List<KeyValuePair<string, double>> nums) {
            if(nums.Count == 1) {                                              // Initially checks whether finished
                return nums;                                                   // If so, it returns the list
            } else {                                                           // Otherwise:
                int midPoint = (int)Math.Floor((decimal)(nums.Count / 2));     // Finds the midpoint. If no midpoint, left of centre.
                List<KeyValuePair<string, double>> left = new List             // Creates a list for the left half
                                  <KeyValuePair<string, double>>();            //
                List<KeyValuePair<string, double>> right = new List            // Creates a list for the right half
                                  <KeyValuePair<string, double>>();            //
                int current = 0;                                               // Constant to keep track of point
                foreach(KeyValuePair<string, double> entry in nums) {          // Loops through each element in the entire list
                    if (current < midPoint)                                    // If to the left of mid:
                        left.Add(new KeyValuePair<string,                      // Add point to left list
                                 double>(entry.Key, entry.Value));             //
                    else                                                       // Otherwise:
                        right.Add(new KeyValuePair<string,                     // Add point to right list
                                  double>(entry.Key, entry.Value));            //
                    current++;                                                 // Increment point counter
                }
                left = MergeSort(left);                                        // Recursively sort left list by putting it on stack
                right = MergeSort(right);                                      // Recursively sort right list by putting it on stack
                List<KeyValuePair<string, double>> tempList = new List         // Create a temporary list to hold values
                                  <KeyValuePair<string, double>>();            //
                int both = left.Count + right.Count;                           // Get total length of left and right lists
                for (int i = 0; i != both; i++) {                              // Loop for this length
                    if (left.Count == 0) {                                     // If the left list is empty:
                        tempList.AddRange(right);                              // Add the remaining values from right list to temp
                        break;
                    }
                    if (right.Count == 0) {                                    // If the right list is empty:
                        tempList.AddRange(left);                               // Add the remaining values from the left list to temp
                        break;
                    } else if(left[0].Value > right[0].Value) {                // If the leading left is greater than that of right
                        tempList.Add(left[0]);                                 // Add the leading value of left to temp
                        left.RemoveAt(0);                                      // Destroy leading value of left
                    } else {                                                   // Assuming leading right is greater or equal to left
                        tempList.Add(right[0]);                                // Add the leading value of right to temp
                        right.RemoveAt(0);                                     // Destroy leading value of right
                    }
                }
                return tempList;                                               // This layer of the stack is now sorted and returned
            }
        }   
        
        // Compares recorded to result to a template
        private double[] Compare(int parent, int child, Result avResult, Result Result) {
            double[] result = new double[3] { parent, child, 0 };                               // Creates empty result
            int colRelevance = 7;                                                               // How important colour is
            if (avResult.Colour.sat * avResult.Colour.val <= 0.2)                               // If the image isn't very colourful
                colRelevance = 3;                                                               // The colour won't be very useful
            result[2] += GetSigmoidScore(Result.Colour.hue, avResult.Colour.hue,                // ---------------------------------- 
                                         Result.Variation[0], 360, true, colRelevance);         //
            result[2] += GetSigmoidScore(Result.Colour.sat, avResult.Colour.sat,                //
                                         Result.Variation[1], 1, false, 2);                     //
            result[2] += GetSigmoidScore(Result.Colour.val, avResult.Colour.val,                //
                                         Result.Variation[2], 1, false, 2);                     //
            result[2] += GetSigmoidScore(Result.Direction[0], avResult.Direction[0],            //  Finds all the sigmoid scores for the
                                         15, 100, false, 3);                                    //  attributes provided by the result
            result[2] += GetSigmoidScore(Result.Direction[1], avResult.Direction[1],            //
                                         15, 100, false, 3);                                    //
            result[2] += GetSigmoidScore(Result.Direction[2], avResult.Direction[2],            //
                                         15, 100, false, 2);                                    //
            result[2] += GetSigmoidScore(Result.Density, avResult.Density, 0.1, 1, false, 1);   //
            return result;                                                                      // ----------------------------------
        }

        // Finds the sigmoid score between two attributes
        public double GetSigmoidScore(double Value, double Centre, double Range,
                                      int Max, bool Circular, int Weight) {
            double shift = Value - Centre;                                                      // Finds shift
            if(Circular) {                                                                      // If quantity is circular:
                shift = ((Value - Centre + (Max / 2)) % (Max)) - (Max / 2);                     // Edit shift
            }
            if(shift == 0) {                                                                    // If value identical to template
                return Weight;                                                                  // Returns maximum possible score
            }
            double sharp = Properties.Settings.Default.sigmoid;                                 // Retrieves user-defined sharpness
            double response = Math.Round((Weight / (1 + Math.Pow(Math.E, sharp *                // Performs sigmoid calculation
                              (Math.Abs(shift) - Range)))), 3);
            return response;                                                                    // Returns the value
        }

    }
}
