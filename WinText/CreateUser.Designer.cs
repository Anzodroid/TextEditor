namespace WinText
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dateTimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelReEnterPW = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelUserType = new System.Windows.Forms.Label();
            this.pictureBoxUTS = new System.Windows.Forms.PictureBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUTS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(119, 297);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(182, 36);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(478, 297);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 36);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.AcceptsReturn = true;
            this.textBoxUserName.Location = new System.Drawing.Point(119, 56);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(112, 20);
            this.textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.AcceptsReturn = true;
            this.textBoxPassword1.Location = new System.Drawing.Point(119, 92);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(112, 20);
            this.textBoxPassword1.TabIndex = 3;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.AcceptsReturn = true;
            this.textBoxPassword2.Location = new System.Drawing.Point(119, 127);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(112, 20);
            this.textBoxPassword2.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AcceptsReturn = true;
            this.textBoxLastName.Location = new System.Drawing.Point(119, 195);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(112, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AcceptsReturn = true;
            this.textBoxFirstName.Location = new System.Drawing.Point(119, 161);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(112, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // dateTimeDateOfBirth
            // 
            this.dateTimeDateOfBirth.AllowDrop = true;
            this.dateTimeDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDateOfBirth.Location = new System.Drawing.Point(119, 228);
            this.dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            this.dateTimeDateOfBirth.Size = new System.Drawing.Size(112, 20);
            this.dateTimeDateOfBirth.TabIndex = 7;
            this.dateTimeDateOfBirth.Value = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(57, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(183, 33);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Create User";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUser.Location = new System.Drawing.Point(58, 56);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 13);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPassword.Location = new System.Drawing.Point(60, 95);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password";
            // 
            // labelReEnterPW
            // 
            this.labelReEnterPW.AutoSize = true;
            this.labelReEnterPW.BackColor = System.Drawing.Color.Transparent;
            this.labelReEnterPW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReEnterPW.Location = new System.Drawing.Point(16, 130);
            this.labelReEnterPW.Name = "labelReEnterPW";
            this.labelReEnterPW.Size = new System.Drawing.Size(97, 13);
            this.labelReEnterPW.TabIndex = 12;
            this.labelReEnterPW.Text = "Re-enter Password";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLastName.Location = new System.Drawing.Point(60, 198);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFirstName.Location = new System.Drawing.Point(59, 164);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 14;
            this.labelFirstName.Text = "First Name";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBirthDay.Location = new System.Drawing.Point(47, 234);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(66, 13);
            this.labelBirthDay.TabIndex = 15;
            this.labelBirthDay.Text = "Date of Birth";
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.BackColor = System.Drawing.Color.Transparent;
            this.labelUserType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserType.Location = new System.Drawing.Point(57, 261);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(56, 13);
            this.labelUserType.TabIndex = 16;
            this.labelUserType.Text = "User-Type";
            // 
            // pictureBoxUTS
            // 
            this.pictureBoxUTS.Image = global::WinText.Properties.Resources.UTS;
            this.pictureBoxUTS.InitialImage = null;
            this.pictureBoxUTS.Location = new System.Drawing.Point(523, 12);
            this.pictureBoxUTS.Name = "pictureBoxUTS";
            this.pictureBoxUTS.Size = new System.Drawing.Size(61, 56);
            this.pictureBoxUTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUTS.TabIndex = 17;
            this.pictureBoxUTS.TabStop = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Edit",
            "View"});
            this.comboBoxType.Location = new System.Drawing.Point(120, 261);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 18;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinText.Properties.Resources.Security;
            this.ClientSize = new System.Drawing.Size(596, 348);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.pictureBoxUTS);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelReEnterPW);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dateTimeDateOfBirth);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "CreateUser";
            this.Text = "Create User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfBirth;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelReEnterPW;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.PictureBox pictureBoxUTS;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}