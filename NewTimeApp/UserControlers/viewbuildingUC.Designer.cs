﻿namespace NewTimeApp.UserControlers
{
    partial class viewbuildingUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewbuildingUC));
            this.viewbuildpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.showbuildpanel = new System.Windows.Forms.Panel();
            this.viewbuildpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewbuildpanel
            // 
            this.viewbuildpanel.Controls.Add(this.showbuildpanel);
            this.viewbuildpanel.Controls.Add(this.backBtn);
            this.viewbuildpanel.Controls.Add(this.label1);
            this.viewbuildpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewbuildpanel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbuildpanel.Location = new System.Drawing.Point(0, 0);
            this.viewbuildpanel.Name = "viewbuildpanel";
            this.viewbuildpanel.Size = new System.Drawing.Size(772, 720);
            this.viewbuildpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buildings\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(13, 21);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 29;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // showbuildpanel
            // 
            this.showbuildpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.showbuildpanel.Location = new System.Drawing.Point(27, 106);
            this.showbuildpanel.Name = "showbuildpanel";
            this.showbuildpanel.Size = new System.Drawing.Size(720, 598);
            this.showbuildpanel.TabIndex = 30;
            // 
            // viewbuildingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.viewbuildpanel);
            this.Name = "viewbuildingUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.viewbuildpanel.ResumeLayout(false);
            this.viewbuildpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewbuildpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel showbuildpanel;
    }
}
