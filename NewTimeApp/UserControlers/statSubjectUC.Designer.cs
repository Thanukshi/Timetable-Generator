﻿namespace NewTimeApp.UserControlers
{
    partial class statSubjectUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statSubjectUC));
            this.statSubjectpanel = new System.Windows.Forms.Panel();
            this.subgraphpanel = new System.Windows.Forms.Panel();
            this.subyearBtn = new ePOSOne.btnProduct.Button_WOC();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statSubjectpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statSubjectpanel
            // 
            this.statSubjectpanel.Controls.Add(this.subgraphpanel);
            this.statSubjectpanel.Controls.Add(this.subyearBtn);
            this.statSubjectpanel.Controls.Add(this.backBtn);
            this.statSubjectpanel.Controls.Add(this.label1);
            this.statSubjectpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statSubjectpanel.Location = new System.Drawing.Point(0, 0);
            this.statSubjectpanel.Name = "statSubjectpanel";
            this.statSubjectpanel.Size = new System.Drawing.Size(772, 720);
            this.statSubjectpanel.TabIndex = 0;
            // 
            // subgraphpanel
            // 
            this.subgraphpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.subgraphpanel.Location = new System.Drawing.Point(21, 161);
            this.subgraphpanel.Name = "subgraphpanel";
            this.subgraphpanel.Size = new System.Drawing.Size(733, 540);
            this.subgraphpanel.TabIndex = 30;
            // 
            // subyearBtn
            // 
            this.subyearBtn.BackColor = System.Drawing.Color.White;
            this.subyearBtn.BorderColor = System.Drawing.Color.Black;
            this.subyearBtn.ButtonColor = System.Drawing.Color.White;
            this.subyearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subyearBtn.FlatAppearance.BorderSize = 0;
            this.subyearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.subyearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.subyearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subyearBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subyearBtn.ForeColor = System.Drawing.Color.Black;
            this.subyearBtn.Location = new System.Drawing.Point(210, 85);
            this.subyearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.subyearBtn.Name = "subyearBtn";
            this.subyearBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.subyearBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subyearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.subyearBtn.Size = new System.Drawing.Size(329, 54);
            this.subyearBtn.TabIndex = 29;
            this.subyearBtn.Text = "Year wise Subjects Count ";
            this.subyearBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.subyearBtn.UseVisualStyleBackColor = false;
            this.subyearBtn.Click += new System.EventHandler(this.subyearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(21, 14);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 28;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Statistics Related to Subjects";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statSubjectUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statSubjectpanel);
            this.Name = "statSubjectUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.statSubjectpanel.ResumeLayout(false);
            this.statSubjectpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statSubjectpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private ePOSOne.btnProduct.Button_WOC subyearBtn;
        private System.Windows.Forms.Panel subgraphpanel;
    }
}
