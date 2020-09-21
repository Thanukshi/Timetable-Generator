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
            this.endBtn = new NewTimeApp.CircularButton();
            this.dayBtn = new NewTimeApp.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.endBtn);
            this.panel1.Controls.Add(this.dayBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 642);
            this.panel1.TabIndex = 0;
            // 
            // endBtn
            // 
            this.endBtn.BackColor = System.Drawing.Color.Plum;
            this.endBtn.FlatAppearance.BorderSize = 0;
            this.endBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.endBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBtn.ForeColor = System.Drawing.Color.White;
            this.endBtn.Image = global::NewTimeApp.Properties.Resources.calendar_64;
            this.endBtn.Location = new System.Drawing.Point(428, 210);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(170, 170);
            this.endBtn.TabIndex = 33;
            this.endBtn.Text = "WeekEnd TimeTable";
            this.endBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.endBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.endBtn.UseVisualStyleBackColor = false;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // dayBtn
            // 
            this.dayBtn.BackColor = System.Drawing.Color.Plum;
            this.dayBtn.FlatAppearance.BorderSize = 0;
            this.dayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.dayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBtn.ForeColor = System.Drawing.Color.White;
            this.dayBtn.Image = global::NewTimeApp.Properties.Resources.calendar_64;
            this.dayBtn.Location = new System.Drawing.Point(153, 210);
            this.dayBtn.Name = "dayBtn";
            this.dayBtn.Size = new System.Drawing.Size(170, 170);
            this.dayBtn.TabIndex = 32;
            this.dayBtn.Text = "WeekDay TimeTable";
            this.dayBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dayBtn.UseVisualStyleBackColor = false;
            this.dayBtn.Click += new System.EventHandler(this.dayBtn_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(17, 18);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 40;
            this.backBtn.UseVisualStyleBackColor = true;
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
        private CircularButton endBtn;
        private CircularButton dayBtn;
        private System.Windows.Forms.Label titleOfPages;
        private System.Windows.Forms.Button backBtn;
    }
}
