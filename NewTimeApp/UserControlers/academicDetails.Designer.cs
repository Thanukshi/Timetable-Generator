namespace NewTimeApp.UserControlers
{
    partial class academicDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(academicDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acYear = new System.Windows.Forms.ComboBox();
            this.saveAcc = new ePOSOne.btnProduct.Button_WOC();
            this.acPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.acPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(97, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Academic Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(97, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Academic Semester";
            // 
            // acYear
            // 
            this.acYear.BackColor = System.Drawing.Color.White;
            this.acYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acYear.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.acYear.FormattingEnabled = true;
            this.acYear.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.acYear.Location = new System.Drawing.Point(374, 207);
            this.acYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acYear.Name = "acYear";
            this.acYear.Size = new System.Drawing.Size(314, 39);
            this.acYear.TabIndex = 4;
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
            this.saveAcc.Location = new System.Drawing.Point(374, 405);
            this.saveAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveAcc.Name = "saveAcc";
            this.saveAcc.OnHoverBorderColor = System.Drawing.Color.White;
            this.saveAcc.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saveAcc.OnHoverTextColor = System.Drawing.Color.White;
            this.saveAcc.Size = new System.Drawing.Size(313, 54);
            this.saveAcc.TabIndex = 21;
            this.saveAcc.Text = "Save";
            this.saveAcc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveAcc.UseVisualStyleBackColor = false;
            // 
            // acPanel
            // 
            this.acPanel.BackColor = System.Drawing.Color.White;
            this.acPanel.Controls.Add(this.comboBox1);
            this.acPanel.Controls.Add(this.backBtn);
            this.acPanel.Controls.Add(this.saveAcc);
            this.acPanel.Controls.Add(this.acYear);
            this.acPanel.Controls.Add(this.label3);
            this.acPanel.Controls.Add(this.label2);
            this.acPanel.Controls.Add(this.label1);
            this.acPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acPanel.Location = new System.Drawing.Point(0, 0);
            this.acPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acPanel.Name = "acPanel";
            this.acPanel.Size = new System.Drawing.Size(750, 642);
            this.acPanel.TabIndex = 0;
            this.acPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.acPanel_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.comboBox1.Location = new System.Drawing.Point(374, 308);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 39);
            this.comboBox1.TabIndex = 24;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(16, 11);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 23;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // academicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.acPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "academicDetails";
            this.Size = new System.Drawing.Size(750, 642);
            this.Load += new System.EventHandler(this.academicDetails_Load);
            this.acPanel.ResumeLayout(false);
            this.acPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox acYear;
        private ePOSOne.btnProduct.Button_WOC saveAcc;
        private System.Windows.Forms.Panel acPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
