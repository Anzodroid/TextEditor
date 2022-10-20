using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinText.bin;

namespace WinText
{

    public partial class Functions : TextEdit
    {
        public Functions(Enum userAccess) : base(userAccess)
        {
        }

        public void OpenFile(RichTextBox textBox)
        {
            OpenFileDialog openFile = new OpenFileDialog(); // Open file dialog box 
            openFile.Title = "Open text file";
            openFile.Filter = "Text Files (*.rtf; *.txt) | *.rtf; *.txt"; // open either a .rtf or .txt file

            DialogResult dr = openFile.ShowDialog(); // Shows open file dialog box in DialogResult
            if (dr == DialogResult.OK) // if user selects OK
            {
               
                if (openFile.FileName == loginPath) // if login file is selected then block file from opening
                {
                    MessageBox.Show("Sorry, for security reasons, the login file is unable to be edited in this application", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //MessageBox.Show(openFile.FileName);
                    CurrentFile = openFile.FileName;

                    try
                    {
                        textBox.LoadFile(CurrentFile, RichTextBoxStreamType.RichText);
                    }
                    catch
                    {
                        System.IO.StreamReader stream = new System.IO.StreamReader(CurrentFile);
                        textBox.Text = stream.ReadToEnd();
                        stream.Close();
                    }
                }
            }

        }


        public void SaveFile(RichTextBox textBox, bool saveAs)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save a file";
            saveFile.Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt"; //save as either .rtf or .txt file

            if (!saveAs)
            {
                try
                {
                    textBox.SaveFile(CurrentFile, RichTextBoxStreamType.RichText); // save over the current file
                }
                catch
                {
                    Save(saveFile, textBox); // if no current save file, then SaveAs
                }
            }
            else
            {
                Save(saveFile, textBox);
            }
        }

        private void Save(SaveFileDialog saveFile,RichTextBox textBox)
        {
            DialogResult dr = saveFile.ShowDialog();

            if (dr == DialogResult.OK && saveFile.FileName.Length > 0) // Check file name length is greater than 0
            {
                textBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
                CurrentFile = saveFile.FileName;
            }
        }

        public void PasteText(RichTextBox textBox)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength;
            }
            textBox.Paste();  // Paste Clipboard text into richTextBox
        }

        public void FontStyleChange(RichTextBox textBox, string style, Enum userAccess)
        {
            Font oldSelection;
            oldSelection = textBox.SelectionFont;

            if (userAccess.Equals(UserAccess.Edit))
            {

                switch (style)
                {
                    case "Bold":


                        if (oldSelection.Bold)
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style & ~FontStyle.Bold);
                        }
                        else
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style | FontStyle.Bold);
                        }

                        break;


                    case "Italic":


                        if (oldSelection.Italic)
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style & ~FontStyle.Italic);
                        }
                        else
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style | FontStyle.Italic);
                        }

                        break;


                    case "Underline":


                        if (oldSelection.Underline)
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style & ~FontStyle.Underline);
                        }
                        else
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style | FontStyle.Underline);
                        }

                        break;

                }

                textBox.Focus();
            }
            else
            {
                MessageBox.Show("Insufficent access for this user type", "Insufficient Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

    }
}
