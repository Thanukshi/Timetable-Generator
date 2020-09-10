namespace NewTimeApp.UserControlers
{
    partial class WorkingDaysAndHoursUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingDaysAndHoursUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpIdBtn = new NewTimeApp.CircularButton();
            this.accBtn = new NewTimeApp.CircularButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grpIdBtn);
            this.panel1.Controls.Add(this.accBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 642);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.grpIdBtn.Location = new System.Drawing.Point(428, 210);
            this.grpIdBtn.Name = "grpIdBtn";
            this.grpIdBtn.Size = new System.Drawing.Size(170, 170);
            this.grpIdBtn.TabIndex = 33;
            this.grpIdBtn.Text = "WeekEnd TimeTable";
            this.grpIdBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grpIdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.grpIdBtn.UseVisualStyleBackColor = false;
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
            this.accBtn.Location = new System.Drawing.Point(153, 210);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(170, 170);
            this.accBtn.TabIndex = 32;
            this.accBtn.Text = "WeekDay TimeTable";
            this.accBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accBtn.UseVisualStyleBackColor = false;
            // 
            // WorkingDaysAndHoursUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WorkingDaysAndHoursUC";
            this.Size = new System.Drawing.Size(750, 642);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton grpIdBtn;
        private CircularButton accBtn;
    }
}
