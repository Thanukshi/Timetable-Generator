namespace TimeApp
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JUserName = new JTextBox.JText_Box();
            this.loginBtn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.bunifuColorTransition1 = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
            this.JPassword = new JTextBox.JText_Box();
            this.cancleBtn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorMessage_login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1066, 698);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(621, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Here";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // JUserName
            // 
            this.JUserName.BackColor = System.Drawing.Color.White;
            this.JUserName.BorderColor = System.Drawing.Color.Gray;
            this.JUserName.BorderThickness = 3;
            this.JUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JUserName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JUserName.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JUserName.Location = new System.Drawing.Point(616, 190);
            this.JUserName.Margin = new System.Windows.Forms.Padding(5);
            this.JUserName.MaxLength = 32767;
            this.JUserName.Name = "JUserName";
            this.JUserName.onFocusBorderColor = System.Drawing.Color.Gray;
            this.JUserName.PasswordChar = '\0';
            this.JUserName.RoundedBorder = 15;
            this.JUserName.Size = new System.Drawing.Size(400, 65);
            this.JUserName.TabIndex = 4;
            this.JUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JUserName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JUserName.TextInput = "";
            this.JUserName.Load += new System.EventHandler(this.jText_Box3_Load);
            // 
            // loginBtn_login
            // 
            this.loginBtn_login.ActiveBorderThickness = 1;
            this.loginBtn_login.ActiveCornerRadius = 20;
            this.loginBtn_login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginBtn_login.ActiveForecolor = System.Drawing.Color.Black;
            this.loginBtn_login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginBtn_login.BackColor = System.Drawing.SystemColors.Control;
            this.loginBtn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn_login.BackgroundImage")));
            this.loginBtn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn_login.ButtonText = "Login";
            this.loginBtn_login.CausesValidation = false;
            this.loginBtn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn_login.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginBtn_login.IdleBorderThickness = 3;
            this.loginBtn_login.IdleCornerRadius = 20;
            this.loginBtn_login.IdleFillColor = System.Drawing.Color.White;
            this.loginBtn_login.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginBtn_login.IdleLineColor = System.Drawing.Color.Gray;
            this.loginBtn_login.Location = new System.Drawing.Point(616, 463);
            this.loginBtn_login.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.loginBtn_login.Name = "loginBtn_login";
            this.loginBtn_login.Size = new System.Drawing.Size(206, 77);
            this.loginBtn_login.TabIndex = 5;
            this.loginBtn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn_login.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(707, 200);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(298, 47);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.Text = "User Name";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Gray;
            this.textPassword.Location = new System.Drawing.Point(707, 331);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(298, 47);
            this.textPassword.TabIndex = 7;
            this.textPassword.Text = "Password";
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.AutoTransition = false;
            this.bunifuColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Purple,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.Orange};
            this.bunifuColorTransition1.EndColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.Interval = 10;
            this.bunifuColorTransition1.ProgessValue = 0;
            this.bunifuColorTransition1.StartColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.TransitionControl = null;
            // 
            // JPassword
            // 
            this.JPassword.AccessibleName = "";
            this.JPassword.BackColor = System.Drawing.Color.White;
            this.JPassword.BorderColor = System.Drawing.Color.Gray;
            this.JPassword.BorderThickness = 3;
            this.JPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JPassword.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPassword.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPassword.ForeColor = System.Drawing.Color.DimGray;
            this.JPassword.Location = new System.Drawing.Point(616, 322);
            this.JPassword.Margin = new System.Windows.Forms.Padding(5);
            this.JPassword.MaxLength = 32767;
            this.JPassword.Name = "JPassword";
            this.JPassword.onFocusBorderColor = System.Drawing.Color.Gray;
            this.JPassword.PasswordChar = '\0';
            this.JPassword.RoundedBorder = 15;
            this.JPassword.Size = new System.Drawing.Size(400, 65);
            this.JPassword.TabIndex = 2;
            this.JPassword.Tag = "";
            this.JPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JPassword.TextColor = System.Drawing.Color.DimGray;
            this.JPassword.TextInput = "";
            // 
            // cancleBtn_login
            // 
            this.cancleBtn_login.ActiveBorderThickness = 1;
            this.cancleBtn_login.ActiveCornerRadius = 20;
            this.cancleBtn_login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cancleBtn_login.ActiveForecolor = System.Drawing.Color.Black;
            this.cancleBtn_login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cancleBtn_login.BackColor = System.Drawing.SystemColors.Control;
            this.cancleBtn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancleBtn_login.BackgroundImage")));
            this.cancleBtn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancleBtn_login.ButtonText = "cancle";
            this.cancleBtn_login.CausesValidation = false;
            this.cancleBtn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancleBtn_login.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleBtn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cancleBtn_login.IdleBorderThickness = 3;
            this.cancleBtn_login.IdleCornerRadius = 20;
            this.cancleBtn_login.IdleFillColor = System.Drawing.Color.White;
            this.cancleBtn_login.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cancleBtn_login.IdleLineColor = System.Drawing.Color.Gray;
            this.cancleBtn_login.Location = new System.Drawing.Point(842, 463);
            this.cancleBtn_login.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cancleBtn_login.Name = "cancleBtn_login";
            this.cancleBtn_login.Size = new System.Drawing.Size(206, 77);
            this.cancleBtn_login.TabIndex = 9;
            this.cancleBtn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(629, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(629, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // errorMessage_login
            // 
            this.errorMessage_login.AutoSize = true;
            this.errorMessage_login.BackColor = System.Drawing.Color.White;
            this.errorMessage_login.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage_login.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage_login.Location = new System.Drawing.Point(608, 581);
            this.errorMessage_login.Name = "errorMessage_login";
            this.errorMessage_login.Size = new System.Drawing.Size(0, 31);
            this.errorMessage_login.TabIndex = 12;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 696);
            this.Controls.Add(this.errorMessage_login);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cancleBtn_login);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.loginBtn_login);
            this.Controls.Add(this.JUserName);
            this.Controls.Add(this.JPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private JTextBox.JText_Box JUserName;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBtn_login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Bunifu.UI.WinForms.BunifuColorTransition bunifuColorTransition1;
        private JTextBox.JText_Box JPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 cancleBtn_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label errorMessage_login;
    }
}