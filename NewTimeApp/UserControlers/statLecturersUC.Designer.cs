namespace NewTimeApp.UserControlers
{
    partial class statLecturersUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statLecturersUC));
            this.statLecturerspanel = new System.Windows.Forms.Panel();
            this.lecgraphpanel = new System.Windows.Forms.Panel();
            this.lecprogBtn = new ePOSOne.btnProduct.Button_WOC();
            this.leclevelBtn = new ePOSOne.btnProduct.Button_WOC();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statLecturerspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statLecturerspanel
            // 
            this.statLecturerspanel.Controls.Add(this.lecgraphpanel);
            this.statLecturerspanel.Controls.Add(this.lecprogBtn);
            this.statLecturerspanel.Controls.Add(this.leclevelBtn);
            this.statLecturerspanel.Controls.Add(this.backBtn);
            this.statLecturerspanel.Controls.Add(this.label1);
            this.statLecturerspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statLecturerspanel.Location = new System.Drawing.Point(0, 0);
            this.statLecturerspanel.Name = "statLecturerspanel";
            this.statLecturerspanel.Size = new System.Drawing.Size(772, 720);
            this.statLecturerspanel.TabIndex = 0;
            // 
            // lecgraphpanel
            // 
            this.lecgraphpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lecgraphpanel.Location = new System.Drawing.Point(13, 170);
            this.lecgraphpanel.Name = "lecgraphpanel";
            this.lecgraphpanel.Size = new System.Drawing.Size(747, 536);
            this.lecgraphpanel.TabIndex = 30;
            // 
            // lecprogBtn
            // 
            this.lecprogBtn.BackColor = System.Drawing.Color.White;
            this.lecprogBtn.BorderColor = System.Drawing.Color.Black;
            this.lecprogBtn.ButtonColor = System.Drawing.Color.White;
            this.lecprogBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lecprogBtn.FlatAppearance.BorderSize = 0;
            this.lecprogBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lecprogBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lecprogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecprogBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecprogBtn.ForeColor = System.Drawing.Color.Black;
            this.lecprogBtn.Location = new System.Drawing.Point(365, 101);
            this.lecprogBtn.Margin = new System.Windows.Forms.Padding(2);
            this.lecprogBtn.Name = "lecprogBtn";
            this.lecprogBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.lecprogBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lecprogBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.lecprogBtn.Size = new System.Drawing.Size(395, 54);
            this.lecprogBtn.TabIndex = 29;
            this.lecprogBtn.Text = "Programme wise Lecturers Count ";
            this.lecprogBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lecprogBtn.UseVisualStyleBackColor = false;
            this.lecprogBtn.Click += new System.EventHandler(this.lecprogBtn_Click);
            // 
            // leclevelBtn
            // 
            this.leclevelBtn.BackColor = System.Drawing.Color.White;
            this.leclevelBtn.BorderColor = System.Drawing.Color.Black;
            this.leclevelBtn.ButtonColor = System.Drawing.Color.White;
            this.leclevelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.leclevelBtn.FlatAppearance.BorderSize = 0;
            this.leclevelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.leclevelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.leclevelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leclevelBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leclevelBtn.ForeColor = System.Drawing.Color.Black;
            this.leclevelBtn.Location = new System.Drawing.Point(13, 101);
            this.leclevelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.leclevelBtn.Name = "leclevelBtn";
            this.leclevelBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.leclevelBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.leclevelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.leclevelBtn.Size = new System.Drawing.Size(329, 54);
            this.leclevelBtn.TabIndex = 28;
            this.leclevelBtn.Text = "Level wise Lecturers Count ";
            this.leclevelBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.leclevelBtn.UseVisualStyleBackColor = false;
            this.leclevelBtn.Click += new System.EventHandler(this.leclevelBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(13, 11);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 27;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistics Related to Lecturers";
            // 
            // statLecturersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statLecturerspanel);
            this.Name = "statLecturersUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.statLecturerspanel.ResumeLayout(false);
            this.statLecturerspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statLecturerspanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private ePOSOne.btnProduct.Button_WOC leclevelBtn;
        private ePOSOne.btnProduct.Button_WOC lecprogBtn;
        private System.Windows.Forms.Panel lecgraphpanel;
    }
}
