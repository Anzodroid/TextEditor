using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public void OpenFile(RichTextBox textBox) // Open File
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
            

            if (!saveAs) // Save current file
            {
                try
                {
                    if (CurrentFile == null)
                    {
                        Save(saveFile, textBox);
                    }
                    else
                    {
                        var extension = Path.GetExtension(saveFile.FileName);

                        switch (extension.ToLower())
                        {
                            case ".rtf":
                                textBox.SaveFile(CurrentFile, RichTextBoxStreamType.RichText); // save over the current file (RichText)
                                break;

                            case ".txt":
                                textBox.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText); // save over the current file (PlainText)
                                break;

                            default:
                                textBox.SaveFile(CurrentFile, RichTextBoxStreamType.RichText); // default save extension (RichText)
                                break;
                        }
                    }
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

        private void Save(SaveFileDialog saveFile,RichTextBox textBox) // Save File
        {
            DialogResult dr = saveFile.ShowDialog();

            if (dr == DialogResult.OK && saveFile.FileName.Length > 0) // Check file name length is greater than 0
            {
                try
                {
                    var extension = Path.GetExtension(saveFile.FileName);

                    switch (extension.ToLower())
                    {
                        case ".rtf":
                            CurrentFile = saveFile.FileName;
                            textBox.SaveFile(CurrentFile, RichTextBoxStreamType.RichText); // save over the current file (RichText)
                            break;

                        case ".txt":
                            CurrentFile = saveFile.FileName;
                            textBox.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText); // save over the current file (PlainText)
                            break;

                        default:
                            textBox.SaveFile(CurrentFile, RichTextBoxStreamType.RichText); // default save extension (RichText)
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Error, " + ex);
                }
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


                        if (oldSelection.Bold) // if selected text is Bold
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style & ~FontStyle.Bold); // remove font style
                        }
                        else // add font style
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style | FontStyle.Bold); 
                        }

                        break;


                    case "Italic":


                        if (oldSelection.Italic)  // if selected text is Italic
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style & ~FontStyle.Italic); // remove font style
                        }
                        else // add font style
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style | FontStyle.Italic); 
                        }

                        break;


                    case "Underline":


                        if (oldSelection.Underline)  // if selected text is Underlined
                        {
                            textBox.SelectionFont = new Font(textBox.SelectionFont, textBox.SelectionFont.Style & ~FontStyle.Underline); // remove font style
                        }
                        else // add font style
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
