namespace NewTimeApp.UserControlers
{
    partial class TagUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagUC));
            this.tagpanel1 = new System.Windows.Forms.Panel();
            this.tagname = new System.Windows.Forms.TextBox();
            this.saveAcademic = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ebtn = new ePOSOne.btnProduct.Button_WOC();
            this.tagpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagpanel1
            // 
            this.tagpanel1.Controls.Add(this.ebtn);
            this.tagpanel1.Controls.Add(this.tagname);
            this.tagpanel1.Controls.Add(this.saveAcademic);
            this.tagpanel1.Controls.Add(this.label2);
            this.tagpanel1.Controls.Add(this.backBtn);
            this.tagpanel1.Controls.Add(this.label1);
            this.tagpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagpanel1.Location = new System.Drawing.Point(0, 0);
            this.tagpanel1.Name = "tagpanel1";
            this.tagpanel1.Size = new System.Drawing.Size(1000, 790);
            this.tagpanel1.TabIndex = 0;
            // 
            // tagname
            // 
            this.tagname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tagname.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.tagname.Location = new System.Drawing.Point(423, 254);
            this.tagname.Multiline = true;
            this.tagname.Name = "tagname";
            this.tagname.Size = new System.Drawing.Size(470, 45);
            this.tagname.TabIndex = 34;
            // 
            // saveAcademic
            // 
            this.saveAcademic.BackColor = System.Drawing.Color.White;
            this.saveAcademic.BorderColor = System.Drawing.Color.Black;
            this.saveAcademic.ButtonColor = System.Drawing.Color.White;
            this.saveAcademic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveAcademic.FlatAppearance.BorderSize = 0;
            this.saveAcademic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveAcademic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveAcademic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAcademic.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAcademic.ForeColor = System.Drawing.Color.Black;
            this.saveAcademic.Location = new System.Drawing.Point(476, 455);
            this.saveAcademic.Name = "saveAcademic";
            this.saveAcademic.OnHoverBorderColor = System.Drawing.Color.White;
            this.saveAcademic.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saveAcademic.OnHoverTextColor = System.Drawing.Color.White;
            this.saveAcademic.Size = new System.Drawing.Size(417, 67);
            this.saveAcademic.TabIndex = 30;
            this.saveAcademic.Text = "Save";
            this.saveAcademic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveAcademic.UseVisualStyleBackColor = false;
            this.saveAcademic.Click += new System.EventHandler(this.saveAcademic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(107, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 38);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tag";
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(62, 30);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(66, 56);
            this.backBtn.TabIndex = 27;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 26;
            this.label1.Text = "Academic Details";
            // 
            // ebtn
            // 
            this.ebtn.BackColor = System.Drawing.Color.White;
            this.ebtn.BorderColor = System.Drawing.Color.Black;
            this.ebtn.ButtonColor = System.Drawing.Color.White;
            this.ebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ebtn.FlatAppearance.BorderSize = 0;
            this.ebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ebtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebtn.ForeColor = System.Drawing.Color.Black;
            this.ebtn.Location = new System.Drawing.Point(476, 567);
            this.ebtn.Name = "ebtn";
            this.ebtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.ebtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ebtn.Size = new System.Drawing.Size(417, 67);
            this.ebtn.TabIndex = 35;
            this.ebtn.Text = "Edit";
            this.ebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ebtn.UseVisualStyleBackColor = false;
            this.ebtn.Click += new System.EventHandler(this.ebtn_Click);
            // 
            // TagUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tagpanel1);
            this.Name = "TagUC";
            this.Size = new System.Drawing.Size(1000, 790);
            this.tagpanel1.ResumeLayout(false);
            this.tagpanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tagpanel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC saveAcademic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagname;
        private ePOSOne.btnProduct.Button_WOC ebtn;
    }
}
