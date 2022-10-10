﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinText
{

    public partial class Functions : TextEdit
    {
        public Functions(string userAccess, string userName, string fName, string lName) : base(userAccess, userName, fName, lName)
        {
        }

        public void OpenFile(RichTextBox textBox)
        {
            OpenFileDialog openFile = new OpenFileDialog(); // Open file dialog box 
            openFile.Title = "Open text file";
            openFile.Filter = "Text Files (*.rtf; *.txt) | *.rtf; *.txt";

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
            saveFile.Filter = " Text Files(*.rtf) | *.rtf";

            if (!saveAs)
            {
                try
                {
                    //MessageBox.Show("CurrentFile :" + CurrentFile);
                    textBox.SaveFile(CurrentFile, RichTextBoxStreamType.RichText);
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




    }
}
