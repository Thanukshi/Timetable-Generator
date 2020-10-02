namespace NewTimeApp.UserControlers
{
    partial class AddRoomSessionsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoomSessionsUC));
            this.RoomSessionPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SessionRoomCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNameSessionTB = new System.Windows.Forms.TextBox();
            this.AddSessionRoomBtn = new ePOSOne.btnProduct.Button_WOC();
            this.RoomSessionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomSessionPanel
            // 
            this.RoomSessionPanel.Controls.Add(this.AddSessionRoomBtn);
            this.RoomSessionPanel.Controls.Add(this.roomNameSessionTB);
            this.RoomSessionPanel.Controls.Add(this.label4);
            this.RoomSessionPanel.Controls.Add(this.SessionRoomCB);
            this.RoomSessionPanel.Controls.Add(this.label2);
            this.RoomSessionPanel.Controls.Add(this.label1);
            this.RoomSessionPanel.Controls.Add(this.backBtn);
            this.RoomSessionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomSessionPanel.Location = new System.Drawing.Point(0, 0);
            this.RoomSessionPanel.Name = "RoomSessionPanel";
            this.RoomSessionPanel.Size = new System.Drawing.Size(772, 720);
            this.RoomSessionPanel.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(22, 35);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 28;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add Rooms for Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(154, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Session";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SessionRoomCB
            // 
            this.SessionRoomCB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionRoomCB.FormattingEnabled = true;
            this.SessionRoomCB.Location = new System.Drawing.Point(312, 177);
            this.SessionRoomCB.Name = "SessionRoomCB";
            this.SessionRoomCB.Size = new System.Drawing.Size(310, 38);
            this.SessionRoomCB.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(154, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Room Name";
            // 
            // roomNameSessionTB
            // 
            this.roomNameSessionTB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameSessionTB.Location = new System.Drawing.Point(312, 280);
            this.roomNameSessionTB.Multiline = true;
            this.roomNameSessionTB.Name = "roomNameSessionTB";
            this.roomNameSessionTB.Size = new System.Drawing.Size(310, 40);
            this.roomNameSessionTB.TabIndex = 35;
            // 
            // AddSessionRoomBtn
            // 
            this.AddSessionRoomBtn.BackColor = System.Drawing.Color.White;
            this.AddSessionRoomBtn.BorderColor = System.Drawing.Color.Black;
            this.AddSessionRoomBtn.ButtonColor = System.Drawing.Color.White;
            this.AddSessionRoomBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddSessionRoomBtn.FlatAppearance.BorderSize = 0;
            this.AddSessionRoomBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddSessionRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddSessionRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionRoomBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSessionRoomBtn.ForeColor = System.Drawing.Color.Black;
            this.AddSessionRoomBtn.Location = new System.Drawing.Point(302, 440);
            this.AddSessionRoomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddSessionRoomBtn.Name = "AddSessionRoomBtn";
            this.AddSessionRoomBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.AddSessionRoomBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddSessionRoomBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddSessionRoomBtn.Size = new System.Drawing.Size(161, 54);
            this.AddSessionRoomBtn.TabIndex = 36;
            this.AddSessionRoomBtn.Text = "ADD ";
            this.AddSessionRoomBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddSessionRoomBtn.UseVisualStyleBackColor = false;
            // 
            // AddRoomSessionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RoomSessionPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddRoomSessionsUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.RoomSessionPanel.ResumeLayout(false);
            this.RoomSessionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RoomSessionPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SessionRoomCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomNameSessionTB;
        private ePOSOne.btnProduct.Button_WOC AddSessionRoomBtn;
    }
}
