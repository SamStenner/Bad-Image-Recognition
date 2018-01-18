// Class: Graph
using System;
using System.Windows.Forms;

namespace ImageIdentifier {
    public partial class Graph : Form {
        public Graph() {
            InitializeComponent();
            LoadGraph();
        }

        // Sets up initial values
        private void LoadGraph() {
            double sigmoid = Properties.Settings.Default.sigmoid;                         // Retrieves stored sigmoid
            if (sigmoid == 600) {                                                         // Checks if binary result
                boxBinary.Checked = true;                                                 // If so, draw
            } else {                                                                      // If not binary
                barCoeff.Value = (int)(sigmoid);                                          // Update graph
            }
            lblSharpness.Text = "Sharpness: " + (sigmoid/10).ToString();                  // Update label
            DrawGraph(sigmoid/10);                                                        // Draws
        }

        // Registers coefficient scroll event
        private void barCoeff_Scroll(object sender, EventArgs e) {
            btnSigSave.Enabled = true;                                                    // Allows saving
            btnSigReset.Enabled = true;                                                   // Allows resetting
            lblSharpness.Text = "Sharpness: " + ((double)barCoeff.Value / 10).ToString(); // Updates label
            boxBinary.Checked = false;                                                    // Disables binary
            DrawGraph((double)barCoeff.Value/10);                                         // Draws
        }

        // Plots data to the graph
        private void DrawGraph(double sharp) {
            double max = barMaximum.Value;                                         // -------------------------
            double range = barRange.Value;                                         // Sets values as bar values
            double pos = barPosition.Value;                                        // -------------------------
            double shift = 0;                                                      // Difference between value and perfect value
            barPosition.Maximum = (int)max;                                        // Sets current position to max
            lblMaximum.Text = "Maximum: " + barMaximum.Value.ToString();           // -------------------------
            lblRange.Text = "Range: " + barRange.Value.ToString();                 // Updates labels
            lblPosition.Text = "Position: " + barPosition.Value.ToString();        // -------------------------
            chrtSigmoid.Series[0].Points.Clear();                                  // Clears the old graph data
            chrtSigmoid.Series[0].BorderWidth = 3;                                 // Makes thicker
            if(boxCircular.Checked) {                                              // If quantity circular
                barRange.Maximum = (int)max / 2;                                   // Range needs to wrap, so halved
                for(double x = 0; x <= 2 * max; x += 2) {                          // Loops through graph
                    shift = ((x - pos + (max / 2)) % (max)) - (max / 2);           // Finds the shift
                    chrtSigmoid.Series[0].Points.Add(1 / (1 + Math.Pow(Math.E,     // Plots data according to the equation
                                           sharp * (Math.Abs(shift) - range))));   // 
                }
                chrtSigmoid.ChartAreas[0].AxisX.Minimum = max / 2;                 // Adjusts graph dimensions to fit data
                chrtSigmoid.ChartAreas[0].AxisX.Maximum = max;                     // ---
            } else {                                                               // If quantity not circular
                barRange.Maximum = (int)max;                                       // Range doesn't need to wrap, so set to max
                for(double x = 0; x <= max; x += 1) {                              // Loops through graph
                    shift = x - pos;                                               // Finds the shift
                    chrtSigmoid.Series[0].Points.Add(1 / (1 + Math.Pow(Math.E,     // Plots the data according to the equation
                                           sharp * (Math.Abs(shift) - range))));   //
                }
                chrtSigmoid.ChartAreas[0].AxisX.Minimum = 0;                       // Adjusts graph dimensions to fit data
                chrtSigmoid.ChartAreas[0].AxisX.Maximum = max;                     // ---
            }
        }

        // Saves the chosen sharpness
        private void btnSigSave_Click(object sender, EventArgs e) {
            Properties.Settings.Default.sigmoid = boxBinary.Checked ?              // Sets the sigmoid value
                                                  600 : barCoeff.Value;            //
            Properties.Settings.Default.Save();                                    // Saves the value
            Close();                                                               // Closes the graph form
        }

        // Sigmoid help request
        private void btnHelp_Click(object sender, EventArgs e) {
            Helper helper = new Helper(5);
            helper.Show();
        }

        // Resets the form
        private void btnSigReset_Click(object sender, EventArgs e) {
            LoadGraph();
            btnSigSave.Enabled = false;
            btnSigReset.Enabled = false;
        }

        // If user wants binary tolerance
        private void boxBinary_CheckedChanged(object sender, EventArgs e) {
            barCoeff.Value = 60;                                                   // Sets bar to max
            btnSigReset.Enabled = true;                                            // Enables saving the change
            btnSigSave.Enabled = true;                                             // Enables resetting
            if (boxBinary.Checked) {                                               // If binary
                lblSharpness.Text = "Sharpness: 60";                               // Set high sharpness
                DrawGraph(60);                                                     // Draw
            } else {                                                               // If not binary
                lblSharpness.Text = "Sharpness: 6" ;                               // Set to coeff max value
                DrawGraph(6);                                                      // Draw
            }
        }

        // Event handler for the scroll events
        private void valueChanged(object sender, EventArgs e) {
            DrawGraph((double)barCoeff.Value / 10);
        }

    }
}
