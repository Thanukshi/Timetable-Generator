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
            this.ViewBtn = new NewTimeApp.CircularButton();
            this.AddBtn = new NewTimeApp.CircularButton();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
           // this.panel1.Controls.Add(this.ViewBtn);
//            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 642);
            this.panel1.TabIndex = 0;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.Plum;
            this.ViewBtn.FlatAppearance.BorderSize = 0;
            this.ViewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.Color.White;
            this.ViewBtn.Image = global::NewTimeApp.Properties.Resources.list_view_64;
            this.ViewBtn.Location = new System.Drawing.Point(429, 227);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(170, 170);
            this.ViewBtn.TabIndex = 52;
            this.ViewBtn.Text = "View Details";
            this.ViewBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Plum;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::NewTimeApp.Properties.Resources.add_list_64;
            this.AddBtn.Location = new System.Drawing.Point(150, 227);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(170, 170);
            this.AddBtn.TabIndex = 51;
            this.AddBtn.Text = "Add New";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(20, 13);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 50;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::NewTimeApp.Properties.Resources.back1;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(750, 642);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // WorkingDaysAndHoursUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WorkingDaysAndHoursUC";
            this.Size = new System.Drawing.Size(750, 642);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularButton ViewBtn;
        private CircularButton AddBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
