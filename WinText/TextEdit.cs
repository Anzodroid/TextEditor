using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinText.bin;

namespace WinText
{
    public partial class TextEdit : Form
    {
        private string font, userAccess, userName, fName, lName;
        private static string currentFile;
        public string loginPath;

        public static string CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }
        }

        public TextEdit(string userAccess, string userName, string fName, string lName)
        {

            LoginScreen login = new LoginScreen();
            loginPath = login.LoginPath;

            InitializeComponent();

            topComboBox1.SelectedItem = "12";
            labelUser.Text = userName;
            labelAccess.Text = userAccess;
            labelFirstName.Text = fName;
            labelLastName.Text = lName;

            this.userName = userName; // setting username
            this.userAccess = userAccess; // setting user access level
            this.fName = fName; // setting user first name
            this.fName = lName; // setting user last name
        }

        // ------------------------Top Tool Strip------------------------------ 

        private void topNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void topOpen_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess, userName, fName, lName);
            function.OpenFile(richTextBox1);
        }

        private void topSave_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess, userName, fName, lName);
            function.SaveFile(richTextBox1,false);
        }

        private void topSaveAs_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess, userName, fName, lName);
            function.SaveFile(richTextBox1,true);
        }

        private void topBold_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }
        private void topItalics_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void topUnderline_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }

        // ------------------------Colour ------------------------------ 
        private void topColour_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit") 
            { 
                ColorDialog colour = new ColorDialog();

                DialogResult result = colour.ShowDialog();

                if (result == DialogResult.OK)
                {
                    richTextBox1.SelectionBackColor = colour.Color;
                }
            }
        }

        private void topTextColor_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                ColorDialog colour = new ColorDialog();

                DialogResult result = colour.ShowDialog();

                if (result == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colour.Color;
                }
            }
        }

        // ------------------------Combo Box------------------------------ 

        private void topComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                try
                {
                    font = topComboBox1.SelectedItem.ToString();
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,
                    Convert.ToInt32(font), richTextBox1.SelectionFont.Style);
                }
                catch
                {
                    topComboBox1.SelectedItem = "12";
                }
            }
        }

        // ------------------------About ------------------------------ 

        private void topHelp_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }


        // ------------------------File Tab------------------------------ 
        private void fileNew_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                richTextBox1.Clear();
            }
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess, userName, fName, lName);
            function.OpenFile(richTextBox1);
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                Functions function = new Functions(userAccess, userName, fName, lName);
                function.SaveFile(richTextBox1, false);
            }
        }

        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                Functions function = new Functions(userAccess, userName, fName, lName);
                function.SaveFile(richTextBox1, true);
            }
        }

        // ------------------------Side Tool Strip------------------------------ 

        private void leftCut_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.Cut(); // Cut the selected text
            }
        }

        private void leftCopy_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy(); // Copy the selected text
            }
        }

        private void leftPaste_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                {
                    Functions function = new Functions(userAccess, userName, fName, lName);
                    function.PasteText(richTextBox1);
                }
            }
        }

        private void fileLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            if (result==DialogResult.Yes)
            {
                var form = new LoginScreen();
                form.Show();
                this.Hide();
            }
        }


        // ------------------------Edit Tab------------------------------ 

        private void editCut_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.Cut(); // Cut the selected text
            }
        }


        private void editCopy_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.Copy(); // Copy the selected text
            }
        }

        private void editPaste_Click(object sender, EventArgs e)
        {
            if (userAccess == "Edit")
            {
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                {
                    Functions function = new Functions(userAccess, userName, fName, lName);
                    function.PasteText(richTextBox1);
                }
            }
        }

        // ------------------------Help Tab------------------------------ 

        private void helpAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }


    }
}
