using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinText.bin
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var form = new TextEdit();
          //  form.Location = this.Location;
          //  form.StartPosition = FormStartPosition.Manual;
          //  form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
    }
}
