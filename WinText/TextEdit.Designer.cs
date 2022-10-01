namespace WinText
{
    partial class TextEdit
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCut = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.topNew = new System.Windows.Forms.ToolStripButton();
            this.topOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.topSave = new System.Windows.Forms.ToolStripButton();
            this.topSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.topBold = new System.Windows.Forms.ToolStripButton();
            this.topItalics = new System.Windows.Forms.ToolStripButton();
            this.topUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.topColour = new System.Windows.Forms.ToolStripButton();
            this.topTextColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.leftCut = new System.Windows.Forms.ToolStripButton();
            this.leftCopy = new System.Windows.Forms.ToolStripButton();
            this.leftPaste = new System.Windows.Forms.ToolStripButton();
            this.topComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileOpen,
            this.toolStripSeparator1,
            this.fileSave,
            this.fileSaveAs,
            this.toolStripSeparator2,
            this.fileLogout});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // fileNew
            // 
            this.fileNew.Image = global::WinText.Properties.Resources._new;
            this.fileNew.Name = "fileNew";
            this.fileNew.Size = new System.Drawing.Size(180, 22);
            this.fileNew.Text = "New";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Image = global::WinText.Properties.Resources.open;
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(180, 22);
            this.fileOpen.Text = "Open";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // fileSave
            // 
            this.fileSave.Image = global::WinText.Properties.Resources.if_save_173091;
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(180, 22);
            this.fileSave.Text = "Save";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Image = global::WinText.Properties.Resources.SaveAs;
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.fileSaveAs.Text = "Save As";
            this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // fileLogout
            // 
            this.fileLogout.Image = global::WinText.Properties.Resources.gnome_logout;
            this.fileLogout.Name = "fileLogout";
            this.fileLogout.Size = new System.Drawing.Size(180, 22);
            this.fileLogout.Text = "Logout";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCut,
            this.editCopy,
            this.editPaste});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // editCut
            // 
            this.editCut.Image = global::WinText.Properties.Resources.if_clipboard_cut_42190;
            this.editCut.Name = "editCut";
            this.editCut.Size = new System.Drawing.Size(180, 22);
            this.editCut.Text = "Cut";
            this.editCut.Click += new System.EventHandler(this.editCut_Click);
            // 
            // editCopy
            // 
            this.editCopy.Image = global::WinText.Properties.Resources.Copyblue;
            this.editCopy.Name = "editCopy";
            this.editCopy.Size = new System.Drawing.Size(180, 22);
            this.editCopy.Text = "Copy";
            this.editCopy.Click += new System.EventHandler(this.editCopy_Click);
            // 
            // editPaste
            // 
            this.editPaste.Image = global::WinText.Properties.Resources.pasteBlue2;
            this.editPaste.Name = "editPaste";
            this.editPaste.Size = new System.Drawing.Size(180, 22);
            this.editPaste.Text = "Paste";
            this.editPaste.Click += new System.EventHandler(this.editPaste_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbout});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // helpAbout
            // 
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(180, 22);
            this.helpAbout.Text = "About...";
            this.helpAbout.Click += new System.EventHandler(this.helpAbout_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 449);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topNew,
            this.topOpen,
            this.toolStripSeparator5,
            this.topSave,
            this.topSaveAs,
            this.toolStripSeparator3,
            this.topBold,
            this.topItalics,
            this.topUnderline,
            this.toolStripSeparator4,
            this.topColour,
            this.topTextColor,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(458, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // topNew
            // 
            this.topNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topNew.Image = global::WinText.Properties.Resources._new;
            this.topNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topNew.Name = "topNew";
            this.topNew.Size = new System.Drawing.Size(23, 22);
            this.topNew.Text = "toolStripButton1";
            this.topNew.Click += new System.EventHandler(this.topNew_Click);
            // 
            // topOpen
            // 
            this.topOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topOpen.Image = global::WinText.Properties.Resources.open;
            this.topOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topOpen.Name = "topOpen";
            this.topOpen.Size = new System.Drawing.Size(23, 22);
            this.topOpen.Text = "toolStripButton2";
            this.topOpen.Click += new System.EventHandler(this.topOpen_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // topSave
            // 
            this.topSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topSave.Image = global::WinText.Properties.Resources.if_save_173091;
            this.topSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topSave.Name = "topSave";
            this.topSave.Size = new System.Drawing.Size(23, 22);
            this.topSave.Text = "toolStripButton3";
            this.topSave.Click += new System.EventHandler(this.topSave_Click);
            // 
            // topSaveAs
            // 
            this.topSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topSaveAs.Image = global::WinText.Properties.Resources.SaveAs;
            this.topSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topSaveAs.Name = "topSaveAs";
            this.topSaveAs.Size = new System.Drawing.Size(23, 22);
            this.topSaveAs.Text = "toolStripButton4";
            this.topSaveAs.Click += new System.EventHandler(this.topSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // topBold
            // 
            this.topBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topBold.Image = global::WinText.Properties.Resources.font_bold;
            this.topBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topBold.Name = "topBold";
            this.topBold.Size = new System.Drawing.Size(23, 22);
            this.topBold.Text = "toolStripButton5";
            this.topBold.Click += new System.EventHandler(this.topBold_Click);
            // 
            // topItalics
            // 
            this.topItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topItalics.Image = global::WinText.Properties.Resources.font_italic;
            this.topItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topItalics.Name = "topItalics";
            this.topItalics.Size = new System.Drawing.Size(23, 22);
            this.topItalics.Text = "toolStripButton6";
            this.topItalics.Click += new System.EventHandler(this.topItalics_Click);
            // 
            // topUnderline
            // 
            this.topUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topUnderline.Image = global::WinText.Properties.Resources._105_underline;
            this.topUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topUnderline.Name = "topUnderline";
            this.topUnderline.Size = new System.Drawing.Size(23, 22);
            this.topUnderline.Text = "toolStripButton7";
            this.topUnderline.Click += new System.EventHandler(this.topUnderline_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // topColour
            // 
            this.topColour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topColour.Image = global::WinText.Properties.Resources.Bucket;
            this.topColour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topColour.Name = "topColour";
            this.topColour.Size = new System.Drawing.Size(23, 22);
            this.topColour.Text = "toolStripButton1";
            this.topColour.Click += new System.EventHandler(this.topColour_Click);
            // 
            // topTextColor
            // 
            this.topTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topTextColor.Image = global::WinText.Properties.Resources.textcolour;
            this.topTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topTextColor.Name = "topTextColor";
            this.topTextColor.Size = new System.Drawing.Size(23, 22);
            this.topTextColor.Text = "toolStripButton1";
            this.topTextColor.Click += new System.EventHandler(this.topTextColor_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftCut,
            this.leftCopy,
            this.leftPaste});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(38, 500);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // leftCut
            // 
            this.leftCut.AutoSize = false;
            this.leftCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftCut.Image = global::WinText.Properties.Resources.if_clipboard_cut_42190;
            this.leftCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftCut.Name = "leftCut";
            this.leftCut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.leftCut.Size = new System.Drawing.Size(23, 22);
            this.leftCut.Text = "toolStripButton8";
            this.leftCut.Click += new System.EventHandler(this.leftCut_Click);
            // 
            // leftCopy
            // 
            this.leftCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftCopy.Image = global::WinText.Properties.Resources.Copyblue;
            this.leftCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftCopy.Name = "leftCopy";
            this.leftCopy.Size = new System.Drawing.Size(36, 20);
            this.leftCopy.Text = "toolStripButton9";
            this.leftCopy.Click += new System.EventHandler(this.leftCopy_Click);
            // 
            // leftPaste
            // 
            this.leftPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftPaste.Image = global::WinText.Properties.Resources.pasteBlue2;
            this.leftPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftPaste.Name = "leftPaste";
            this.leftPaste.Size = new System.Drawing.Size(36, 20);
            this.leftPaste.Text = "toolStripButton8";
            this.leftPaste.Click += new System.EventHandler(this.leftPaste_Click);
            // 
            // topComboBox
            // 
            this.topComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.topComboBox.FormattingEnabled = true;
            this.topComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.topComboBox.Location = new System.Drawing.Point(246, 27);
            this.topComboBox.Name = "topComboBox";
            this.topComboBox.Size = new System.Drawing.Size(39, 21);
            this.topComboBox.TabIndex = 4;
            this.topComboBox.SelectedIndexChanged += new System.EventHandler(this.topComboBox_SelectedIndexChanged);
            // 
            // TextEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 549);
            this.Controls.Add(this.topComboBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEdit";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAbout;
        private System.Windows.Forms.ToolStripMenuItem editCut;
        private System.Windows.Forms.ToolStripMenuItem editCopy;
        private System.Windows.Forms.ToolStripMenuItem editPaste;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileLogout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton topNew;
        private System.Windows.Forms.ToolStripButton topOpen;
        private System.Windows.Forms.ToolStripButton topSave;
        private System.Windows.Forms.ToolStripButton topSaveAs;
        private System.Windows.Forms.ToolStripButton topBold;
        private System.Windows.Forms.ToolStripButton topItalics;
        private System.Windows.Forms.ToolStripButton topUnderline;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton leftCut;
        private System.Windows.Forms.ToolStripButton leftCopy;
        private System.Windows.Forms.ToolStripButton leftPaste;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton topColour;
        private System.Windows.Forms.ToolStripButton topTextColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ComboBox topComboBox;
    }
}

