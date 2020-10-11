namespace NewTimeApp.UserControlers
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.viewPaneld = new System.Windows.Forms.Panel();
            this.backBtnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.degreeBtn = new NewTimeApp.CircularButton();
            this.accBtn = new NewTimeApp.CircularButton();
            this.viewPaneld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPaneld
            // 
            this.viewPaneld.BackColor = System.Drawing.Color.White;
            this.viewPaneld.Controls.Add(this.degreeBtn);
            this.viewPaneld.Controls.Add(this.accBtn);
            this.viewPaneld.Controls.Add(this.backBtnS);
            this.viewPaneld.Controls.Add(this.label1);
            this.viewPaneld.Controls.Add(this.pictureBox1);
            this.viewPaneld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPaneld.Location = new System.Drawing.Point(0, 0);
            this.viewPaneld.Name = "viewPaneld";
            this.viewPaneld.Size = new System.Drawing.Size(772, 720);
            this.viewPaneld.TabIndex = 1;
            // 
            // backBtnS
            // 
            this.backBtnS.FlatAppearance.BorderSize = 0;
            this.backBtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnS.Image = ((System.Drawing.Image)(resources.GetObject("backBtnS.Image")));
            this.backBtnS.Location = new System.Drawing.Point(31, 19);
            this.backBtnS.Name = "backBtnS";
            this.backBtnS.Size = new System.Drawing.Size(66, 56);
            this.backBtnS.TabIndex = 46;
            this.backBtnS.UseVisualStyleBackColor = true;
            this.backBtnS.Click += new System.EventHandler(this.backBtnS_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(119, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 41);
            this.label1.TabIndex = 45;
            this.label1.Text = "View Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // degreeBtn
            // 
            this.degreeBtn.BackColor = System.Drawing.Color.Plum;
            this.degreeBtn.FlatAppearance.BorderSize = 0;
            this.degreeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.degreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.degreeBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeBtn.ForeColor = System.Drawing.Color.White;
            this.degreeBtn.Image = ((System.Drawing.Image)(resources.GetObject("degreeBtn.Image")));
            this.degreeBtn.Location = new System.Drawing.Point(489, 279);
            this.degreeBtn.Name = "degreeBtn";
            this.degreeBtn.Size = new System.Drawing.Size(200, 200);
            this.degreeBtn.TabIndex = 48;
            this.degreeBtn.Text = "Add Sessions";
            this.degreeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.degreeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.degreeBtn.UseVisualStyleBackColor = false;
            this.degreeBtn.Click += new System.EventHandler(this.degreeBtn_Click);
            // 
            // accBtn
            // 
            this.accBtn.BackColor = System.Drawing.Color.Plum;
            this.accBtn.FlatAppearance.BorderSize = 0;
            this.accBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.accBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBtn.ForeColor = System.Drawing.Color.White;
            this.accBtn.Image = ((System.Drawing.Image)(resources.GetObject("accBtn.Image")));
            this.accBtn.Location = new System.Drawing.Point(117, 279);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(200, 200);
            this.accBtn.TabIndex = 47;
            this.accBtn.Text = "Not Available";
            this.accBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accBtn.UseVisualStyleBackColor = false;
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // Details
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.viewPaneld);
            this.Name = "Details";
            this.Size = new System.Drawing.Size(772, 720);
            this.viewPaneld.ResumeLayout(false);
            this.viewPaneld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewPaneld;
        private CircularButton degreeBtn;
        private CircularButton accBtn;
        private System.Windows.Forms.Button backBtnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
