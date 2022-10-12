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
        private string userName, password1, password2, fName, lName, date, userType;

        public CreateUser()
        {
            InitializeComponent();
            comboBoxType.SelectedItem = "View"; // set default combobox item
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            dateTimeDateOfBirth.CustomFormat = "dd-MM-yyyy"; //change date to required format
            userName = textBoxUserName.Text; // username 
            password1 = textBoxPassword1.Text; // password 1 
            password2 = textBoxPassword2.Text; // password 2
            fName = textBoxFirstName.Text; // set first name
            lName = textBoxLastName.Text; // set last name
            date = dateTimeDateOfBirth.Text; // set date
            userType = comboBoxType.SelectedItem.ToString(); // set combobox user type value


            bool dateCheck = DateCheck(date);
            bool pwCheck = PasswordCheck(password1, password2);
            bool userCheck = UniqueCheck(userName);

            if (pwCheck && dateCheck && userCheck)
            {
                LoginScreen login = new LoginScreen();

                StreamWriter sw = File.AppendText(login.LoginPath);
                {
                    //append variables to login file 
                    sw.WriteLine(userName+","+ password1 + "," + userType + "," +fName + "," + lName + "," + date);
                    sw.Close();
                }

                MessageBox.Show("User "+userName+" successfully created. \n Returning to login screen ", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReturnLoginScreen();
            }
            else if(!pwCheck)
            {
                MessageBox.Show("Passwords do not Match", "Logic Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!dateCheck)
            {
                MessageBox.Show("Birthday must be in the past", "Logic Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!userCheck)
            {
                MessageBox.Show("User already exists \nPlease choose a different username ", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("User creation error, pleasce check the information you have provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ReturnLoginScreen();
        }

        private void ReturnLoginScreen()
        {
            var form = new LoginScreen();
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

        private bool DateCheck(string date)
        {
            try
            {
                DateTime dt = DateTime.Now;

                DateTime userDate = Convert.ToDateTime(date);

                if (dt > userDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                MessageBox.Show("system error");
                return false;
            }
        }

        public bool UniqueCheck(string user)
        {
            try
            {
                LoginScreen login = new LoginScreen();

                if (login.UserList.Contains(user))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Login file not found, please contact your system admin");
                return false;
            }
            catch
            {
                MessageBox.Show("Critical error, please contact your system admin");
                return false;
            }
        }



    }
}
