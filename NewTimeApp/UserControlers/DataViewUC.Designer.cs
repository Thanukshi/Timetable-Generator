namespace NewTimeApp.UserControlers
{
    partial class DataViewUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewUC));
            this.accBtn = new NewTimeApp.CircularButton();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.degreeBtn = new NewTimeApp.CircularButton();
            this.mainGrpBtn = new NewTimeApp.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subGroupBrn = new NewTimeApp.CircularButton();
            this.backBtnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.accBtn.Location = new System.Drawing.Point(109, 159);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(250, 250);
            this.accBtn.TabIndex = 47;
            this.accBtn.Text = "Academic Details";
            this.accBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accBtn.UseVisualStyleBackColor = false;
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.Color.White;
            this.viewPanel.Controls.Add(this.subGroupBrn);
            this.viewPanel.Controls.Add(this.mainGrpBtn);
            this.viewPanel.Controls.Add(this.degreeBtn);
            this.viewPanel.Controls.Add(this.accBtn);
            this.viewPanel.Controls.Add(this.backBtnS);
            this.viewPanel.Controls.Add(this.label1);
            this.viewPanel.Controls.Add(this.pictureBox1);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1000, 790);
            this.viewPanel.TabIndex = 0;
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
            this.degreeBtn.Location = new System.Drawing.Point(624, 159);
            this.degreeBtn.Name = "degreeBtn";
            this.degreeBtn.Size = new System.Drawing.Size(250, 250);
            this.degreeBtn.TabIndex = 48;
            this.degreeBtn.Text = "Degree Programs";
            this.degreeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.degreeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.degreeBtn.UseVisualStyleBackColor = false;
            this.degreeBtn.Click += new System.EventHandler(this.degreeBtn_Click);
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
            this.mainGrpBtn.Location = new System.Drawing.Point(109, 512);
            this.mainGrpBtn.Name = "mainGrpBtn";
            this.mainGrpBtn.Size = new System.Drawing.Size(250, 250);
            this.mainGrpBtn.TabIndex = 49;
            this.mainGrpBtn.Text = "Main Groups ID";
            this.mainGrpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainGrpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mainGrpBtn.UseVisualStyleBackColor = false;
            this.mainGrpBtn.Click += new System.EventHandler(this.mainGrpBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 790);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.subGroupBrn.Location = new System.Drawing.Point(624, 512);
            this.subGroupBrn.Name = "subGroupBrn";
            this.subGroupBrn.Size = new System.Drawing.Size(250, 250);
            this.subGroupBrn.TabIndex = 50;
            this.subGroupBrn.Text = "Sub Groups ID";
            this.subGroupBrn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subGroupBrn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.subGroupBrn.UseVisualStyleBackColor = false;
            this.subGroupBrn.Click += new System.EventHandler(this.subGroupBrn_Click);
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
            this.backBtnS.Click += new System.EventHandler(this.backBtnS_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewPanel);
            this.Name = "DataViewUC";
            this.Size = new System.Drawing.Size(1000, 790);
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton accBtn;
        private System.Windows.Forms.Panel viewPanel;
        private CircularButton subGroupBrn;
        private CircularButton mainGrpBtn;
        private CircularButton degreeBtn;
        private System.Windows.Forms.Button backBtnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
