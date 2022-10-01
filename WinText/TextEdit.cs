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
            // Determine if there is any text in the Clipboard to paste into the text box.
            /*           
                        {
                            // Determine if any text is selected in the text box.
                            if (richTextBox1.SelectionLength > 0)
                            {
                                // Ask user if they want to paste over currently selected text.
                                if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                                    // Move selection to the point after the current selection and paste.
                                    richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                            }
                            // Paste current text in Clipboard into text box.
                            richTextBox1.Paste();
                        }*/
        }




        // ------------------------TEST------------------------------ 

        private void AddFontSize()
        {
            // throw new Not Implemented Exception();    
            topSize.Items.Add("8");
            topSize.Items.Add("10");
            topSize.Items.Add("12");
            topSize.Items.Add("14");
            topSize.Items.Add("16");
            topSize.Items.Add("18");
        }


        private void topSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontChange();
        }

        private void FontChange()
        {
            // throw new Not Implemented Exception();    
            float fontsize = 10;
            string fontname = richTextBox1.SelectionFont.Name;
            if (topSize.Text != "") fontsize = float.Parse(topSize.Text);
            if (fontsize == 0) fontsize = 10;
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(fontname, fontsize);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AddFontSize();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void helpAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }


    }
}
