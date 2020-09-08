﻿namespace NewTimeApp.UserControlers
{
    partial class buildingUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buildingUC));
            this.buildingpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buildingBtn = new ePOSOne.btnProduct.Button_WOC();
            this.buildingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingpanel
            // 
            this.buildingpanel.BackColor = System.Drawing.Color.White;
            this.buildingpanel.Controls.Add(this.buildingBtn);
            this.buildingpanel.Controls.Add(this.textBox1);
            this.buildingpanel.Controls.Add(this.label2);
            this.buildingpanel.Controls.Add(this.label1);
            this.buildingpanel.Controls.Add(this.pictureBox1);
            this.buildingpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingpanel.Location = new System.Drawing.Point(0, 0);
            this.buildingpanel.Name = "buildingpanel";
            this.buildingpanel.Size = new System.Drawing.Size(772, 720);
            this.buildingpanel.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Buildings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(124, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Building Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 247);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 29);
            this.textBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buildingBtn
            // 
            this.buildingBtn.BackColor = System.Drawing.Color.White;
            this.buildingBtn.BorderColor = System.Drawing.Color.Black;
            this.buildingBtn.ButtonColor = System.Drawing.Color.White;
            this.buildingBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buildingBtn.FlatAppearance.BorderSize = 0;
            this.buildingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buildingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buildingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildingBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingBtn.ForeColor = System.Drawing.Color.Black;
            this.buildingBtn.Location = new System.Drawing.Point(311, 384);
            this.buildingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.buildingBtn.Name = "buildingBtn";
            this.buildingBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.buildingBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buildingBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buildingBtn.Size = new System.Drawing.Size(124, 54);
            this.buildingBtn.TabIndex = 21;
            this.buildingBtn.Text = "ADD";
            this.buildingBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buildingBtn.UseVisualStyleBackColor = false;
            this.buildingBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // buildingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buildingpanel);
            this.Name = "buildingUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.buildingpanel.ResumeLayout(false);
            this.buildingpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buildingpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ePOSOne.btnProduct.Button_WOC buildingBtn;
    }
}
