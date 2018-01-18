// Class: Learn
using System.Windows.Forms;

namespace ImageIdentifier
{
    public partial class Learner : Form
    {
        // Initialises Learner Box
        public Learner() {
            InitializeComponent();
            btnLearn.DialogResult = DialogResult.OK;  // Learn button now submits
            comboType.SelectedIndex = 0;              // Sets initial index to zero
        }
        
        // Object Name
        public string ObjName {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        // Object Type
        public string ObjType {
             get { return comboType.SelectedIndex.ToString(); }
             set { comboType.SelectedItem = value; }
            }

        // Checks if empty
        private void txtName_TextChanged(object sender, System.EventArgs e) {
            btnLearn.Enabled = txtName.Text == string.Empty ? false : true;   // Rejects empty strings
        }
    }
}
