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
        Enum userAccess; 
        private string font, currentUser, fName, lName;
        private static string currentFile;
        public string loginPath;

        public static string CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }
        }

        public TextEdit(Enum userAccess)
        {
            InitializeComponent();

            LoginScreen login = new LoginScreen();
            loginPath = login.LoginPath;
            labelUser.Text = login.CurrentUser;
            labelAccess.Text = userAccess.ToString();
            labelFirstName.Text = login.FName;
            labelLastName.Text = login.LName;

            this.currentUser = login.CurrentUser; // setting username
            this.userAccess = userAccess;// setting user access level
            this.fName = login.FName; // setting user first name
            this.lName = login.LName; // setting user last name

           
            if  (userAccess.Equals(UserAccess.Edit))
            {
                richTextBox1.ReadOnly = false;
                topComboBox1.SelectedItem = "12";
            }
            else
            {
                richTextBox1.ReadOnly = true;
                richTextBox1.BackColor = Color.LightGray;
                topComboBox1.Enabled = false;
            }
        }

        // ------------------------Top Tool Strip------------------------------ 

        private void topNew_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Any unsaved changes will be lost", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {
                richTextBox1.Clear(); // clear the richtext box 
                currentFile = null; //clear the current file from memory
            }
        }

        private void topOpen_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess);
            function.OpenFile(richTextBox1);
        }

        private void topSave_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess);

            if (userAccess.Equals(UserAccess.Edit))
            {
                function.SaveFile(richTextBox1,false);
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void topSaveAs_Click(object sender, EventArgs e)
        {
                if (userAccess.Equals(UserAccess.Edit))
                {
                    Functions function = new Functions(userAccess);
                    function.SaveFile(richTextBox1,true);
                }
                else
                {
                    MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        private void topBold_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess);
            function.FontStyleChange(richTextBox1,"Bold",userAccess);
        }
        private void topItalics_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess);
            function.FontStyleChange(richTextBox1, "Italic", userAccess);
        }

        private void topUnderline_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess);
            function.FontStyleChange(richTextBox1, "Underline", userAccess);
        }

        // ------------------------Colour ------------------------------ 
        private void topColour_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            { 
                ColorDialog colour = new ColorDialog();

                DialogResult result = colour.ShowDialog();

             
                if (result == DialogResult.OK)
                {
                    richTextBox1.SelectionBackColor = colour.Color;
                }
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void topTextColor_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                ColorDialog colour = new ColorDialog();

                DialogResult result = colour.ShowDialog();

                if (result == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colour.Color;
                }
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // ------------------------Combo Box------------------------------ 

        private void topComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
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
            DialogResult result = MessageBox.Show("Any unsaved changes will be lost", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {
                richTextBox1.Clear(); // clear the richtext box 
                currentFile = null; //clear the current file from memory
            }
        }
        private void fileOpen_Click(object sender, EventArgs e)
        {
            Functions function = new Functions(userAccess);
            function.OpenFile(richTextBox1);
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                Functions function = new Functions(userAccess);
                function.SaveFile(richTextBox1, false);
            }else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                Functions function = new Functions(userAccess);
                function.SaveFile(richTextBox1, true);
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void fileLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var form = new LoginScreen();
                form.LoginFileSaveChanges(); // save changes to login file
                form.Show();
                this.Hide();
            }
        }

        // ------------------------Side Tool Strip------------------------------ 

        private void leftCut_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.Cut(); // Cut the selected text
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void leftCopy_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy(); // Copy the selected text
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void leftPaste_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                {
                    Functions function = new Functions(userAccess);
                    function.PasteText(richTextBox1);
                }
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        // ------------------------Edit Tab------------------------------ 

        private void editCut_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.Cut(); // Cut the selected text
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void editCopy_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.Copy(); // Copy the selected text
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void editPaste_Click(object sender, EventArgs e)
        {
            if (userAccess.Equals(UserAccess.Edit))
            {
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                {
                    Functions function = new Functions(userAccess);
                    function.PasteText(richTextBox1);
                }
                else
                {
                    MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
