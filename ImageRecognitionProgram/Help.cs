// Class: Help
using System.Windows.Forms;

namespace ImageIdentifier {
    public partial class Helper : Form {
        
        // Populates Textboxes
        public Helper(int pageNum) {
            InitializeComponent();
            tabHelper.SelectedIndex = pageNum; // Sets page to requested number
            rtxtWelcome.Text = "Welcome to the Image Recognition Tool. This tool aims to have at least a " + 
                               "70% success rate on objects, assuming the following criteria:\n\n" + 
                               "- The image contains an actual object, and isn't scenery or a background.\n" + 
                               "- The image is mainly the object that is intended to be recognised.\n" + 
                               "- The object needs to be in the library of the program, it can't recognise new objects without learning!\n" + 
                               "- The image needs to fairly represent the object, it can't be a really weird situation, nor can it look " +
                               "unlike the object it actually is.\n\nProgram by Sam Stenner";
            rtxtTemplates.Text = "How to use the templates:\n\n" +
                                 "1. Click the 'Template' tab\n" +
                                 "2. Expand the XML tree by clicking an object type\n" +
                                 "3. Select the required template\n" +
                                 "4. Make any changes using the control panel at the bottom.\n" + 
                                 "   The attributes to each template are visible in the data grid.\n" +
                                 "5. Ensure to update any changes.";
            rtxtAnalyse.Text = "How to analyse an image:\n\n" +
                               "1. Import the image.\n" +
                               "2. Click Analyse.\n" +
                               "3. The program will attempt to analyse the image.\n" +
                               "4. The result will appear in a message box.\n" +
                               "5. More details can be found in the template explorer in advanced mode.\n" +
                               "   A detailed breakdown of the processing maps can also be found in advanced,\n" +
                               "   mode, as well as some graphs that break down the colour components of the image.";
            rtxtTips.Text = "1. The sigmoid graph should generally be quite steep\n" + 
                            "2. Don't worry about huge images, they are automatically compressed\n" +
                            "3. You can use the 'Image Hint' dropdown box to limit the searches to specific types of object.";
            rtxtImportant.Text = "- Ensure to regularly back-up your memory file, to avoid loss of data.\n" +
                                 "- Avoid incorrectly updating a node’s attributes, as this is irreversible if there is no backup file";
            rtxtSigmoid.Text = "The Sigmoid Functions determines how tolerant the program is. " +
                               "It's a slider that allows the user to choose whether the program will easily reject, or will easily accept.\n\n" +
                               "A lower coefficient makes the boundary smoother, and creates a gradient from which the final value will " +
                               "be chosen. A higher coefficient makes the boundary very distinct, with a very binary result.\n\n" +
                               "Low:\n - Fewer false negatives\n - More false positives.\n\n" + 
                               "High:\n - Fewer false positives\n - More false negatives ";
            rtxtHash.Text = "The hash for the current memory template is:\n\n" + Properties.Settings.Default.hash + 
                            "\n\nA hash is a unique string of characters used to identify files or text. Every hash is different, and can " +
                            "be used to identify different resources. In this case, a hash is used to check if two templates are the same. " +
                            "If they are, then the restoration need not occur, and is therefore aborted. The hash used in this instance is " +
                            "the MD5 algorithm.";

        }

        // Copies the hash
        private void btnCopyHash_Click(object sender, System.EventArgs e) {
            Clipboard.SetText(Properties.Settings.Default.hash);             // Sets clipboard text to the hash
            btnCopyHash.Enabled = false;
            btnCopyHash.Text = "Hash Copied";
        }

        // Updates hash button
        private void tabHelper_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (tabHelper.SelectedTab == tabHelper.TabPages["pgHash"]) {                           // If hash page selected:
                if (Clipboard.GetText(TextDataFormat.Text) != Properties.Settings.Default.hash) {  // If the clipboard doesn't contain hash
                    btnCopyHash.Text = "Copy Hash";
                    btnCopyHash.Enabled = true;                                                    // Makes copying available                                             
                } else {
                    btnCopyHash.Enabled = false;
                    btnCopyHash.Text = "Hash Copied";                                              // Prevents copying again
                }
            }
        }
    }
}
