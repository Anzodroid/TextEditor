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
    public enum UserAccess { View, Edit };
    public partial class LoginScreen : Form
    {
        public Enum UserType;
        private string userPassword, birthDay, stringList, loginPath; 
        private static string currentPath, currentUser, fName, lName;
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

        public List<string> UserList
        {
            get { return userList; }
            set { userList = value; }
        }

        public string CurrentUser // the currently logged in user
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public string FName // the currently logged in user's first name
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName // the currently logged in user's last name
        {
            get { return lName; }
            set { lName = value; }
        }

        public LoginScreen()
        {
            InitializeComponent();
            currentPath = Directory.GetCurrentDirectory(); // Get current path
            LoginPath = currentPath + "\\login.txt"; // location of login file
            LoadLoginFile();
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
                if (userList.Contains(user)) // if login file contains user 
                {
                    userIndex = userList.IndexOf(user);
                    userPassword = pwdList[userIndex];

                    if (userPassword == password)
                    {
                        CurrentUser = userList[userIndex];
                        UserType = (UserAccess)Enum.Parse(typeof(UserAccess), accessList[userIndex]); // Parse string to Enum 
                        FName = fNameList[userIndex];
                        LName = lNameList[userIndex];
                        birthDay = birthList[userIndex];

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Critical error, please contact your system admin :" + ex);
            }
        }

        public void LoadLoginFile()  // method to check user exists
        {
            try
            {
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
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Login file not found, please contact your system admin");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Critical error, please contact your system admin" + ex);
            }
        }


        public void LoginFileSaveChanges()  // method to update login file as per requirement(1d-ii)
        {
            try
            {

                System.IO.File.WriteAllText(LoginPath, string.Empty); // clear the login file

                StreamWriter sw = File.AppendText(LoginPath); // Append each line back to the file
                {
                    for (int i = 0; i < userList.Count; i++)
                    {

                        sw.WriteLine(userList[i] + "," + pwdList[i] + "," + accessList[i] + "," + fNameList[i] + "," + lNameList[i] + "," + birthList[i]);
                        
                    }
                    MessageBox.Show("Changes saved to Login File");

                    sw.Close();
                }
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
            var form = new TextEdit(UserType);
            form.Show();
            this.Hide();
        }


    }
}
