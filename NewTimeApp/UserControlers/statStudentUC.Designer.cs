﻿namespace NewTimeApp.UserControlers
{
    partial class statStudentUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statStudentUC));
            this.statStudentpanel = new System.Windows.Forms.Panel();
            this.studgraphpanel = new System.Windows.Forms.Panel();
            this.studyearBtn = new ePOSOne.btnProduct.Button_WOC();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progStudBtn = new ePOSOne.btnProduct.Button_WOC();
            this.statStudentpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statStudentpanel
            // 
            this.statStudentpanel.Controls.Add(this.progStudBtn);
            this.statStudentpanel.Controls.Add(this.studgraphpanel);
            this.statStudentpanel.Controls.Add(this.studyearBtn);
            this.statStudentpanel.Controls.Add(this.backBtn);
            this.statStudentpanel.Controls.Add(this.label1);
            this.statStudentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statStudentpanel.Location = new System.Drawing.Point(0, 0);
            this.statStudentpanel.Name = "statStudentpanel";
            this.statStudentpanel.Size = new System.Drawing.Size(772, 720);
            this.statStudentpanel.TabIndex = 0;
            // 
            // studgraphpanel
            // 
            this.studgraphpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studgraphpanel.Location = new System.Drawing.Point(20, 167);
            this.studgraphpanel.Name = "studgraphpanel";
            this.studgraphpanel.Size = new System.Drawing.Size(736, 537);
            this.studgraphpanel.TabIndex = 29;
            // 
            // studyearBtn
            // 
            this.studyearBtn.BackColor = System.Drawing.Color.White;
            this.studyearBtn.BorderColor = System.Drawing.Color.Black;
            this.studyearBtn.ButtonColor = System.Drawing.Color.White;
            this.studyearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.studyearBtn.FlatAppearance.BorderSize = 0;
            this.studyearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.studyearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.studyearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studyearBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyearBtn.ForeColor = System.Drawing.Color.Black;
            this.studyearBtn.Location = new System.Drawing.Point(20, 84);
            this.studyearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.studyearBtn.Name = "studyearBtn";
            this.studyearBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.studyearBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studyearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.studyearBtn.Size = new System.Drawing.Size(312, 54);
            this.studyearBtn.TabIndex = 27;
            this.studyearBtn.Text = "Year wise Students Count ";
            this.studyearBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.studyearBtn.UseVisualStyleBackColor = false;
            this.studyearBtn.Click += new System.EventHandler(this.studyearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(20, 9);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 26;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Statistics Related to Students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progStudBtn
            // 
            this.progStudBtn.BackColor = System.Drawing.Color.White;
            this.progStudBtn.BorderColor = System.Drawing.Color.Black;
            this.progStudBtn.ButtonColor = System.Drawing.Color.White;
            this.progStudBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.progStudBtn.FlatAppearance.BorderSize = 0;
            this.progStudBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.progStudBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.progStudBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progStudBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progStudBtn.ForeColor = System.Drawing.Color.Black;
            this.progStudBtn.Location = new System.Drawing.Point(364, 84);
            this.progStudBtn.Margin = new System.Windows.Forms.Padding(2);
            this.progStudBtn.Name = "progStudBtn";
            this.progStudBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.progStudBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progStudBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.progStudBtn.Size = new System.Drawing.Size(392, 54);
            this.progStudBtn.TabIndex = 30;
            this.progStudBtn.Text = "Programme wise Students Count ";
            this.progStudBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.progStudBtn.UseVisualStyleBackColor = false;
            this.progStudBtn.Click += new System.EventHandler(this.progStudBtn_Click);
            // 
            // statStudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statStudentpanel);
            this.Name = "statStudentUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.statStudentpanel.ResumeLayout(false);
            this.statStudentpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statStudentpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private ePOSOne.btnProduct.Button_WOC studyearBtn;
        private System.Windows.Forms.Panel studgraphpanel;
        private ePOSOne.btnProduct.Button_WOC progStudBtn;
    }
}
