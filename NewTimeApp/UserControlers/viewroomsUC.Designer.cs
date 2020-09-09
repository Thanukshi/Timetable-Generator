namespace NewTimeApp.UserControlers
{
    partial class viewroomsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewroomsUC));
            this.viewroomspanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.showroompanel = new System.Windows.Forms.Panel();
            this.viewroomspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewroomspanel
            // 
            this.viewroomspanel.Controls.Add(this.showroompanel);
            this.viewroomspanel.Controls.Add(this.backBtn);
            this.viewroomspanel.Controls.Add(this.label1);
            this.viewroomspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewroomspanel.Location = new System.Drawing.Point(0, 0);
            this.viewroomspanel.Name = "viewroomspanel";
            this.viewroomspanel.Size = new System.Drawing.Size(772, 720);
            this.viewroomspanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rooms ";
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(18, 25);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 30;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // showroompanel
            // 
            this.showroompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.showroompanel.Location = new System.Drawing.Point(18, 101);
            this.showroompanel.Name = "showroompanel";
            this.showroompanel.Size = new System.Drawing.Size(720, 598);
            this.showroompanel.TabIndex = 31;
            // 
            // viewroomsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.viewroomspanel);
            this.Name = "viewroomsUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.viewroomspanel.ResumeLayout(false);
            this.viewroomspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewroomspanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel showroompanel;
    }
}
