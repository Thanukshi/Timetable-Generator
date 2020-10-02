namespace NewTimeApp.UserControlers
{
    partial class ReservedRoomUC
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
            this.AddTimeForRoompanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTimeForRoompanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTimeForRoompanel
            // 
            this.AddTimeForRoompanel.Controls.Add(this.label1);
            this.AddTimeForRoompanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTimeForRoompanel.Location = new System.Drawing.Point(0, 0);
            this.AddTimeForRoompanel.Name = "AddTimeForRoompanel";
            this.AddTimeForRoompanel.Size = new System.Drawing.Size(772, 720);
            this.AddTimeForRoompanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 35);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add time ";
            // 
            // ReservedRoomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddTimeForRoompanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ReservedRoomUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.AddTimeForRoompanel.ResumeLayout(false);
            this.AddTimeForRoompanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddTimeForRoompanel;
        private System.Windows.Forms.Label label1;
    }
}
