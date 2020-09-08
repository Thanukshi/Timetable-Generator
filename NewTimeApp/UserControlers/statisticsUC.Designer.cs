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
            this.studentsBtn = new NewTimeApp.CircularButton();
            this.lecturersBtn = new NewTimeApp.CircularButton();
            this.subjectsBtn = new NewTimeApp.CircularButton();
            this.statpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statpanel
            // 
            this.statpanel.BackColor = System.Drawing.Color.White;
            this.statpanel.Controls.Add(this.subjectsBtn);
            this.statpanel.Controls.Add(this.lecturersBtn);
            this.statpanel.Controls.Add(this.studentsBtn);
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
            // studentsBtn
            // 
            this.studentsBtn.BackColor = System.Drawing.Color.Plum;
            this.studentsBtn.FlatAppearance.BorderSize = 0;
            this.studentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBtn.ForeColor = System.Drawing.Color.White;
            this.studentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("studentsBtn.Image")));
            this.studentsBtn.Location = new System.Drawing.Point(122, 133);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(150, 150);
            this.studentsBtn.TabIndex = 36;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studentsBtn.UseVisualStyleBackColor = false;
            // 
            // lecturersBtn
            // 
            this.lecturersBtn.BackColor = System.Drawing.Color.Plum;
            this.lecturersBtn.FlatAppearance.BorderSize = 0;
            this.lecturersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.lecturersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecturersBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturersBtn.ForeColor = System.Drawing.Color.White;
            this.lecturersBtn.Image = ((System.Drawing.Image)(resources.GetObject("lecturersBtn.Image")));
            this.lecturersBtn.Location = new System.Drawing.Point(491, 133);
            this.lecturersBtn.Name = "lecturersBtn";
            this.lecturersBtn.Size = new System.Drawing.Size(150, 150);
            this.lecturersBtn.TabIndex = 39;
            this.lecturersBtn.Text = "Lecturers";
            this.lecturersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lecturersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lecturersBtn.UseVisualStyleBackColor = false;
            // 
            // subjectsBtn
            // 
            this.subjectsBtn.BackColor = System.Drawing.Color.Plum;
            this.subjectsBtn.FlatAppearance.BorderSize = 0;
            this.subjectsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.subjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectsBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsBtn.ForeColor = System.Drawing.Color.White;
            this.subjectsBtn.Image = ((System.Drawing.Image)(resources.GetObject("subjectsBtn.Image")));
            this.subjectsBtn.Location = new System.Drawing.Point(321, 419);
            this.subjectsBtn.Name = "subjectsBtn";
            this.subjectsBtn.Size = new System.Drawing.Size(150, 150);
            this.subjectsBtn.TabIndex = 40;
            this.subjectsBtn.Text = "Subjects";
            this.subjectsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subjectsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.subjectsBtn.UseVisualStyleBackColor = false;
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
        private CircularButton studentsBtn;
        private CircularButton lecturersBtn;
        private CircularButton subjectsBtn;
    }
}
