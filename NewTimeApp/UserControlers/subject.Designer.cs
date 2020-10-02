namespace NewTimeApp.UserControlers
{
    partial class subject
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
            this.panelsubb = new System.Windows.Forms.Panel();
            this.buttonaddsub = new System.Windows.Forms.Button();
            this.buttonviewsub = new System.Windows.Forms.Button();
            this.panelsubb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsubje
            // 
            this.panelsubb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelsubb.Controls.Add(this.buttonviewsub);
            this.panelsubb.Controls.Add(this.buttonaddsub);
            this.panelsubb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsubb.Location = new System.Drawing.Point(0, 0);
            this.panelsubb.Name = "panelsubje";
            this.panelsubb.Size = new System.Drawing.Size(750, 642);
            this.panelsubb.TabIndex = 0;
            this.panelsubb.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonaddsub
            // 
            this.buttonaddsub.BackColor = System.Drawing.Color.Purple;
            //this.buttonaddsub.BackgroundImage = global::NewTimeApp.Properties.Resources.book_stack_64;
            this.buttonaddsub.Location = new System.Drawing.Point(87, 165);
            this.buttonaddsub.Name = "buttonaddsub";
            this.buttonaddsub.Size = new System.Drawing.Size(136, 125);
            this.buttonaddsub.TabIndex = 0;
            this.buttonaddsub.UseVisualStyleBackColor = false;
            this.buttonaddsub.Click += new System.EventHandler(this.buttonaddsub_Click);
            // 
            // buttonviewsub
            // 
            this.buttonviewsub.BackColor = System.Drawing.Color.Purple;
            //this.buttonviewsub.BackgroundImage = global::NewTimeApp.Properties.Resources.view_details_64;
            this.buttonviewsub.Location = new System.Drawing.Point(492, 165);
            this.buttonviewsub.Name = "buttonviewsub";
            this.buttonviewsub.Size = new System.Drawing.Size(136, 125);
            this.buttonviewsub.TabIndex = 1;
            this.buttonviewsub.UseVisualStyleBackColor = false;
            this.buttonviewsub.Click += new System.EventHandler(this.buttonviewsub_Click);
            // 
            // subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelsubb);
            this.Name = "subject";
            this.Size = new System.Drawing.Size(750, 642);
            this.panelsubb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsubb;
        private System.Windows.Forms.Button buttonviewsub;
        private System.Windows.Forms.Button buttonaddsub;
    }
}
