namespace NewTimeApp.UserControlers
{
    partial class ShowBuildingUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBuildingUC));
            this.showBuildingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.showBuildingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showBuildingPanel
            // 
            this.showBuildingPanel.BackColor = System.Drawing.Color.White;
            this.showBuildingPanel.Controls.Add(this.backBtn);
            this.showBuildingPanel.Controls.Add(this.label1);
            this.showBuildingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showBuildingPanel.Location = new System.Drawing.Point(0, 0);
            this.showBuildingPanel.Name = "showBuildingPanel";
            this.showBuildingPanel.Size = new System.Drawing.Size(772, 720);
            this.showBuildingPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Room Details";
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(17, 29);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 26;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ShowBuildingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showBuildingPanel);
            this.Name = "ShowBuildingUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.showBuildingPanel.ResumeLayout(false);
            this.showBuildingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showBuildingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
    }
}
