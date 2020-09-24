namespace NewTimeApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jUn = new JTextBox.JTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.unT = new System.Windows.Forms.TextBox();
            this.jPw = new JTextBox.JTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pwT = new System.Windows.Forms.TextBox();
            this.visiblePW = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.checkRemember = new System.Windows.Forms.CheckBox();
            this.cancleBtn = new ePOSOne.btnProduct.Button_WOC();
            this.loginBtn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(565, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Here";
            // 
            // jUn
            // 
            this.jUn.AutoSize = true;
            this.jUn.BorderColor = System.Drawing.Color.Black;
            this.jUn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jUn.Hint = "";
            this.jUn.IsPassword = false;
            this.jUn.Length = 0;
            this.jUn.Location = new System.Drawing.Point(566, 239);
            this.jUn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jUn.Name = "jUn";
            this.jUn.OnFocus = System.Drawing.Color.Black;
            this.jUn.OnlyChar = false;
            this.jUn.OnlyNumber = false;
            this.jUn.Size = new System.Drawing.Size(412, 70);
            this.jUn.TabIndex = 4;
            this.jUn.TextValue = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(581, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // unT
            // 
            this.unT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unT.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unT.ForeColor = System.Drawing.Color.Silver;
            this.unT.Location = new System.Drawing.Point(665, 252);
            this.unT.Multiline = true;
            this.unT.Name = "unT";
            this.unT.Size = new System.Drawing.Size(300, 44);
            this.unT.TabIndex = 10;
            this.unT.Text = "Username";
            this.unT.Enter += new System.EventHandler(this.UN_Text_Enter);
            this.unT.Leave += new System.EventHandler(this.un_Text_Leave);
            // 
            // jPw
            // 
            this.jPw.AutoSize = true;
            this.jPw.BorderColor = System.Drawing.Color.Black;
            this.jPw.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jPw.Hint = "";
            this.jPw.IsPassword = false;
            this.jPw.Length = 0;
            this.jPw.Location = new System.Drawing.Point(566, 357);
            this.jPw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jPw.Name = "jPw";
            this.jPw.OnFocus = System.Drawing.Color.Black;
            this.jPw.OnlyChar = false;
            this.jPw.OnlyNumber = false;
            this.jPw.Size = new System.Drawing.Size(412, 70);
            this.jPw.TabIndex = 12;
            this.jPw.TextValue = "";
            this.jPw.Load += new System.EventHandler(this.jTextBox1_Load);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(581, 367);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pwT
            // 
            this.pwT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwT.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwT.ForeColor = System.Drawing.Color.Silver;
            this.pwT.Location = new System.Drawing.Point(665, 371);
            this.pwT.Multiline = true;
            this.pwT.Name = "pwT";
            this.pwT.PasswordChar = '*';
            this.pwT.Size = new System.Drawing.Size(240, 44);
            this.pwT.TabIndex = 14;
            this.pwT.Text = "Password";
            this.pwT.TextChanged += new System.EventHandler(this.pw_Text_TextChanged);
            this.pwT.Enter += new System.EventHandler(this.pw_Text_Enter);
            this.pwT.Leave += new System.EventHandler(this.pw_Text_Leave);
            // 
            // visiblePW
            // 
            this.visiblePW.BackColor = System.Drawing.Color.White;
            this.visiblePW.FlatAppearance.BorderSize = 0;
            this.visiblePW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.visiblePW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.visiblePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visiblePW.Image = ((System.Drawing.Image)(resources.GetObject("visiblePW.Image")));
            this.visiblePW.Location = new System.Drawing.Point(920, 369);
            this.visiblePW.Name = "visiblePW";
            this.visiblePW.Size = new System.Drawing.Size(45, 45);
            this.visiblePW.TabIndex = 17;
            this.visiblePW.UseVisualStyleBackColor = false;
            this.visiblePW.Click += new System.EventHandler(this.visiblePW_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(481, 715);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "2020 Institute Of ABC, All Rights Reserved .";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(459, 715);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.BackColor = System.Drawing.Color.White;
            this.checkRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkRemember.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRemember.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkRemember.Location = new System.Drawing.Point(581, 434);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(219, 24);
            this.checkRemember.TabIndex = 24;
            this.checkRemember.Text = "Remember Your Login";
            this.checkRemember.UseVisualStyleBackColor = false;
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.Color.White;
            this.cancleBtn.BorderColor = System.Drawing.Color.Black;
            this.cancleBtn.ButtonColor = System.Drawing.Color.White;
            this.cancleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancleBtn.FlatAppearance.BorderSize = 0;
            this.cancleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancleBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleBtn.ForeColor = System.Drawing.Color.Black;
            this.cancleBtn.Location = new System.Drawing.Point(787, 478);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.cancleBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cancleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.cancleBtn.Size = new System.Drawing.Size(166, 67);
            this.cancleBtn.TabIndex = 21;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.BorderColor = System.Drawing.Color.Black;
            this.loginBtn.ButtonColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(581, 478);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.loginBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.loginBtn.Size = new System.Drawing.Size(166, 67);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkRemember);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.visiblePW);
            this.Controls.Add(this.pwT);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.jPw);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.unT);
            this.Controls.Add(this.jUn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private JTextBox.JTextBox jUn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox unT;
        private JTextBox.JTextBox jPw;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox pwT;
        private System.Windows.Forms.Button visiblePW;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ePOSOne.btnProduct.Button_WOC loginBtn;
        private ePOSOne.btnProduct.Button_WOC cancleBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkRemember;
    }
}