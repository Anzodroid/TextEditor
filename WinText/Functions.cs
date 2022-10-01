using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinText
{

    public partial class Functions : TextEdit
    {
        //public string currentFile = "myfile.txt";
        public string save = "hi.txt";

        SaveFileDialog saveD;
        //public string currentFile;

        public void OpenFile(RichTextBox textBox)
        {

            OpenFileDialog openFile = new OpenFileDialog(); // Open file dialog box 
            openFile.Title = "Open text file";
            openFile.Filter = "Text Files (*.txt) | *.txt";

            //SaveFileDialog saveFile = new SaveFileDialog();

            DialogResult dr = openFile.ShowDialog(); // Shows open file dialog box in DialogResult
            if (dr == DialogResult.OK) // if user selects OK
            {
                CurrentFile = openFile.FileName;
                //save = currentFile;
                System.IO.StreamReader stream = new System.IO.StreamReader(openFile.FileName);
                textBox.Text = stream.ReadToEnd();
                stream.Close();
                MessageBox.Show("CurrentFile :" + CurrentFile + "save"+ save);

            }

        }


        public void SaveFile(RichTextBox textBox, bool saveAs)
        {
            MessageBox.Show("CurrentFile2 :" + CurrentFile + ":" + save);
            // Save file dialog box 
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save a file";
            saveFile.Filter = "Text Files (*.txt) | *.txt";
            

            if (!saveAs)
            {
                try
                {
                    MessageBox.Show("CurrentFile :" + CurrentFile);
                    //richTextBox1.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText);
                    textBox.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText);
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

                textBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
/*                string saveName = saveFile.FileName;
                MessageBox.Show("Saved in : " + saveName);*/
                CurrentFile = saveFile.FileName;
                MessageBox.Show("CurrentFile :" + CurrentFile);
            }


        }



    }
}
