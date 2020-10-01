namespace NewTimeApp.UserControlers
{
    partial class DegreeProgramUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DegreeProgramUC));
            this.degreePanel = new System.Windows.Forms.Panel();
            this.preferNameD = new System.Windows.Forms.TextBox();
            this.programNameD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtnD = new System.Windows.Forms.Button();
            this.saveDe = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.degreePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // degreePanel
            // 
            this.degreePanel.BackColor = System.Drawing.Color.White;
            this.degreePanel.Controls.Add(this.preferNameD);
            this.degreePanel.Controls.Add(this.programNameD);
            this.degreePanel.Controls.Add(this.label3);
            this.degreePanel.Controls.Add(this.label2);
            this.degreePanel.Controls.Add(this.backBtnD);
            this.degreePanel.Controls.Add(this.saveDe);
            this.degreePanel.Controls.Add(this.label1);
            this.degreePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.degreePanel.Location = new System.Drawing.Point(0, 0);
            this.degreePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.degreePanel.Name = "degreePanel";
            this.degreePanel.Size = new System.Drawing.Size(750, 642);
            this.degreePanel.TabIndex = 0;
            this.degreePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.degreePanel_Paint);
            // 
            // preferNameD
            // 
            this.preferNameD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.preferNameD.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferNameD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.preferNameD.Location = new System.Drawing.Point(340, 270);
            this.preferNameD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preferNameD.Multiline = true;
            this.preferNameD.Name = "preferNameD";
            this.preferNameD.Size = new System.Drawing.Size(354, 37);
            this.preferNameD.TabIndex = 34;
            // 
            // programNameD
            // 
            this.programNameD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.programNameD.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.programNameD.Location = new System.Drawing.Point(340, 179);
            this.programNameD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.programNameD.Multiline = true;
            this.programNameD.Name = "programNameD";
            this.programNameD.Size = new System.Drawing.Size(354, 37);
            this.programNameD.TabIndex = 33;
            this.programNameD.TextChanged += new System.EventHandler(this.programNameD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(86, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Prefered Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(86, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "Program Name";
            // 
            // backBtnD
            // 
            this.backBtnD.FlatAppearance.BorderSize = 0;
            this.backBtnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnD.Image = ((System.Drawing.Image)(resources.GetObject("backBtnD.Image")));
            this.backBtnD.Location = new System.Drawing.Point(26, 21);
            this.backBtnD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtnD.Name = "backBtnD";
            this.backBtnD.Size = new System.Drawing.Size(50, 46);
            this.backBtnD.TabIndex = 30;
            this.backBtnD.UseVisualStyleBackColor = true;
            this.backBtnD.Click += new System.EventHandler(this.backBtnD_Click);
            // 
            // saveDe
            // 
            this.saveDe.BackColor = System.Drawing.Color.White;
            this.saveDe.BorderColor = System.Drawing.Color.Black;
            this.saveDe.ButtonColor = System.Drawing.Color.White;
            this.saveDe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveDe.FlatAppearance.BorderSize = 0;
            this.saveDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDe.ForeColor = System.Drawing.Color.Black;
            this.saveDe.Location = new System.Drawing.Point(380, 350);
            this.saveDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveDe.Name = "saveDe";
            this.saveDe.OnHoverBorderColor = System.Drawing.Color.White;
            this.saveDe.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saveDe.OnHoverTextColor = System.Drawing.Color.White;
            this.saveDe.Size = new System.Drawing.Size(313, 54);
            this.saveDe.TabIndex = 29;
            this.saveDe.Text = "Save";
            this.saveDe.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveDe.UseVisualStyleBackColor = false;
            this.saveDe.Click += new System.EventHandler(this.saveDe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(92, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 24;
            this.label1.Text = "Degree Programs";
            // 
            // DegreeProgramUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.degreePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DegreeProgramUC";
            this.Size = new System.Drawing.Size(750, 642);
            this.degreePanel.ResumeLayout(false);
            this.degreePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel degreePanel;
        private System.Windows.Forms.Button backBtnD;
        private ePOSOne.btnProduct.Button_WOC saveDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox programNameD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preferNameD;
    }
}
