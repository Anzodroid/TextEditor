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
    public partial class CreateUser : Form
    {
        private string userName, password1, password2, fName, lName, date;
        private string userType;
        public CreateUser()
        {
            InitializeComponent();
            comboBoxType.SelectedItem = "View";
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(userName + password1 + password2 + fName + lName + date + userType);
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            dateTimeDateOfBirth.CustomFormat = "dd-MM-yyyy"; //change date to required format
            userName = textBoxUserName.Text;
            password1 = textBoxPassword1.Text;
            password2 = textBoxPassword2.Text;
            fName = textBoxFirstName.Text; // set first name
            lName = textBoxLastName.Text; // set last name
            date = dateTimeDateOfBirth.Text; // set date
            userType = comboBoxType.SelectedItem.ToString(); // set combobox user type value


            bool pwCheck = PasswordCheck(password1, password2);
            if (pwCheck)
            {
                MessageBox.Show(userName + password1 + password2 + fName + lName + date + userType);

                LoginScreen login = new LoginScreen(); 

                using (StreamWriter sw = File.AppendText(login.LoginPath))
                {
                    sw.WriteLine(userName+","+ password1 + "," + userType + "," +fName + "," + lName + "," + date);
                    sw.Close();
                }

                ReturnLoginScreen();

            }
            else
            {
                MessageBox.Show("Passwords do not Match");
            }
            


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ReturnLoginScreen();

        }


        private void ReturnLoginScreen()
        {
            var form = new LoginScreen();
            //  form.Location = this.Location;
            //  form.StartPosition = FormStartPosition.Manual;
            //  form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }       

        private bool PasswordCheck(string password1, string password2)
        {
            if (password1 == password2)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }


    }
}
