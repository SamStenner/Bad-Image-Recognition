// Class: XML Interface
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace ImageIdentifier {

    public partial class XMLInterface {

        #region Variables

        public XmlDocument xmlFile = new XmlDocument();                   // Defines the XML File
        private TreeView xmlTree;                                         // Defines the XML Tree
        private DataGridView dataAttribs;                                 // Defines the Data Grid
        public int selectedNode;                                          // Defines the parent node
        public int childNode;                                             // Defines the child node
        public int knownParent;                                           // For when image hint not zero
        public List<KeyValuePair<string, double>> responses =             // Defines the responses dictionary
               new List<KeyValuePair<string, double>>();                  //
        public Button[] btns;                                             // Array of buttons

        #endregion

        #region Operations

        // Constructor: Assigns variable values
        public XMLInterface(DataGridView table, TreeView tree) {
            SafeLoad();
            xmlTree = tree;                                              // The tree becomes that of the form
            dataAttribs = table;                                         // The data table becomes that of the form

        }

        // Determines type of XML level is being clicked
        public void Clicked(TreeViewEventArgs clicked, int level,
                    int root, Result avResult, bool searching) {
            SafeLoad();                                                          // Reloads the data from file 
            switch (root)                                                        // Checks if template or result
            {
                case 0:                                                          // If template:
                    switch (level) {                                             // Checks level selected
                        case 0:                                                  // If 'Templates' node selected
                            dataAttribs.Rows.Clear();                            // Just clear the visible rows
                            SwitchButtons(false);
                            break;
                        case 1:                                                  // If object type clicked
                            dataAttribs.Columns[1].Visible = false;              // ---
                            dataAttribs.Columns[0].Width = 205;                  // Formats the column
                            dataAttribs.Columns[0].HeaderText = "Objects";       // ---
                            selectedNode = clicked.Node.Index;                   // Retrieves the name of the clicked node
                            if (searching) {
                                goto case 2;
                            } else {
                                SwitchButtons(true);
                                DisplayTypes();                                  // Displays children
                            }
                            break;
                        case 2:                                                  // If actual object clicked
                            dataAttribs.Columns[1].Visible = true;               // ---
                            dataAttribs.Columns[0].Width = 75;                   // Formats the column
                            dataAttribs.Columns[0].HeaderText = "Attributes";    // ---
                            selectedNode = clicked.Node.Parent.Index;            // Retrieves the name of the clicked node's parent node
                            childNode = clicked.Node.Index;                      // Retrieves the index of the clicked node
                            if (searching) {
                                SwitchButtons(false);
                                DisplayFound(clicked.Node.Text);                 // Searches for nodes
                            } else {
                                DisplayAttribs("Template", null);                // Displays attributes
                                SwitchButtons(true);
                                btns[0].Enabled = false;
                            }
                            break;
                    }
                    break;
                case 1:                                                          // If result:
                    switch (level) {                                             // Checks level selected
                        case 0:                                                  // If 'Results' node selected
                            SwitchButtons(false);
                            dataAttribs.Rows.Clear();                            // Just clear the visible rows
                            break;
                        case 1:         
                            SwitchButtons(true);
                            btns[1].Enabled = false;
                            dataAttribs.Columns[1].Visible = true;               // ---
                            dataAttribs.Columns[0].Width = 75;                   // Formats the column
                            dataAttribs.Columns[0].HeaderText = "Attributes";    // ---
                            selectedNode = clicked.Node.Index;
                            DisplayAttribs("Result", avResult);
                            break;
                    }
                    break;
            }
        }

        // Finds a specified object
        public void Search(string input) {
            SwitchButtons(false);
            foreach (XmlNode parent in xmlFile.ChildNodes[0].ChildNodes) {   // Loops through object types
                foreach (XmlNode child in parent.ChildNodes) {               // Loops through objects
                    if (child.Name.ToLower().StartsWith(input.ToLower())) {  // If names match...
                        xmlTree.Nodes[0].Nodes.Add(child.Name);              // Add nodes to tree
                    }
                }
            }
            Expand(1);                                                       // Expand tree to show nodes
        }

        // Refreshes the XML data from file
        public void Refresh() {
            SafeLoad();
            XmlNodeList list;                                                 // Defines a list for the parent nodes
            int counter = 0;                                                  // Creates parent counter
            xmlTree.Nodes[0].Nodes.Clear();                                   // Clears any previous nodes
            dataAttribs.Rows.Clear();                                         // Clears any previous rows
            dataAttribs.Refresh();                                            // Refreshes the attributes table
            foreach (XmlNode node in xmlFile.FirstChild.ChildNodes) {         // Loops through every parent node in the XML File
                xmlTree.Nodes[0].Nodes.Add(node.Name);                        // Adds each parent node to the tree 
                list = xmlFile.DocumentElement[node.Name].ChildNodes;         // Populates the list with all the child nodes of the parent
                foreach (XmlNode element in list) {                           // Loops through every child of the current parent node
                    xmlTree.Nodes[0].Nodes[counter].Nodes.Add(element.Name);  // Adds each child node to the tree, under its parent node
                }
                counter++;                                                    // Increments the counter
            }
        }

        // Saves any changes
        public void Save(int level, int root, Result result) {
            switch (root) {                                                                                   // Checks if template or result
                case 0:                                                                                       // If template:
                    switch (level) {                                                                          // Checks tree depth
                        case 1:                                                                               // If top layer:
                            XmlNode parent = xmlFile.DocumentElement.ChildNodes[selectedNode];                // Create a node for the parent node (the root)
                            for (int row = 0; row < dataAttribs.RowCount; row++) {                            // Loop through every row in the data attributes table
                                XmlNode rep = xmlFile.CreateElement(dataAttribs.Rows[row].                    // Create a temporary node with the same name as the current node
                                              Cells[0].Value.ToString());                                     // Since nodes cannot be renamed, they must be cloned and destroyed
                                if (row < parent.ChildNodes.Count) {                                          // If the row is not new:
                                    for (int attrib = 0; attrib < parent.ChildNodes[row].                     // Loop through every attribute from the current node
                                                                  ChildNodes.Count; attrib++) {
                                        rep.AppendChild(parent.ChildNodes[row].ChildNodes[attrib].Clone());   // Add each attribute to the temporary node
                                    }
                                    parent.InsertAfter(rep, parent.ChildNodes[row]);                          // Add the temporary node next to the original node
                                    parent.RemoveChild(parent.ChildNodes[row]);                               // Delete the original node
                                } else {                                                                      // If there are new rows:
                                    Add(rep, parent);                                                         // Add the nodes
                                }
                            }
                            result.objName = parent.Name;
                            break;
                        case 2:
                            XmlNode child = xmlFile.DocumentElement.ChildNodes[selectedNode].ChildNodes[childNode];     // If bottom layer:
                            for (int row = 0; row < dataAttribs.RowCount; row++) {                                      // Loop through every row in the data attributes table
                                try {
                                    child.ChildNodes[row].InnerText = dataAttribs.Rows[row].Cells[1].Value.ToString();  // Updates each attribute with any changes
                                } 
                                catch {
                                    child.ChildNodes[row].InnerText = string.Empty;                                     // If the data attribute doesn't have a value, make empty
                                }
                            }
                            result.objName = child.Name;
                            break;
                    }
                    xmlFile.Save("templates.xml");
                    Refresh();
                    if (root == 0 && level == 1) Expand(3);
                    if (root == 0 && level == 2) Expand(2);
                    MessageBox.Show("Object '" + result.objName + "' was successfully updated!");   // Informs user that update was successful
                    break;
                case 1:                                                                             // If result:
                    ShowLearner(result, false);                                                     // Show learning dialog
                break;
            }
        }

        // Adds a new node
        public void Add(XmlNode rep, XmlNode parent) {
            string[] attributes = new string[4]                                       // Create an array of all the attribute names
                     { "Colour", "Variation","Direction","Density"};                  // Defines the attributes array
            XmlNode[] collection = new XmlNode[4];                                    // Create an array for the new attributes
            for (int attrib = 0; attrib < 4; attrib++) {                              // Loop through all the attributes
                collection[attrib] = xmlFile.CreateElement(attributes[attrib]);       // Add each attribute to the list
                rep.AppendChild(collection[attrib]);                                  // Add the new attribute from the list to the temporary node
            }
            parent.InsertAfter(rep, parent.LastChild);                                // Add the temporary node to the rest of the nodes
        }

        // Creates items
        public void Create(int level, int root, Result result) {
            if (level == 1 && root == 0) {
                btns[1].Enabled = true;
                dataAttribs.Rows.Add("Default_" + xmlFile.DocumentElement.ChildNodes[selectedNode].Name); //Adds a new row to the data attributes table
            } else if (root == 1) {
                ShowLearner(result, true);
            }
        }

        // Deletes items
        public void Delete(int level) {
            XmlNode toDelete = xmlFile.CreateElement("default");
            if (level == 1) {                                                      // If bottom layer
                if (dataAttribs.CurrentCell.RowIndex > xmlFile.DocumentElement.    // If readonly
                    ChildNodes[selectedNode].ChildNodes.Count - 1) {
                    DisplayTypes();
                    return;                                                        // Exit without deleting
                } else {
                    toDelete = xmlFile.DocumentElement.ChildNodes[selectedNode].
                                ChildNodes[dataAttribs.CurrentCell.RowIndex];      // Sets node to be deleted
                }
            } else if (level == 2) {                                                                        // If top layer
                toDelete = xmlFile.DocumentElement.ChildNodes[selectedNode].ChildNodes[childNode];          // Sets node to be deleted
            }
            xmlFile.DocumentElement.ChildNodes[selectedNode].RemoveChild(toDelete);                         // Deletes the node
            xmlFile.Save("templates.xml");                                                                  // Saves the XML file
            Refresh();                                                                                      // Reloads data from file

        }

        // Expands the tree
        public void Expand(int level) {
            xmlTree.Nodes[0].Expand();                                   // Expands the parent branch
            switch (level)                                               // Checks the tree depth
            {
                case 1:                                                  // If top layer
                    DisplayTypes();                                      // Shows the types
                    break;
                case 2:                                                  // If bottom layer
                    DisplayAttribs("Template", null);
                    xmlTree.Nodes[0].Nodes[selectedNode].Expand();       // Expands the previously selected branch
                    break;
                case 3:
                    DisplayTypes();
                    xmlTree.Nodes[0].Nodes[selectedNode].Expand();       // Expands the previously selected branch// Shows the objects
                break;
                case 4:                                                  // Exception instance for expanding every branch, used by 'Expand all' button                                               
                    xmlTree.ExpandAll();
                    break;
            }
        }

        // Collapses the tree
        public void Collapse() {
            xmlTree.CollapseAll();
        }

        // Displays searched for nodes
        private void DisplayFound(string name) {
            int parentCounter = 0, childCounter = 0;
            XmlNodeList list = xmlFile.DocumentElement.ChildNodes;           // Retrieves templates
            foreach (XmlNode parent in xmlFile.ChildNodes[0].ChildNodes) {   // Loops through parent nodes
                foreach (XmlNode child in parent.ChildNodes) {               // Searches children nodes
                    if (name == child.Name) {                                // Checks if name is a match
                        selectedNode = parentCounter;                        // Updates parent node
                        childNode = childCounter;                            // Updates selected node
                        DisplayAttribs("Template", null);                    // Displays the attributes in table
                    }
                    childCounter++;                                          // Increments child counter
                }
                parentCounter++;                                             // Increments parent counter
                childCounter = 0;                                            // Resets child counter
            }
        }

        // Displays the child nodes
        private void DisplayTypes() {
            dataAttribs.Columns[0].ReadOnly = false;
            XmlNodeList list = xmlFile.DocumentElement.
                               ChildNodes[selectedNode].ChildNodes;      // Creates a list of all the child nodes of the parent node
            int row = 0;                                                 // Creates row counter
            dataAttribs.Rows.Clear();                                    // Clears any previous rows
            foreach (XmlNode child in list) {                            // Loops through each child node of the parent node
                dataAttribs.Rows.Add(child.Name);                        // Adds the child node to the data grid
                row++;                                                   // Increments the row counter
            }
            if (row == 0) {
                btns[1].Enabled = false;
            }
        }

        // Displays the attributes of the selected node
        private void DisplayAttribs(string type, Result avResult) {
            dataAttribs.Columns[0].ReadOnly = true;                           // Sets label columns to read only
            XmlNodeList attributes = null;                                    // Defines empty attributes list
            switch (type) {                                                   // Checks type
                case "Template":                                              // If a template
                    attributes = xmlFile.DocumentElement.                     // Creates list of all attributes
                                     ChildNodes[selectedNode].                //
                                     ChildNodes[childNode].ChildNodes;        //
                    break;
                case "Result":                                                // If a result
                    XmlNode root = xmlFile.CreateElement("Root");             // Creates root element
                    Dictionary<string, string> Values = avResult.GetValues(); // Retrieves attributes of result
                    int counter = 0;                                          // Defines initial counter
                    foreach (KeyValuePair<string, string> entry in Values) {  // Loops dictionary of attributes
                        root.AppendChild(xmlFile.CreateElement(entry.Key));   // Adds the attribute name to tree
                        root.ChildNodes[counter].InnerText = entry.Value;     // Adds the data about the attribute
                        counter++;                                            // Increments counter
                    }
                    root.AppendChild(xmlFile.CreateElement("Score"));         // Add a score attribute
                    root.ChildNodes[counter].InnerText =                      // Add score value
                                   responses[selectedNode].Value.ToString();
                    attributes = root.ChildNodes;                             // Update attributes node 
                break;
            }
            int row = 0;                                                 // Creates row counter
            dataAttribs.Rows.Clear();                                    // Clears any previous rows
            foreach (XmlNode attrib in attributes) {                     // Loops through every attribute
                dataAttribs.Rows.Add(attrib.Name);                       // Adds the attribute to the data grid
                dataAttribs.Rows[row].Cells[1].Value = attrib.InnerText; // Adds the value to the attribute to the grid
                dataAttribs.Rows[row].Cells[0].ReadOnly = true;          // Prevents the attribute name being changed
                if (type == "Result")
                    dataAttribs.Rows[row].Cells[1].ReadOnly = true;
                row++;                                                   // Increments the row counter
            }
        }

        // Loads the XML file safely
        private void SafeLoad() {
            try {
                xmlFile.Load("templates.xml");             // Attempts to load the XML file 
            } catch (Exception ex) {
                MessageBox.Show("An error has occured:" +  // If the user has incorrectly formatted
                Environment.NewLine + ex.Message);         // the XML File, it returns an error
                Environment.Exit(110);                     // Closes the program with appropriate code
            }
        }

        // Compares against every template
        public void Read(Result avResult) {
            SafeLoad();
            responses.Clear();                                                   // Clears any previous responses
            int pCounter = 0, cCounter = 0;                                      // Defines initial counters
            Result current = new Result();                                       // Instantiates result object
            double[] thisProp = new double[3] { 0, 0, 0 };                       // For current property
            foreach (XmlNode topNode in xmlFile.ChildNodes[0]) {                 // Loops through each parent node
                XmlNode parent;                                                  // Parent node
                if (knownParent != 0) {
                    pCounter = knownParent - 1;
                    parent = xmlFile.ChildNodes[0].ChildNodes[knownParent - 1];
                } else {
                    parent = topNode;
                }
                double[] tempColour, tempVar, tempDirection;                   // Array of attributes
                foreach (XmlNode child in parent.ChildNodes) {                 // Loops child nodes
                    string name = xmlFile.DocumentElement.ChildNodes[pCounter].ChildNodes[cCounter].Name;
                    try { // Adds all the result data to the array
                        tempColour = Array.ConvertAll(child.ChildNodes[0].InnerText.Split(','), double.Parse);
                        tempVar = Array.ConvertAll(child.ChildNodes[1].InnerText.Split(','), double.Parse);
                        tempDirection = Array.ConvertAll(child.ChildNodes[2].InnerText.Split(','), double.Parse);
                        current.Colour = new HSV(tempColour[0], tempColour[1], tempColour[2]);
                        current.Variation = new double[3] { tempVar[0], tempVar[1], tempVar[2] };
                        current.Direction = new double[3] { tempDirection[0], tempDirection[1], tempDirection[2] };
                        current.Density = Convert.ToDouble(child.ChildNodes[3].InnerText);
                        double score = Compare(pCounter, cCounter, avResult, current)[2];
                        thisProp = new double[3] { pCounter, cCounter, score };
                        responses.Add(new KeyValuePair<string, double>(name, score));
                    } catch  (Exception ex) { // If there is missing data
                        MessageBox.Show("Object '" + name + "' is missing attributes, so will be skipped.\nDetails:" + ex);
                    }
                    cCounter++;  // Increments child counter
                }
                if (knownParent != 0) {
                    break;
                }
                pCounter++;    // Increments parent counter
                cCounter = 0;  // Resets child counter
            }
            if (responses.Count != 0) {           // If the analysis detected at least 1 object
                responses = MergeSort(responses); // Sorts the responses
                List<KeyValuePair<string, double>> bestResults = new List<KeyValuePair<string, double>>(); // Creates dictionary for best results
                foreach (KeyValuePair<string, double> result in responses) {                               // Loops through responses
                    if (responses[0].Value - result.Value < Math.Sqrt(responses[0].Value) / 2)             // If response is within good range
                        bestResults.Add(result);                                                           // Adds result to best results
                }
                if (bestResults.Count != 0) {                                                              // If there is at least 1 good result
                    responses = bestResults;                                                               // Removes bad results
                    avResult.objName = responses[0].Key;                                                   // Makes result name equal best result name
                    avResult.objParent = (xmlFile.DocumentElement.GetElementsByTagName(                    // Finds the parent of that object by
                                       responses[0].Key)[0]).ParentNode.Name;                              // Searching for its name in XML file
                    int max = avResult.Colour.sat * avResult.Colour.val >= 0.2 ? 20 : 16;                  // Max score changes depending on colour
                    avResult.Confidence = (int)((responses[0].Value / max) * 100);                         // Calculates confidence
                } else {                                                        // If there are no good answers
                    NoAnswers(avResult);                                        // Handle as if no answers
                }
            } else {                                                            // If there are no answers at all
                NoAnswers(avResult);                                            // Handles no answers
            }
            if (responses[0].Value < 8) {                                       // If the score of the best answer is less than 8...
                NoAnswers(avResult);                                            // It doesn't qualify as good, so handle as if no answers
            } else {                                                            // If there are some good answers
                foreach (KeyValuePair<string, double> item in responses) {      // Loop through the answers
                    if (item.Value == responses[0].Value) {                     // Check if there are answers with scores that draw
                        avResult.List.Add(item.Key);                            // Add to a list of answers
                    }
                }
            }

        }

        // Switches button state
        public void SwitchButtons(bool state) {
            foreach (Button btn in btns) {        // Loops buttons
                btn.Enabled = state;              // Changes the button state
            }
        }

        // Shows learning dialog box
        public void ShowLearner(Result result, bool isNew) {
            DialogResult dr = new DialogResult();                           // Creates a dialog object
            Learner addBox = new Learner();                                 // Instantiates learning window
            addBox.ObjName = responses[selectedNode].Key.ToString();        // Sets the default name text to that of the result
            addBox.ObjType = result.objParent;                               // Sets the default object type to that of the result
            dr = addBox.ShowDialog();                                       // Displays he dialog
            if (dr == DialogResult.OK) {                                    // Once dialog box closed
                string name = addBox.ObjName;                               // Sets name to submitted name    
                int index = Convert.ToInt32(addBox.ObjType);                // Gets parent type
                addBox.Close();                                             // Closes learner
                Record(result, isNew, name, index);                         // Records submission
            }
        }

        // Records data
        public void Record(Result result, bool isNew, string name, int index) {
            if (isNew) {                                                          // Checks if data is a new entry
                XmlNode rep = xmlFile.CreateElement(name);                        // Duplicates current node
                XmlNode parent = xmlFile.DocumentElement.ChildNodes[index];       // Finds parent node
                Add(rep, parent);                                                 // Adds the new node
                for (int row = 0; row < dataAttribs.RowCount - 1; row++) {        // Loops through rows
                    parent.LastChild.ChildNodes[row].InnerText =                  // Sets node data
                    dataAttribs.Rows[row].Cells[1].Value.ToString();
                }
            } else {    // If node already exists (not new)
                try {
                    // ------------------------------------------------------------------------------
                    // The following code acts as an interface between the result data, and the nodes
                    // ------------------------------------------------------------------------------
                    XmlNode update = ((XmlElement)(xmlFile.DocumentElement.ChildNodes[index])).GetElementsByTagName(name)[0];
                    double[] tempColour = Array.ConvertAll(update.ChildNodes[0].InnerText.Split(','), double.Parse);
                    double[] tempVar = Array.ConvertAll(update.ChildNodes[1].InnerText.Split(','), double.Parse);
                    double[] tempDirection = Array.ConvertAll(update.ChildNodes[2].InnerText.Split(','), double.Parse);
                    double tempDensity = Convert.ToDouble(update.ChildNodes[3].InnerText);
                    update.ChildNodes[0].InnerText = Math.Round(((tempColour[0] + result.Colour.hue) / 2), 0) + "," +
                                                     Math.Round(((tempColour[1] + result.Colour.sat) / 2), 3) + "," +
                                                     Math.Round(((tempColour[2] + result.Colour.val) / 2), 3);
                    update.ChildNodes[2].InnerText = Math.Round(((tempDirection[0] + result.Direction[0]) / 2), 1) + "," +
                                                     Math.Round(((tempDirection[1] + result.Direction[1]) / 2), 1) + "," +
                                                     Math.Round(((tempDirection[2] + result.Direction[2]) / 2), 1);
                    update.ChildNodes[3].InnerText = Math.Round(((tempDensity + result.Density) / 2), 2).ToString();
                } catch {      // Upon error
                    if (MessageBox.Show("Could not find object to learn. Attempt to create a new record?",
                        "Error", MessageBoxButtons.YesNo,                       // Only possible error is missing object name
                        MessageBoxIcon.Exclamation) == DialogResult.Yes) {      // Offers to create new record
                        Record(result, true, name, index);                      // If accepted, creates new record
                    }
                    return;                                                     // Exits early
                }
            }
            xmlFile.Save("templates.xml");                                      // Saves the changes
            Refresh();                                                          // Refreshes data from file
            MessageBox.Show("Finished learning!", "Information",                // Informs user of successful learn
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        // If there are no answers
        public void NoAnswers(Result avResult) {
            responses.Clear();                                              // Clears previous responses
            responses.Add(new KeyValuePair<string, double>("Unknown", 1));  // Adds 1 response called 'Unknown'
            avResult.List.Clear();                                          // Resets the best result
            avResult.objName = "Unknown";                                   // Calls best result 'Unknown'
            avResult.objParent = "Vehicle";                                 // Sets default object type
        }

    }

    #endregion

}
