namespace NewTimeApp.UserControlers
{
    partial class statisticsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statisticsUC));
            this.statpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentBtn = new NewTimeApp.CircularButton();
            this.lecBtn = new NewTimeApp.CircularButton();
            this.subBtn = new NewTimeApp.CircularButton();
            this.statpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statpanel
            // 
            this.statpanel.BackColor = System.Drawing.Color.White;
            this.statpanel.Controls.Add(this.subBtn);
            this.statpanel.Controls.Add(this.lecBtn);
            this.statpanel.Controls.Add(this.studentBtn);
            this.statpanel.Controls.Add(this.pictureBox1);
            this.statpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statpanel.Location = new System.Drawing.Point(0, 0);
            this.statpanel.Name = "statpanel";
            this.statpanel.Size = new System.Drawing.Size(772, 720);
            this.statpanel.TabIndex = 0;
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
            // studentBtn
            // 
            this.studentBtn.BackColor = System.Drawing.Color.Plum;
            this.studentBtn.FlatAppearance.BorderSize = 0;
            this.studentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.studentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBtn.ForeColor = System.Drawing.Color.White;
            this.studentBtn.Image = ((System.Drawing.Image)(resources.GetObject("studentBtn.Image")));
            this.studentBtn.Location = new System.Drawing.Point(118, 186);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(150, 150);
            this.studentBtn.TabIndex = 36;
            this.studentBtn.Text = "Student";
            this.studentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studentBtn.UseVisualStyleBackColor = false;
            // 
            // lecBtn
            // 
            this.lecBtn.BackColor = System.Drawing.Color.Plum;
            this.lecBtn.FlatAppearance.BorderSize = 0;
            this.lecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.lecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecBtn.ForeColor = System.Drawing.Color.White;
            this.lecBtn.Image = ((System.Drawing.Image)(resources.GetObject("lecBtn.Image")));
            this.lecBtn.Location = new System.Drawing.Point(488, 186);
            this.lecBtn.Name = "lecBtn";
            this.lecBtn.Size = new System.Drawing.Size(150, 150);
            this.lecBtn.TabIndex = 39;
            this.lecBtn.Text = "Lecturers";
            this.lecBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lecBtn.UseVisualStyleBackColor = false;
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.Plum;
            this.subBtn.FlatAppearance.BorderSize = 0;
            this.subBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.White;
            this.subBtn.Image = ((System.Drawing.Image)(resources.GetObject("subBtn.Image")));
            this.subBtn.Location = new System.Drawing.Point(319, 491);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(150, 150);
            this.subBtn.TabIndex = 40;
            this.subBtn.Text = "Subjects";
            this.subBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.subBtn.UseVisualStyleBackColor = false;
            // 
            // statisticsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statpanel);
            this.Name = "statisticsUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.statpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton studentBtn;
        private CircularButton lecBtn;
        private CircularButton subBtn;
    }
}
