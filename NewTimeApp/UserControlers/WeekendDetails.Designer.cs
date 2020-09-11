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
            this.backBtn = new System.Windows.Forms.Button();
            this.ViewWeekEnd = new FlatButton.JFlatButton();
            this.AddWeekEnd = new FlatButton.JFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.ViewWeekEnd);
            this.panel1.Controls.Add(this.AddWeekEnd);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 642);
            this.panel1.TabIndex = 0;
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
            // ViewWeekEnd
            // 
            this.ViewWeekEnd.BackColor = System.Drawing.Color.Plum;
            this.ViewWeekEnd.BackgroundColor = System.Drawing.Color.Plum;
            this.ViewWeekEnd.ButtonText = "View Details";
            this.ViewWeekEnd.CausesValidation = false;
            this.ViewWeekEnd.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("ViewWeekEnd.ErrorImageLeft")));
            this.ViewWeekEnd.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("ViewWeekEnd.ErrorImageRight")));
            this.ViewWeekEnd.FocusBackground = System.Drawing.Color.Empty;
            this.ViewWeekEnd.FocusFontColor = System.Drawing.Color.Empty;
            this.ViewWeekEnd.ForeColors = System.Drawing.Color.White;
            this.ViewWeekEnd.HoverBackground = System.Drawing.Color.Purple;
            this.ViewWeekEnd.HoverFontColor = System.Drawing.Color.White;
            this.ViewWeekEnd.ImageLeft = global::NewTimeApp.Properties.Resources.list_view_64;
            this.ViewWeekEnd.ImageRight = null;
            this.ViewWeekEnd.LeftPictureColor = System.Drawing.Color.Transparent;
            this.ViewWeekEnd.Location = new System.Drawing.Point(218, 405);
            this.ViewWeekEnd.Name = "ViewWeekEnd";
            this.ViewWeekEnd.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.ViewWeekEnd.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.ViewWeekEnd.RightPictureColor = System.Drawing.Color.Transparent;
            this.ViewWeekEnd.Size = new System.Drawing.Size(277, 77);
            this.ViewWeekEnd.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewWeekEnd.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ViewWeekEnd.TabIndex = 44;
            this.ViewWeekEnd.Click += new System.EventHandler(this.jFlatButton2_Click_1);
            // 
            // AddWeekEnd
            // 
            this.AddWeekEnd.BackColor = System.Drawing.Color.Plum;
            this.AddWeekEnd.BackgroundColor = System.Drawing.Color.Plum;
            this.AddWeekEnd.ButtonText = "Add New";
            this.AddWeekEnd.CausesValidation = false;
            this.AddWeekEnd.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("AddWeekEnd.ErrorImageLeft")));
            this.AddWeekEnd.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("AddWeekEnd.ErrorImageRight")));
            this.AddWeekEnd.FocusBackground = System.Drawing.Color.Empty;
            this.AddWeekEnd.FocusFontColor = System.Drawing.Color.Empty;
            this.AddWeekEnd.ForeColors = System.Drawing.Color.White;
            this.AddWeekEnd.HoverBackground = System.Drawing.Color.Purple;
            this.AddWeekEnd.HoverFontColor = System.Drawing.Color.White;
            this.AddWeekEnd.ImageLeft = global::NewTimeApp.Properties.Resources.add_list_64;
            this.AddWeekEnd.ImageRight = null;
            this.AddWeekEnd.LeftPictureColor = System.Drawing.Color.Transparent;
            this.AddWeekEnd.Location = new System.Drawing.Point(218, 216);
            this.AddWeekEnd.Name = "AddWeekEnd";
            this.AddWeekEnd.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.AddWeekEnd.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.AddWeekEnd.RightPictureColor = System.Drawing.Color.Transparent;
            this.AddWeekEnd.Size = new System.Drawing.Size(277, 77);
            this.AddWeekEnd.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddWeekEnd.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AddWeekEnd.TabIndex = 43;
            this.AddWeekEnd.Click += new System.EventHandler(this.jFlatButton1_Click_1);
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
        private FlatButton.JFlatButton ViewWeekEnd;
        private FlatButton.JFlatButton AddWeekEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBtn;
    }
}
