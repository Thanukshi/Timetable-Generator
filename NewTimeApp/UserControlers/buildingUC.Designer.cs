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
            this.buldingAddBtn = new ePOSOne.btnProduct.Button_WOC();
            this.backBtn = new System.Windows.Forms.Button();
            this.buildingNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buildingpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildingpanel
            // 
            this.buildingpanel.BackColor = System.Drawing.Color.White;
            this.buildingpanel.Controls.Add(this.buldingAddBtn);
            this.buildingpanel.Controls.Add(this.backBtn);
            this.buildingpanel.Controls.Add(this.buildingNameTB);
            this.buildingpanel.Controls.Add(this.label2);
            this.buildingpanel.Controls.Add(this.label1);
            this.buildingpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingpanel.Location = new System.Drawing.Point(0, 0);
            this.buildingpanel.Name = "buildingpanel";
            this.buildingpanel.Size = new System.Drawing.Size(772, 720);
            this.buildingpanel.TabIndex = 0;
            // 
            // buldingAddBtn
            // 
            this.buldingAddBtn.BackColor = System.Drawing.Color.White;
            this.buldingAddBtn.BorderColor = System.Drawing.Color.Black;
            this.buldingAddBtn.ButtonColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatAppearance.BorderSize = 0;
            this.buldingAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buldingAddBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buldingAddBtn.ForeColor = System.Drawing.Color.Black;
            this.buldingAddBtn.Location = new System.Drawing.Point(302, 461);
            this.buldingAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.buldingAddBtn.Name = "buldingAddBtn";
            this.buldingAddBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.buldingAddBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buldingAddBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buldingAddBtn.Size = new System.Drawing.Size(124, 54);
            this.buldingAddBtn.TabIndex = 25;
            this.buldingAddBtn.Text = "ADD";
            this.buldingAddBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buldingAddBtn.UseVisualStyleBackColor = false;
            this.buldingAddBtn.Click += new System.EventHandler(this.buldingAddBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(25, 34);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 24;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // buildingNameTB
            // 
            this.buildingNameTB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameTB.Location = new System.Drawing.Point(360, 242);
            this.buildingNameTB.Multiline = true;
            this.buildingNameTB.Name = "buildingNameTB";
            this.buildingNameTB.Size = new System.Drawing.Size(337, 44);
            this.buildingNameTB.TabIndex = 3;
            this.buildingNameTB.TextChanged += new System.EventHandler(this.buildingNameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(129, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Building Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(89, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Buildings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buildingpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buildingNameTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button backBtn;
        private ePOSOne.btnProduct.Button_WOC buldingAddBtn;
    }
}
