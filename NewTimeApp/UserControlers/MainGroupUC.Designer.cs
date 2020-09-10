namespace NewTimeApp.UserControlers
{
    partial class MainGroupUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGroupUC));
            this.mgPanel = new System.Windows.Forms.Panel();
            this.mainGropNo = new System.Windows.Forms.ComboBox();
            this.degreeDetailsCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acDetails = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveMG = new ePOSOne.btnProduct.Button_WOC();
            this.mgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mgPanel
            // 
            this.mgPanel.BackColor = System.Drawing.Color.White;
            this.mgPanel.Controls.Add(this.saveMG);
            this.mgPanel.Controls.Add(this.mainGropNo);
            this.mgPanel.Controls.Add(this.degreeDetailsCombo);
            this.mgPanel.Controls.Add(this.label4);
            this.mgPanel.Controls.Add(this.label3);
            this.mgPanel.Controls.Add(this.acDetails);
            this.mgPanel.Controls.Add(this.label2);
            this.mgPanel.Controls.Add(this.backBtnD);
            this.mgPanel.Controls.Add(this.label1);
            this.mgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgPanel.Location = new System.Drawing.Point(0, 0);
            this.mgPanel.Name = "mgPanel";
            this.mgPanel.Size = new System.Drawing.Size(1000, 790);
            this.mgPanel.TabIndex = 0;
            // 
            // mainGropNo
            // 
            this.mainGropNo.BackColor = System.Drawing.Color.White;
            this.mainGropNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainGropNo.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGropNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.mainGropNo.FormattingEnabled = true;
            this.mainGropNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.mainGropNo.Location = new System.Drawing.Point(563, 392);
            this.mainGropNo.Name = "mainGropNo";
            this.mainGropNo.Size = new System.Drawing.Size(417, 46);
            this.mainGropNo.TabIndex = 39;
            // 
            // degreeDetailsCombo
            // 
            this.degreeDetailsCombo.BackColor = System.Drawing.Color.White;
            this.degreeDetailsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degreeDetailsCombo.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeDetailsCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.degreeDetailsCombo.FormattingEnabled = true;
            this.degreeDetailsCombo.Location = new System.Drawing.Point(563, 279);
            this.degreeDetailsCombo.Name = "degreeDetailsCombo";
            this.degreeDetailsCombo.Size = new System.Drawing.Size(417, 46);
            this.degreeDetailsCombo.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(67, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 38);
            this.label4.TabIndex = 37;
            this.label4.Text = "Degree Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(67, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 38);
            this.label3.TabIndex = 35;
            this.label3.Text = "Groups No";
            // 
            // acDetails
            // 
            this.acDetails.BackColor = System.Drawing.Color.White;
            this.acDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acDetails.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.acDetails.FormattingEnabled = true;
            this.acDetails.Location = new System.Drawing.Point(563, 174);
            this.acDetails.Name = "acDetails";
            this.acDetails.Size = new System.Drawing.Size(417, 46);
            this.acDetails.TabIndex = 34;
            this.acDetails.SelectedIndexChanged += new System.EventHandler(this.acDetails_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(67, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 38);
            this.label2.TabIndex = 33;
            this.label2.Text = "Academic Year And Semester";
            // 
            // backBtnD
            // 
            this.backBtnD.FlatAppearance.BorderSize = 0;
            this.backBtnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnD.Image = ((System.Drawing.Image)(resources.GetObject("backBtnD.Image")));
            this.backBtnD.Location = new System.Drawing.Point(33, 22);
            this.backBtnD.Name = "backBtnD";
            this.backBtnD.Size = new System.Drawing.Size(66, 56);
            this.backBtnD.TabIndex = 32;
            this.backBtnD.UseVisualStyleBackColor = true;
            this.backBtnD.Click += new System.EventHandler(this.backBtnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(121, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 41);
            this.label1.TabIndex = 31;
            this.label1.Text = "Main Groups";
            // 
            // saveMG
            // 
            this.saveMG.BackColor = System.Drawing.Color.White;
            this.saveMG.BorderColor = System.Drawing.Color.Black;
            this.saveMG.ButtonColor = System.Drawing.Color.White;
            this.saveMG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveMG.FlatAppearance.BorderSize = 0;
            this.saveMG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMG.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMG.ForeColor = System.Drawing.Color.Black;
            this.saveMG.Location = new System.Drawing.Point(563, 516);
            this.saveMG.Name = "saveMG";
            this.saveMG.OnHoverBorderColor = System.Drawing.Color.White;
            this.saveMG.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saveMG.OnHoverTextColor = System.Drawing.Color.White;
            this.saveMG.Size = new System.Drawing.Size(417, 67);
            this.saveMG.TabIndex = 40;
            this.saveMG.Text = "Generate Main Group ID";
            this.saveMG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveMG.UseVisualStyleBackColor = false;
            this.saveMG.Click += new System.EventHandler(this.saveMG_Click);
            // 
            // MainGroupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mgPanel);
            this.Name = "MainGroupUC";
            this.Size = new System.Drawing.Size(1000, 790);
            this.mgPanel.ResumeLayout(false);
            this.mgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mgPanel;
        private System.Windows.Forms.Button backBtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox acDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mainGropNo;
        private System.Windows.Forms.ComboBox degreeDetailsCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC saveMG;
    }
}
