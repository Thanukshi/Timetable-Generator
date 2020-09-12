namespace NewTimeApp
{
    partial class ShowBuildinUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBuildinUC));
            this.showBuldingPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showroompanel = new System.Windows.Forms.Panel();
            this.showBuldingPanel.SuspendLayout();
            this.showroompanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showBuldingPanel
            // 
            this.showBuldingPanel.BackColor = System.Drawing.Color.White;
            this.showBuldingPanel.Controls.Add(this.showroompanel);
            this.showBuldingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showBuldingPanel.Location = new System.Drawing.Point(0, 0);
            this.showBuldingPanel.Name = "showBuldingPanel";
            this.showBuldingPanel.Size = new System.Drawing.Size(772, 720);
            this.showBuldingPanel.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(21, 19);
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
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rooms";
            // 
            // showroompanel
            // 
            this.showroompanel.Controls.Add(this.backBtn);
            this.showroompanel.Controls.Add(this.label1);
            this.showroompanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showroompanel.Location = new System.Drawing.Point(0, 0);
            this.showroompanel.Name = "showroompanel";
            this.showroompanel.Size = new System.Drawing.Size(772, 720);
            this.showroompanel.TabIndex = 1;
            // 
            // ShowBuildinUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showBuldingPanel);
            this.Name = "ShowBuildinUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.showBuldingPanel.ResumeLayout(false);
            this.showroompanel.ResumeLayout(false);
            this.showroompanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showBuldingPanel;
        private System.Windows.Forms.Panel showroompanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
    }
}
