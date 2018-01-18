// Class: Detector
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace ImageIdentifier {
    public partial class MainForm : Form {

        #region Variables
        private Bitmap bmpAnalysed;
        private Result Results = new Result();
        private XMLInterface XML;
        private int rootIndex = 0;
        private int clickedLvl = 0;
        #endregion

        #region Interface

        #region Dynamic Controls
        // Gets XML Tree node clicked
        private void xmlTree_AfterSelect(object sender, TreeViewEventArgs clicked) {
            TreeNode tempNode = ((TreeView)sender).SelectedNode;                    // Finds selected node
            while (tempNode.Parent != null) {                                       // Cycles through each parent node
                tempNode = tempNode.Parent;                                         // Sets node to parent node
            }
            rootIndex = tempNode.Index;                                             // Sets root node index
            clickedLvl = ((TreeView)sender).SelectedNode.Level;                     // Finds the depth of the clicked node
            bool searching = !string.IsNullOrEmpty(boxSearch.Text);                 // Determines whether user is using search box
            XML.Clicked(clicked, clickedLvl, rootIndex, Results, searching);        // Calls XML Click function
        }

        // Advanced mode option
        private void boxAdv_CheckedChanged(object sender, EventArgs e) {
            if (chkboxAdv.Checked)                                          // If advanced mode selected
                Width = 1167;                                               // Extend form
            else if (!chkboxAdv.Checked)                                    // If not...
                Width = 688;                                                // Reduce form
        }

        // Gets search box changed event
        private void boxSearch_TextChanged(object sender, EventArgs e) {
            XML.Refresh();                                                  // Refreshes XML data
            xmlTree.Nodes[0].Nodes.Clear();                                 // Clears tree nodes
            if (boxSearch.Text == string.Empty) {                           // If the search box is empty
                XML.Collapse();                                             // Reduces the tree
                btnClearSearch.Enabled = false;                             // Nothing to clear
            } else {                                                        // If search is occurring...
                XML.Search(boxSearch.Text);                                 // Searches XML with the query
                dataAttribs.Rows.Clear();                                   // Clears rows from the data table
                btnClearSearch.Enabled = true;                              // Allows clearing of text
            }
        }

        // Receives key down
        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F5 && btnAnalyse.Enabled == true) {       // If F5 is pressed, and analysing allowed
                Analyse();                                                  // Alternative way to call Analyse function
            }
        }

        #endregion

        #region Button Controls
        // Triggers analysis function
        private void btnAnalyse_Click(object sender, EventArgs e) {
            Analyse();                                                     // Calls Analyse function
        }

        // Gets Import button click
        private void btnImport_Click(object sender, EventArgs e) {
            using (OpenFileDialog dlg = new OpenFileDialog()) {            // Creates temporary dialog box
                dlg.Title = "Open Image";                                  // Sets title
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files " +        // Allows 3 file types to be selected
                             "(*.png)|*.png|GIF Files (*.gif)|*.gif";      //
                if (dlg.ShowDialog() == DialogResult.OK) {                 // If submit button clicked...
                    SetImage(dlg.FileName);                                // Submits selected image for validation
                }
            }
        }

        // Resets form to state before analysis
        private void btnReset_Click(object sender, EventArgs e) {
            Reset();                                                       // Resets the form to its original state

        }

        // Gets search button clear button event
        private void btnClearSearch_Click(object sender, EventArgs e) {
            boxSearch.Clear();                                             // Clears the search query  
            btnClearSearch.Enabled = false;                                // Nothing to clear
        }

        // Reverts the XML table to the file values
        private void btnRevert_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to refresh from file?\n" +        // Checks that the user is sure
                "Any unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, //
                MessageBoxIcon.Question) == DialogResult.Yes) {                          // If so...
                boxSearch.Clear();                                                       // Clears search query
                btnUpdate.Enabled = false;                                               // Prevents updating
                XML.Refresh();                                                           // Refreshes XML data
            }
        }

        // Opens the raw templates file for manual editing
        private void btnFile_Click(object sender, EventArgs e) {
            Process.Start(Directory.GetCurrentDirectory() + "/templates.xml");           // Opens templates xml file with notepad
        }

        // Expands the tree
        private void btnExpand_Click(object sender, EventArgs e) {
            boxSearch.Clear();
            XML.Expand(4);
        }

        // Collapses the tree
        private void btnCollapse_Click(object sender, EventArgs e) {
            XML.Collapse();
        }

        // Triggers the XML Save function
        private void btnUpdate_Click(object sender, EventArgs e) {
            XML.Save(clickedLvl, rootIndex, Results);
            UpdateHash();
        }

        // Triggers the XML Create function
        private void btnCreate_Click(object sender, EventArgs e) {
            XML.Create(clickedLvl, rootIndex, Results);
        }

        // Triggers the XML Delete function
        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this object?",    // Checks that the user is sure
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes) {                                             // If so...
                XML.Delete(clickedLvl);                                            // Deletes
            }
        }

        // Shows the help form
        private void btnHelp_Click(object sender, EventArgs e) {
            Helper helper = new Helper(0);
            helper.Show();
        }

        // Creates save "package"
        private void btnSave_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog()) {          // Creates temporary dialog box
                dlg.Description = "Select Save Destination";                       //
                if (dlg.ShowDialog() == DialogResult.OK) {                         // If submit button clicked...
                    string path = dlg.SelectedPath + "/Image Data - " +            // Finds the path, sets new folder
                                Properties.Settings.Default.name;                  //
                    Directory.CreateDirectory(path);                               // Creates the new folder
                    bmpAnalysed.Save(path + "/Image_Isolated.jpg");                // -------------------------------
                    picOriginal.Image.Save(path + "/Image_Original.jpg");          //
                    picSaliency.Image.Save(path + "/Image_Saliency.jpg");          //
                    picLines.Image.Save(path + "/Image_Orientation.jpg");          // Saves all the processing maps
                    picHeatmap.Image.Save(path + "/Image_Heatmap.jpg");            //
                    picBinary.Image.Save(path + "/Image_Binary.jpg");              //
                    picEdges.Image.Save(path + "/Image_Edges.jpg");                // -------------------------------
                    File.WriteAllText(@path + "/Results.txt", Results.ToFile());   // Writes the results to a text file
                    Process.Start(path);                                           // Opens the containing folder
                }
            }
        }

        // Displays the Sigmoid Graph
        private void btnGraph_Click(object sender, EventArgs e) {
            Graph sigmoid = new Graph();
            sigmoid.Show();
        }

        // Creates template backup
        private void btnBackup_Click(object sender, EventArgs e) {
            int counter = 1;                                                          // Defines initial counter
            string original = Directory.GetCurrentDirectory() + "/templates{0}.xml";  // Sets original path
            string filename = string.Format(original, string.Empty);                  // Finds the actual file name
            while (File.Exists(filename)) {                                           // Loops through each file, checking if it exists
                filename = string.Format(original, counter++);                        // Sets the next file name to an incremented version
            }                                                                         // When the loop ends, the new file name will be unique
            File.Copy(string.Format(original, string.Empty), filename);               // Duplicates the original template, renaming to be new
            MessageBox.Show("Successfully backed up!\n\nLocation:\n" + filename);     // Informs user of successful backup
        }

        // Restores from template backup
        private void btnRestore_Click(object sender, EventArgs e) {
            using (OpenFileDialog dlg = new OpenFileDialog()) {                                   // Creates temporary dialog box
                dlg.Title = "Select Backup";                                                      //
                dlg.Filter = "Template Files (*.xml)|*.xml";                                      // Allows only xml files
                if (dlg.ShowDialog() == DialogResult.OK) {                                        // If submit button clicked
                    string main = Directory.GetCurrentDirectory() + "/templates.xml";             // Finds the main directory
                    if (GetHash(File.OpenRead(main)) != GetHash(File.OpenRead(dlg.FileName))) {   // If the hashes of templates are different
                        string backup = File.ReadAllText(dlg.FileName);                           // Backup created, populated by old template
                        string current = File.ReadAllText(main);                                  // Target template read
                        File.WriteAllText(main, backup);                                          // Writes everything to current template
                        XML.Refresh();                                                            // Refreshes form data with XML data
                        UpdateHash();                                                             // Creates a new hash for new data
                        MessageBox.Show("Successfully restored from backup!");                    // Informs user of successful restoration
                    } else {                                                                      // If the hashes are the same
                        if (MessageBox.Show("Backup identical to current template, restoration aborted!\n"   // Informs the user of this
                                           + " Would you like to see your MD5 Hash?",                        // Offers to see hash
                            "Restoration Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Information)       //
                            == DialogResult.Yes) {                                                           // If they do...
                            Helper helper = new Helper(6);                                                   // set helper page to hash page
                            helper.Show();                                                                   // show helper
                        }
                    }
                }
            }
        }

        // Closes the application
        private void btnClose_Click(object sender, EventArgs e) {
            Environment.Exit(0);   // Error code 0 means there is no error
        }

        // Wipes the memory file
        private void btnForget_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Are you sure you want to forget everything?\n",  // Checks that the user is sure
                "Confirm", MessageBoxButtons.YesNo,                              //
                MessageBoxIcon.Exclamation) == DialogResult.Yes) {               // If so...
                Properties.Settings.Default.sigmoid = 0.1;                       // Reset sigmoid value
                string empty = "<Templates>\n" +                                 // ----------------------------------
                               "  <Vehicle></Vehicle>\n" +                       //
                               "  <Animal></Animal>\n" +                         //
                               "  <Structure></Structure >\n" +                  // Empties every template of all data
                               "  <Object></Object>\n" +                         //
                               "  <Food></Food>\n" +                             //
                               "</Templates>";                                   // ----------------------------------
                File.WriteAllText("templates.xml", empty);                       // Writes the empty data
                XML.Refresh();                                                   // Refreshes from XML file
                MessageBox.Show("Memory wiped!");                                // Informs user of successful memory wipe
            }
        }

        #endregion

        #region Misc Controls

        // Form Initialisation
        public MainForm() {
            InitializeComponent();                                        // Provides form interface
            XML = new XMLInterface(dataAttribs, xmlTree);                 // Sets XML as an XML interface object
            XML.Refresh();                                                // Fetches XML data from file
            UpdateHash();                                                 // Generates a hash for the file
            comboHint.SelectedIndex = 0;                                  // Sets hint to 'no hint'
            pgColour.Parent = null;                                       // Hides the colour page in advanced mode
            Width = 688;                                                  // Sets initial width to simple mode
            Height = 555;                                                 // Sets height
            XML.btns = new Button[] { btnCreate, btnDelete, btnUpdate };  // Defines the control panel buttons
        }

        // Mouse drags on to picture
        private void picMain_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Link;                              // Changes cursor when dragging image
        }

        // When the user drops a file
        private void picMain_DragDrop(object sender, DragEventArgs e) {
            string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];  // Sets path to that of dragged file
            SetImage(filePath);                                                            // Submits selected image for validation 
        }

        #endregion

        #endregion

        #region Operations

        // Starts the analysis
        private void Analyse() {
            Stopwatch sw = new Stopwatch();                                      // Stopwatch used for timing the analysis
            picOriginal.Image = picMain.Image;                                   // Sets original bitmap
            btnAnalyse.Enabled = false;                                          // Disables analysis button
            sw.Start();                                                          // Starts stopwatch
            GetColour();                                                         // Determines colour
            GetDirection();                                                      // Determines orientation
            XML.knownParent = comboHint.SelectedIndex;                           // Checks if hint provided
            XML.Read(Results);                                                   // Analyses the results
            int counter = 0;                                                     // Defines initial counter
            double last = 0;                                                     // For checking last result
            xmlTree.Nodes[1].Nodes.Clear();                                      // Clears results from last analysis
            foreach (KeyValuePair<string, double> item in XML.responses) {       // Loops through each response
                if (item.Value != last) {                                        // If the value isn't last
                    counter++;                                                   // Increment the counter
                }
                xmlTree.Nodes[1].Nodes.Add(counter + ". " + item.Key);           // Adds result with index to results tree
                last = item.Value;                                               // Updates last
            }
            sw.Stop();                                                           // Stops stopwatch
            string time = ((double)sw.ElapsedMilliseconds / 1000).ToString();    // Converts time from ms to s
            picOriginal.Enabled = true;                                          // --------------------------------
            picSaliency.Enabled = true;                                          //
            picLines.Enabled = true;                                             //
            picHeatmap.Enabled = true;                                           // Allows all the processing
            picBinary.Enabled = true;                                            // maps to be interacted with
            picEdges.Enabled = true;                                             //
            btnReset.Enabled = true;                                             //
            btnSave.Enabled = true;                                              // --------------------------------
            UpdateHSV();                                                         // Updates colour page
            pgColour.Parent = tabAdvanced;                                       // Shows the colour page
            DisplayResults(time);                                                // Shows the results
        }

        // Displays charts
        private void UpdateRGB(int[] mapRed, int[] mapGreen, int[] mapBlue,
                               int rTotal, int gTotal, int bTotal) {
            chrtRGBHisto.Series[0].Points.Clear();                                          // --------------------------
            chrtRHisto.Series[0].Points.Clear();                                            // Clears any previous
            chrtGHisto.Series[0].Points.Clear();                                            // data from RGB graphs
            chrtBHisto.Series[0].Points.Clear();                                            // --------------------------
            for (int col = 0; col < 256; col++) {                                           // Loops through each column
                chrtRHisto.Series[0].Points.AddXY(col, mapRed[col]);                        // --------------------------
                chrtGHisto.Series[0].Points.AddXY(col, mapGreen[col]);                      //
                chrtBHisto.Series[0].Points.AddXY(col, mapBlue[col]);                       // Adds new colour data
                chrtRGBHisto.Series[0].Points.AddXY(col, mapRed[col] + mapGreen[col]        //
                                                    + mapBlue[col]);                        // --------------------------
                chrtRHisto.Series[0].Points[col].Color = Color.FromArgb(col, 0, 0);         // --------------------------
                chrtGHisto.Series[0].Points[col].Color = Color.FromArgb(0, col, 0);         // Sets colour of each piece of
                chrtBHisto.Series[0].Points[col].Color = Color.FromArgb(0, 0, col);         // data to its respective colour
                chrtRGBHisto.Series[0].Points[col].Color = Color.FromArgb(col, col, col);   // --------------------------
            }
            double rgbTot = rTotal + gTotal + bTotal;                                       // Finds RGB total
            chrtRGB.Series[0].Points.Clear();                                               // Clears previous data
            chrtRGB.ChartAreas[0].AxisY.Maximum = rgbTot;                                   // Sets Y-axis maximum to RGB total
            int[] totals = new int[3] { rTotal, gTotal, bTotal };                           // Array to keep track of totals
            for (int channel = 0; channel < 3; channel++) {                                 // Loops through each colour channel
                chrtRGB.Series[0].Points.AddY(totals[channel]);                             // Adds new channel data
                chrtRGB.Series[0].Points[channel].Label = (Math.Round((totals[channel]) /   // Sets label to the percentage that
                                                          (rgbTot) * 100)).ToString() + "%";// the channel contributes
            }
            chrtRGB.Series[0].Points[0].Color = Color.Red;                                  // ---------------
            chrtRGB.Series[0].Points[1].Color = Color.Green;                                // Sets bar colour
            chrtRGB.Series[0].Points[2].Color = Color.Blue;                                 // ---------------
        }

        // Updates the HSV Tab
        private void UpdateHSV() {
            triangleHue.Location = new Point(boxReference.Location.X + (int)(boxReference.Width *     // ---------------------
                                            (Results.Colour.hue / 360)), triangleHue.Location.Y);     // 
            triangleSat.Location = new Point(boxReference.Location.X + (int)(Results.Colour.sat *     // Sets the triangular
                                             boxReference.Width), triangleSat.Location.Y);            // points on sliders
            triangleVal.Location = new Point(boxReference.Location.X + (int)(Results.Colour.val *     //
                                             boxReference.Width), triangleVal.Location.Y);            // ---------------------
            lblBoxHue.BackColor = new HSV(Results.Colour.hue, 1, 1).ToRGB();                          // ---------------------
            lblBoxSat.BackColor = new HSV(Results.Colour.hue, Results.Colour.sat, 1).ToRGB();         // Sets the label colour
            lblBoxVal.BackColor = new HSV(Results.Colour.hue, 0, Results.Colour.val).ToRGB();         // ---------------------
            picColour.BackColor = Results.Colour.ToRGB();                                             // Sets colour box colour
            lblBoxHue.Text = Results.Colour.hue.ToString() + "°";                                     // Displays hue
            lblBoxSat.Text = (Results.Colour.sat * 100).ToString() + "%";                             // Displays saturation
            lblBoxVal.Text = (Results.Colour.val * 100).ToString() + "%";                             // Displays brightness
            lblColour.Text = Results.ColourToText();                                                  // Updates colour label
            lblColour.BackColor = Results.Colour.ToRGB();                                             // Sets label colour
            lblColour.ForeColor = Color.White;                                                        //
            Bitmap destBitmap = new Bitmap(boxSaturation.Width, boxSaturation.Height);                // Creates saturation pic
            Graphics painter = Graphics.FromImage(destBitmap);                                        // Painter object for pic
            using (LinearGradientBrush brush = new LinearGradientBrush(boxSaturation.ClientRectangle, // Paints the saturation
                   Color.White, new HSV(Results.Colour.hue, 1, 1).ToRGB(), 0F))                       // as a gradient to the pic
                   painter.FillRectangle(brush, boxSaturation.ClientRectangle);                       //
            painter.Dispose();                                                                        // Removes painter object
            boxSaturation.Image = destBitmap;                                                         // Sets saturation bitmap
        }

        // Displays the best results
        private void DisplayResults(string time) {          
            if (XML.responses[0].Key != "Unknown") {                                                        // If a result is found...
                MessageBox.Show("Identified: " + Results.ColourToText() + " " + Results.ListToString() +    // Shows results
                Environment.NewLine + "Confidence: " + Results.Confidence + "%" + Environment.NewLine +     //
                "Time taken: " + time + " Seconds");                                                        // Including time taken
                xmlTree.SelectedNode = xmlTree.Nodes[1].Nodes[0];                                           // Selectes first result
                if (Results.Confidence > 90 && Results.Confidence != 100 && XML.responses.Count <= 2 &&     // If confidence is high
                    MessageBox.Show("High accuracy " + "analysis suspected. Learn?\nDetails: [" +           // Alert user that the analysis was
                    Results.objParent + ", " + Results.objName + "]", "Auto-Learn", MessageBoxButtons.YesNo,// high accuracy, offer auto-learn
                    MessageBoxIcon.Question) == DialogResult.Yes) {                                         // If accepted
                    XML.Record(Results, false, Results.objName,                                             // Automatically learn object data
                               comboHint.Items.IndexOf(Results.objParent) - 1);                             //
                }
            } else {                                                                                        // If no object found...
                MessageBox.Show("Unknown Item!\nThe object could not be identified.");                      // Inform the user
            }
        }

        // Checks integrity, resizes, and sets as image
        private void SetImage(string filePath) {
            try {                                                                            // Assumes file is valid
                Reset();                                                                     // Clears the form
                picMain.Image = new Bitmap(filePath);                                        // Sets image as imported image
                if (picMain.Image.Width * picMain.Image.Height > 600 * 600) {                // Checks if image is large
                    if (picMain.Image.Width > picMain.Image.Height) {                        // If wider than tall
                        double ratio = (double)picMain.Image.Width / picMain.Image.Height;   // Find the ratio
                        picMain.Image = new Bitmap(picMain.Image, (int)(ratio * 600), 600);  // Resize, setting height as 500
                    } else {                                                                 // If taller than wide
                        double ratio = (double)picMain.Image.Height / picMain.Image.Width;   // Find the ratio
                        picMain.Image = new Bitmap(picMain.Image, 600, (int)(ratio * 600));  // Resize, setting width as 600
                    }
                    Properties.Settings.Default.name =                                       // Record name as file name
                                    Path.GetFileNameWithoutExtension(filePath);              //
                }
            } catch {                                                                        // If there was an error...
                MessageBox.Show("Invalid File. The file must be an image.");                 // File was of invalid format
            }
        }

        // Displays the clicked image
        private void ShowImage(object sender, EventArgs e) {
            if (((PictureBox)sender).Image != Properties.Resources.Blank   // If image isn't blank
                & btnAnalyse.Enabled == false) {                           // and analysis allowed
                Image clicked = ((PictureBox)sender).Image;                // Create image for clicked image
                string path = Path.GetTempPath() + "clickedImage.jpg";     // Create a temporary path
                clicked.Save(path);                                        // Save the temporary image to path
                Process.Start(path);                                       // Open the temporary image from path
            }
        }

        // Resets the form
        private void Reset() {
            Results.Clear();                               // Clears the results
            picMain.Image = picOriginal.Image;             // Resets main image
            chrtRGB.Series[0].Points.Clear();              // Clears RGB chart
            pgColour.Parent = null;                        // Hides the colour page
            dataAttribs.Rows.Clear();                      // Removes template data
            Bitmap bmpBlank = Properties.Resources.Blank;  // Define blank bitmap
            boxSearch.Clear();                             // Clears search box
            picOriginal.Image = bmpBlank;                  // ----------------------
            picSaliency.Image = bmpBlank;                  //
            picLines.Image = bmpBlank;                     // Sets the processing maps
            picHeatmap.Image = bmpBlank;                   // to all be blank bitmaps
            picBinary.Image = bmpBlank;                    //
            picEdges.Image = bmpBlank;                     // ----------------------
            xmlTree.Nodes[1].Nodes.Clear();                // Clears result nodes
            btnAnalyse.Enabled = true;                     // Enables analysis button
            btnReset.Enabled = false;                      // Disables resetting
            btnSave.Enabled = false;                       // Disables saving
            XML.SwitchButtons(false);                      // Disables control panel buttons
        }

        #endregion

    }

}