namespace NewTimeApp.UserControlers
{
    partial class lectureUC
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
            this.addLec = new System.Windows.Forms.Button();
            this.viewLec = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.lecPanel = new System.Windows.Forms.Panel();
            this.lecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLec
            // 
            this.addLec.BackColor = System.Drawing.Color.Purple;
            //this.addLec.Image = global::NewTimeApp.Properties.Resources.add_user_2_64;
            this.addLec.Location = new System.Drawing.Point(114, 266);
            this.addLec.Name = "addLec";
            this.addLec.Size = new System.Drawing.Size(119, 111);
            this.addLec.TabIndex = 10;
            this.addLec.UseVisualStyleBackColor = false;
            this.addLec.Click += new System.EventHandler(this.addLec_Click);
            // 
            // viewLec
            // 
            this.viewLec.BackColor = System.Drawing.Color.Purple;
            //this.viewLec.Image = global::NewTimeApp.Properties.Resources.conference_64;
            this.viewLec.Location = new System.Drawing.Point(510, 266);
            this.viewLec.Name = "viewLec";
            this.viewLec.Size = new System.Drawing.Size(119, 111);
            this.viewLec.TabIndex = 11;
            this.viewLec.UseVisualStyleBackColor = false;
            this.viewLec.Click += new System.EventHandler(this.viewLec_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Purple;
            //this.update.Image = global::NewTimeApp.Properties.Resources.add_user_2_64;
            this.update.Location = new System.Drawing.Point(317, 467);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 111);
            this.update.TabIndex = 12;
            this.update.UseVisualStyleBackColor = false;
            // 
            // lecPanel
            // 
            this.lecPanel.BackColor = System.Drawing.Color.White;
            this.lecPanel.Controls.Add(this.update);
            this.lecPanel.Controls.Add(this.viewLec);
            this.lecPanel.Controls.Add(this.addLec);
            this.lecPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecPanel.Location = new System.Drawing.Point(0, 0);
            this.lecPanel.Name = "lecPanel";
            this.lecPanel.Size = new System.Drawing.Size(772, 720);
            this.lecPanel.TabIndex = 0;
            // 
            // lectureUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lecPanel);
            this.Name = "lectureUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.lecPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addLec;
        private System.Windows.Forms.Button viewLec;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Panel lecPanel;
    }
}
