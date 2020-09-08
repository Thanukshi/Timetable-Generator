namespace NewTimeApp.UserControlers
{
    partial class statisticsUC
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
            this.statpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // statpanel
            // 
            this.statpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statpanel.Location = new System.Drawing.Point(0, 0);
            this.statpanel.Name = "statpanel";
            this.statpanel.Size = new System.Drawing.Size(772, 720);
            this.statpanel.TabIndex = 0;
            // 
            // statisticsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statpanel);
            this.Name = "statisticsUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statpanel;
    }
}
