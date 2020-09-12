namespace NewTimeApp
{
    partial class academicDetailsUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(academicDetailsUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.saveAcc = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acUpYear = new System.Windows.Forms.TextBox();
            this.acUpSem = new System.Windows.Forms.TextBox();
            this.deltBtn = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.deltBtn);
            this.panel1.Controls.Add(this.acUpSem);
            this.panel1.Controls.Add(this.acUpYear);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.saveAcc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 790);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(26, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(66, 56);
            this.backBtn.TabIndex = 28;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // saveAcc
            // 
            this.saveAcc.BackColor = System.Drawing.Color.White;
            this.saveAcc.BorderColor = System.Drawing.Color.Black;
            this.saveAcc.ButtonColor = System.Drawing.Color.White;
            this.saveAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveAcc.FlatAppearance.BorderSize = 0;
            this.saveAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAcc.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAcc.ForeColor = System.Drawing.Color.Black;
            this.saveAcc.Location = new System.Drawing.Point(496, 489);
            this.saveAcc.Name = "saveAcc";
            this.saveAcc.OnHoverBorderColor = System.Drawing.Color.White;
            this.saveAcc.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saveAcc.OnHoverTextColor = System.Drawing.Color.White;
            this.saveAcc.Size = new System.Drawing.Size(417, 67);
            this.saveAcc.TabIndex = 27;
            this.saveAcc.Text = "Update";
            this.saveAcc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveAcc.UseVisualStyleBackColor = false;
            this.saveAcc.Click += new System.EventHandler(this.saveAcc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(127, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 38);
            this.label3.TabIndex = 26;
            this.label3.Text = "Academic Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(127, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Academic Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(112, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Update Academic Details";
            // 
            // acUpYear
            // 
            this.acUpYear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acUpYear.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acUpYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.acUpYear.Location = new System.Drawing.Point(496, 227);
            this.acUpYear.Multiline = true;
            this.acUpYear.Name = "acUpYear";
            this.acUpYear.Size = new System.Drawing.Size(417, 45);
            this.acUpYear.TabIndex = 34;
            // 
            // acUpSem
            // 
            this.acUpSem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acUpSem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acUpSem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.acUpSem.Location = new System.Drawing.Point(496, 343);
            this.acUpSem.Multiline = true;
            this.acUpSem.Name = "acUpSem";
            this.acUpSem.Size = new System.Drawing.Size(417, 45);
            this.acUpSem.TabIndex = 35;
            // 
            // deltBtn
            // 
            this.deltBtn.BackColor = System.Drawing.Color.White;
            this.deltBtn.BorderColor = System.Drawing.Color.Black;
            this.deltBtn.ButtonColor = System.Drawing.Color.White;
            this.deltBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deltBtn.FlatAppearance.BorderSize = 0;
            this.deltBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deltBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deltBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltBtn.ForeColor = System.Drawing.Color.Black;
            this.deltBtn.Location = new System.Drawing.Point(496, 585);
            this.deltBtn.Name = "deltBtn";
            this.deltBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.deltBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deltBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deltBtn.Size = new System.Drawing.Size(417, 67);
            this.deltBtn.TabIndex = 36;
            this.deltBtn.Text = "Delete";
            this.deltBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deltBtn.UseVisualStyleBackColor = false;
            // 
            // academicDetailsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "academicDetailsUpdate";
            this.Size = new System.Drawing.Size(1000, 790);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private ePOSOne.btnProduct.Button_WOC saveAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC deltBtn;
        private System.Windows.Forms.TextBox acUpSem;
        private System.Windows.Forms.TextBox acUpYear;
    }
}
