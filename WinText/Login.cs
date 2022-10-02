using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinText.bin
{
    public partial class LoginScreen : Form
    {

        public string userAccess, fName, lName, birthDay;
        public static string CurrentPath;

        string loginFilePath;

      //  string consoleUser, consolePassword;
       // string password = "";
       // bool userValidation = false;
       // bool passwordValidation = false;
        int userIndex;

        ArrayList fileList = new ArrayList(); // inital ArrayList from login file
        List<string> splitList = new List<string>(); // users and passwords
        List<string> userList = new List<string>(); // list of users
        List<string> pwdList = new List<string>(); // list of passwords
        List<string> accessList = new List<string>(); // list of access

        private void errorMessage_Click(object sender, EventArgs e)
        {

        }

        List<string> fNameList = new List<string>(); // list of first names
        List<string> lNameList = new List<string>(); // list of last names
        List<string> birthList = new List<string>(); // list of birthdays



        public LoginScreen()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            CurrentPath = Directory.GetCurrentDirectory(); // Get current path


            string username = textBoxUser.Text;
            string password = textBoxPassword.Text;

            //MessageBox.Show(username + ":" + password);
            CheckUser(username);
           
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {

            var form = new TextEdit(userAccess , fName , lName);
            //  form.Location = this.Location;
            //  form.StartPosition = FormStartPosition.Manual;
            //  form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        public void CheckUser(string user)  // method to check user exists
        {
            string path = CurrentPath + "\\login.txt"; // location of login file

            //MessageBox.Show("PATH LOGIN" + loginFilePath + "PATH CURRENT" + CurrentPath + " PATH" +path);

            try
            {
                using (TextReader myreader = File.OpenText(path))
                {
                    foreach (string line in File.ReadLines(path))
                    {
                        fileList.Add(line);
                    }

                    for (int i = 0; i < fileList.Count; i++)
                    {
                        string stringList = fileList[i].ToString(); // convert to string
                        splitList = stringList.Split(',').ToList(); // split users and passwords to new list
                        userList.Add(splitList[0]); // add first element to user list
                        pwdList.Add(splitList[1]); // add second element to password list
                        accessList.Add(splitList[2]); // add second element to password list
                        fNameList.Add(splitList[3]); // add second element to password list
                        lNameList.Add(splitList[4]); // add second element to password list
                        birthList.Add(splitList[5]); // add second element to password list

                    }

                    if (userList.Contains(user))
                    {
                        userIndex = userList.IndexOf(user);
                       // userValidation = true;
                        MessageBox.Show("USER FOUND : index" + userIndex + " : " + userList[userIndex] + " : " + pwdList[userIndex] + " : " + accessList[userIndex] + " : " + fNameList[userIndex] + " : " + lNameList[userIndex] + " : " + birthList[userIndex]);
                        
                        userAccess = accessList[userIndex];
                        fName = fNameList[userIndex];
                        lName = lNameList[userIndex];
                        birthDay = birthList[userIndex];

                        MessageBox.Show("USER access:" + userAccess);

                        TextEditForm();// switch to text edit form 

                    }
                    else
                    {
                       // userValidation = false;
                        errorMessage.Text = "Login Failure";
                        MessageBox.Show("Login Failed","Login",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Login file not found, please contact your system admin");
            }
            catch
            {
                MessageBox.Show("Critical error, please contact your system admin");

            }

        }


        public void TextEditForm()
        {
            var form = new TextEdit(userAccess, fName, lName);
            //  form.Location = this.Location;
            //  form.StartPosition = FormStartPosition.Manual;
            //  form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();

        }


    }
}
