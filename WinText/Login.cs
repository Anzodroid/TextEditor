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
        private string userAccess, userName, userPassword, fName, lName, birthDay, stringList, loginPath;
        private static string CurrentPath;
        private int userIndex;
        private List<string> fileList = new List<string>(); //  Generic Collection: inital List from login file
        private List<string> splitList = new List<string>(); // Generic Collection: used to split filelist
        private List<string> userList = new List<string>(); // Generic Collection: list of users
        private List<string> pwdList = new List<string>(); // Generic Collection: list of passwords
        private List<string> accessList = new List<string>(); // Generic Collection: list of access
        private List<string> fNameList = new List<string>(); // Generic Collection: list of first names
        private List<string> lNameList = new List<string>(); // Generic Collection: list of last names
        private List<string> birthList = new List<string>(); // Generic Collection: list of date of birth (although not used)

        public string LoginPath
        {
            get { return loginPath; }
            set { loginPath = value; }
        }

        public LoginScreen()
        {
            InitializeComponent();
            CurrentPath = Directory.GetCurrentDirectory(); // Get current path
            LoginPath = CurrentPath + "\\login.txt"; // location of login file
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPassword.Text;
            CheckUser(username, password);
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            var form = new CreateUser();
            form.Show();
            this.Hide();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void CheckUser(string user, string password)  // method to check user exists
        {
            try
            {
                // using (TextReader myreader = File.OpenText(LoginPath))  1
                //TextReader myreader = File.OpenText(LoginPath); 2

                // {
                foreach (string line in File.ReadLines(LoginPath))
                {
                    fileList.Add(line);
                }

                for (int i = 0; i < fileList.Count; i++)
                {
                    stringList = fileList[i].ToString(); // convert to string
                    splitList = stringList.Split(',').ToList(); // split users and passwords to new list
                    userList.Add(splitList[0]); // add first element to user list
                    pwdList.Add(splitList[1]); // add second element to password list
                    accessList.Add(splitList[2]); // add third element to access list
                    fNameList.Add(splitList[3]); // add fourth element to first name list
                    lNameList.Add(splitList[4]); // add fith element to last name list
                    birthList.Add(splitList[5]); // add sixth element to date of birth list
                }

                if (userList.Contains(user)) // if login file contains user 
                {
                    userIndex = userList.IndexOf(user);
                    //MessageBox.Show("USER FOUND : index" + userIndex + " : " + userList[userIndex] + " : " + pwdList[userIndex] + " : " + accessList[userIndex] + " : " + fNameList[userIndex] + " : " + lNameList[userIndex] + " : " + birthList[userIndex]);
                    userPassword = pwdList[userIndex];

                    if (userPassword == password)
                    {


                        userName = userList[userIndex];
                        userAccess = accessList[userIndex];
                        fName = fNameList[userIndex];
                        lName = lNameList[userIndex];
                        birthDay = birthList[userIndex];

                        //MessageBox.Show("USER access:" + userAccess);

                        TextEditForm();// switch to text edit form 
                    }
                    else // if login file password does not match provided password 
                    {
                        errorMessage2.Text = "Incorrect password";
                        MessageBox.Show("Incorrect password", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    errorMessage1.Text = "Unknown user";
                    MessageBox.Show("User not found", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                // }
            }
            catch (FileNotFoundException)
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
            var form = new TextEdit(userAccess, userName, fName, lName);
            form.Show();
            this.Hide();
        }


    }
}
