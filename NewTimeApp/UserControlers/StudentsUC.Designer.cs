﻿namespace NewTimeApp.UserControlers
{
    partial class StudentsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsUC));
            this.studentPanel = new System.Windows.Forms.Panel();
            this.accBtn = new NewTimeApp.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentBtn = new NewTimeApp.CircularButton();
            this.degreeBtn = new NewTimeApp.CircularButton();
            this.mainGrpBtn = new NewTimeApp.CircularButton();
            this.subGroupBrn = new NewTimeApp.CircularButton();
            this.grpIdBtn = new NewTimeApp.CircularButton();
            this.studentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPanel
            // 
            this.studentPanel.BackColor = System.Drawing.Color.White;
            this.studentPanel.Controls.Add(this.grpIdBtn);
            this.studentPanel.Controls.Add(this.subGroupBrn);
            this.studentPanel.Controls.Add(this.mainGrpBtn);
            this.studentPanel.Controls.Add(this.degreeBtn);
            this.studentPanel.Controls.Add(this.accBtn);
            this.studentPanel.Controls.Add(this.pictureBox1);
            this.studentPanel.Controls.Add(this.studentBtn);
            this.studentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentPanel.Location = new System.Drawing.Point(0, 0);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(772, 720);
            this.studentPanel.TabIndex = 0;
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
            this.accBtn.Location = new System.Drawing.Point(72, 77);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(170, 170);
            this.accBtn.TabIndex = 27;
            this.accBtn.Text = "Academic Details";
            this.accBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accBtn.UseVisualStyleBackColor = false;
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
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
            this.studentBtn.Location = new System.Drawing.Point(40, 38);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(150, 150);
            this.studentBtn.TabIndex = 11;
            this.studentBtn.Text = "Student";
            this.studentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studentBtn.UseVisualStyleBackColor = false;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click_1);
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
            this.degreeBtn.Location = new System.Drawing.Point(500, 77);
            this.degreeBtn.Name = "degreeBtn";
            this.degreeBtn.Size = new System.Drawing.Size(170, 170);
            this.degreeBtn.TabIndex = 28;
            this.degreeBtn.Text = "Degree Programs";
            this.degreeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.degreeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.degreeBtn.UseVisualStyleBackColor = false;
            // 
            // mainGrpBtn
            // 
            this.mainGrpBtn.BackColor = System.Drawing.Color.Plum;
            this.mainGrpBtn.FlatAppearance.BorderSize = 0;
            this.mainGrpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.mainGrpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainGrpBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGrpBtn.ForeColor = System.Drawing.Color.White;
            this.mainGrpBtn.Image = ((System.Drawing.Image)(resources.GetObject("mainGrpBtn.Image")));
            this.mainGrpBtn.Location = new System.Drawing.Point(72, 440);
            this.mainGrpBtn.Name = "mainGrpBtn";
            this.mainGrpBtn.Size = new System.Drawing.Size(170, 170);
            this.mainGrpBtn.TabIndex = 29;
            this.mainGrpBtn.Text = "Main Groups";
            this.mainGrpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainGrpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mainGrpBtn.UseVisualStyleBackColor = false;
            // 
            // subGroupBrn
            // 
            this.subGroupBrn.BackColor = System.Drawing.Color.Plum;
            this.subGroupBrn.FlatAppearance.BorderSize = 0;
            this.subGroupBrn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.subGroupBrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subGroupBrn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroupBrn.ForeColor = System.Drawing.Color.White;
            this.subGroupBrn.Image = ((System.Drawing.Image)(resources.GetObject("subGroupBrn.Image")));
            this.subGroupBrn.Location = new System.Drawing.Point(500, 440);
            this.subGroupBrn.Name = "subGroupBrn";
            this.subGroupBrn.Size = new System.Drawing.Size(170, 170);
            this.subGroupBrn.TabIndex = 30;
            this.subGroupBrn.Text = "Sub Groups";
            this.subGroupBrn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subGroupBrn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.subGroupBrn.UseVisualStyleBackColor = false;
            // 
            // grpIdBtn
            // 
            this.grpIdBtn.BackColor = System.Drawing.Color.Plum;
            this.grpIdBtn.FlatAppearance.BorderSize = 0;
            this.grpIdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.grpIdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpIdBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIdBtn.ForeColor = System.Drawing.Color.White;
            this.grpIdBtn.Image = ((System.Drawing.Image)(resources.GetObject("grpIdBtn.Image")));
            this.grpIdBtn.Location = new System.Drawing.Point(300, 271);
            this.grpIdBtn.Name = "grpIdBtn";
            this.grpIdBtn.Size = new System.Drawing.Size(170, 170);
            this.grpIdBtn.TabIndex = 31;
            this.grpIdBtn.Text = "Generate Group ID";
            this.grpIdBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grpIdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.grpIdBtn.UseVisualStyleBackColor = false;
            // 
            // StudentsUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.studentPanel);
            this.Name = "StudentsUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.studentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel studentPanel;
        private CircularButton studentBtn;
        private CircularButton accBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton subGroupBrn;
        private CircularButton mainGrpBtn;
        private CircularButton degreeBtn;
        private CircularButton grpIdBtn;
    }
}
