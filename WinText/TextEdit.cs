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

namespace WinText
{
    public partial class TextEdit : Form
    {
        public double fontSize;
        public string font;
        private static string currentFile;

        public static string CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }

        }






        public TextEdit()
        {
            InitializeComponent();
        }


        // ------------------------Top Tool Strip------------------------------ 

        private void topNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void topOpen_Click(object sender, EventArgs e)
        {
            Functions function = new Functions();
            function.OpenFile(richTextBox1);

        }

        private void topSave_Click(object sender, EventArgs e)
        {

            Functions function = new Functions();
            function.SaveFile(richTextBox1,false);
        }

        private void topSaveAs_Click(object sender, EventArgs e)
        {
            Functions function = new Functions();
            //function.SaveFileAs(richTextBox1);
            function.SaveFile(richTextBox1,true);

        }

        private void topBold_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
        }
        private void topItalics_Click(object sender, EventArgs e)
        {
           // richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Italic);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
        }

        private void topUnderline_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
        }

        // ------------------------Colour ------------------------------ 
        private void topColour_Click(object sender, EventArgs e)
        {

            ColorDialog colour = new ColorDialog();

            DialogResult result = colour.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colour.Color;

            }

        }

        private void topTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colour = new ColorDialog();

            DialogResult result = colour.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colour.Color;

            }
        }


        private void topComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = topComboBox.SelectedItem.ToString();
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,
            Convert.ToInt32(font), richTextBox1.SelectionFont.Style);
        }

        // ------------------------File Tab------------------------------ 
        private void fileNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            Functions function = new Functions();
            function.OpenFile(richTextBox1);
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("CurrentFile1 :" + currentFile);
            Functions function = new Functions();
            function.SaveFile(richTextBox1, false);
        }

        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            Functions function = new Functions();
            function.SaveFile(richTextBox1, true);
        }


        // ------------------------Side Tool Strip------------------------------ 

        private void leftCut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)      
                richTextBox1.Cut(); // Cut the selected text
        }

        private void leftCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy(); // Copy the selected text
        }

        private void leftPaste_Click(object sender, EventArgs e)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.textboxbase.cut?view=windowsdesktop-6.0

            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                Functions function = new Functions();
                function.PasteText(richTextBox1);
            }

        }

        // ------------------------Edit Tab------------------------------ 

        private void editCut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Cut(); // Cut the selected text
        }

        private void editCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy(); // Copy the selected text
        }

        private void editPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                Functions function = new Functions();
                function.PasteText(richTextBox1);
            }
        }

        // ------------------------Help Tab------------------------------ 

        private void helpAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        // ------------------------TODO------------------------------ 

        // Logout

        // Lock editing for Read Only user

    }
}
