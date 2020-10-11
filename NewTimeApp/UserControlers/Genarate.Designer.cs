namespace NewTimeApp.UserControlers
{
    partial class Genarate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genarate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.std = new NewTimeApp.CircularButton();
            this.lec = new NewTimeApp.CircularButton();
            this.hall = new NewTimeApp.CircularButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.std);
            this.panel1.Controls.Add(this.lec);
            this.panel1.Controls.Add(this.hall);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 720);
            this.panel1.TabIndex = 0;
            // 
            // std
            // 
            this.std.BackColor = System.Drawing.Color.Plum;
            this.std.FlatAppearance.BorderSize = 0;
            this.std.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.std.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std.ForeColor = System.Drawing.Color.White;
            //this.std.Image = global::NewTimeApp.Properties.Resources.student_64__1_;
            this.std.Location = new System.Drawing.Point(326, 262);
            this.std.Name = "std";
            this.std.Size = new System.Drawing.Size(150, 150);
            this.std.TabIndex = 39;
            this.std.Text = "Student Group";
            this.std.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.std.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.std.UseVisualStyleBackColor = false;
            this.std.Click += new System.EventHandler(this.std_Click);
            // 
            // lec
            // 
            this.lec.BackColor = System.Drawing.Color.Plum;
            this.lec.FlatAppearance.BorderSize = 0;
            this.lec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.lec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lec.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec.ForeColor = System.Drawing.Color.White;
            //this.lec.Image = global::NewTimeApp.Properties.Resources.teacher_64;
            this.lec.Location = new System.Drawing.Point(92, 262);
            this.lec.Name = "lec";
            this.lec.Size = new System.Drawing.Size(150, 150);
            this.lec.TabIndex = 38;
            this.lec.Text = "Lecturer";
            this.lec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lec.UseVisualStyleBackColor = false;
            this.lec.Click += new System.EventHandler(this.lec_Click);
            // 
            // hall
            // 
            this.hall.BackColor = System.Drawing.Color.Plum;
            this.hall.FlatAppearance.BorderSize = 0;
            this.hall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.hall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hall.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hall.ForeColor = System.Drawing.Color.White;
            //this.hall.Image = global::NewTimeApp.Properties.Resources.building_64__1_;
            this.hall.Location = new System.Drawing.Point(549, 262);
            this.hall.Name = "hall";
            this.hall.Size = new System.Drawing.Size(150, 150);
            this.hall.TabIndex = 37;
            this.hall.Text = "Hall";
            this.hall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hall.UseVisualStyleBackColor = false;
            this.hall.Click += new System.EventHandler(this.hall_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(772, 720);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Genarate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Genarate";
            this.Size = new System.Drawing.Size(772, 720);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CircularButton std;
        private CircularButton lec;
        private CircularButton hall;
    }
}
