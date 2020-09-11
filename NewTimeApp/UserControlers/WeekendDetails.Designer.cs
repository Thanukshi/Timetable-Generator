namespace NewTimeApp.UserControlers
{
    partial class WeekendDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekendDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.jFlatButton2 = new FlatButton.JFlatButton();
            this.jFlatButton1 = new FlatButton.JFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.jFlatButton2);
            this.panel1.Controls.Add(this.jFlatButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 642);
            this.panel1.TabIndex = 0;
            // 
            // jFlatButton2
            // 
            this.jFlatButton2.BackColor = System.Drawing.Color.Plum;
            this.jFlatButton2.BackgroundColor = System.Drawing.Color.Plum;
            this.jFlatButton2.ButtonText = "View Details";
            this.jFlatButton2.CausesValidation = false;
            this.jFlatButton2.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton2.ErrorImageLeft")));
            this.jFlatButton2.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jFlatButton2.ErrorImageRight")));
            this.jFlatButton2.FocusBackground = System.Drawing.Color.Empty;
            this.jFlatButton2.FocusFontColor = System.Drawing.Color.Empty;
            this.jFlatButton2.ForeColors = System.Drawing.Color.White;
            this.jFlatButton2.HoverBackground = System.Drawing.Color.Purple;
            this.jFlatButton2.HoverFontColor = System.Drawing.Color.White;
            this.jFlatButton2.ImageLeft = global::NewTimeApp.Properties.Resources.list_view_64;
            this.jFlatButton2.ImageRight = null;
            this.jFlatButton2.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton2.Location = new System.Drawing.Point(218, 405);
            this.jFlatButton2.Name = "jFlatButton2";
            this.jFlatButton2.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton2.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton2.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton2.Size = new System.Drawing.Size(277, 77);
            this.jFlatButton2.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jFlatButton2.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jFlatButton2.TabIndex = 44;
            this.jFlatButton2.Click += new System.EventHandler(this.jFlatButton2_Click_1);
            // 
            // jFlatButton1
            // 
            this.jFlatButton1.BackColor = System.Drawing.Color.Plum;
            this.jFlatButton1.BackgroundColor = System.Drawing.Color.Plum;
            this.jFlatButton1.ButtonText = "Add New";
            this.jFlatButton1.CausesValidation = false;
            this.jFlatButton1.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton1.ErrorImageLeft")));
            this.jFlatButton1.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jFlatButton1.ErrorImageRight")));
            this.jFlatButton1.FocusBackground = System.Drawing.Color.Empty;
            this.jFlatButton1.FocusFontColor = System.Drawing.Color.Empty;
            this.jFlatButton1.ForeColors = System.Drawing.Color.White;
            this.jFlatButton1.HoverBackground = System.Drawing.Color.Purple;
            this.jFlatButton1.HoverFontColor = System.Drawing.Color.White;
            this.jFlatButton1.ImageLeft = global::NewTimeApp.Properties.Resources.add_list_64;
            this.jFlatButton1.ImageRight = null;
            this.jFlatButton1.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton1.Location = new System.Drawing.Point(218, 216);
            this.jFlatButton1.Name = "jFlatButton1";
            this.jFlatButton1.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton1.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton1.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton1.Size = new System.Drawing.Size(277, 77);
            this.jFlatButton1.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jFlatButton1.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jFlatButton1.TabIndex = 43;
            this.jFlatButton1.Click += new System.EventHandler(this.jFlatButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NewTimeApp.Properties.Resources.back1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(25, 31);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 45;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // WeekendDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WeekendDetails";
            this.Size = new System.Drawing.Size(750, 642);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlatButton.JFlatButton jFlatButton2;
        private FlatButton.JFlatButton jFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBtn;
    }
}
