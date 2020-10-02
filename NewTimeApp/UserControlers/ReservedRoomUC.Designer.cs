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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservedRoomUC));
            this.AddTimeForRoompanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.AddReservedTimeBtn = new ePOSOne.btnProduct.Button_WOC();
            this.AddTimeForRoompanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTimeForRoompanel
            // 
            this.AddTimeForRoompanel.Controls.Add(this.AddReservedTimeBtn);
            this.AddTimeForRoompanel.Controls.Add(this.timeTB);
            this.AddTimeForRoompanel.Controls.Add(this.label2);
            this.AddTimeForRoompanel.Controls.Add(this.RoomNameTB);
            this.AddTimeForRoompanel.Controls.Add(this.label3);
            this.AddTimeForRoompanel.Controls.Add(this.backBtn);
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
            this.label1.Location = new System.Drawing.Point(92, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 35);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add Reserved Time For Room ";
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(16, 28);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 31;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(177, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Room Name";
            // 
            // RoomNameTB
            // 
            this.RoomNameTB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNameTB.Location = new System.Drawing.Point(336, 190);
            this.RoomNameTB.Multiline = true;
            this.RoomNameTB.Name = "RoomNameTB";
            this.RoomNameTB.Size = new System.Drawing.Size(310, 40);
            this.RoomNameTB.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(177, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 30);
            this.label2.TabIndex = 41;
            this.label2.Text = "Time";
            // 
            // timeTB
            // 
            this.timeTB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTB.Location = new System.Drawing.Point(336, 275);
            this.timeTB.Multiline = true;
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(310, 40);
            this.timeTB.TabIndex = 42;
            // 
            // AddReservedTimeBtn
            // 
            this.AddReservedTimeBtn.BackColor = System.Drawing.Color.White;
            this.AddReservedTimeBtn.BorderColor = System.Drawing.Color.Black;
            this.AddReservedTimeBtn.ButtonColor = System.Drawing.Color.White;
            this.AddReservedTimeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddReservedTimeBtn.FlatAppearance.BorderSize = 0;
            this.AddReservedTimeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddReservedTimeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddReservedTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReservedTimeBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddReservedTimeBtn.ForeColor = System.Drawing.Color.Black;
            this.AddReservedTimeBtn.Location = new System.Drawing.Point(302, 410);
            this.AddReservedTimeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddReservedTimeBtn.Name = "AddReservedTimeBtn";
            this.AddReservedTimeBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.AddReservedTimeBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddReservedTimeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddReservedTimeBtn.Size = new System.Drawing.Size(161, 54);
            this.AddReservedTimeBtn.TabIndex = 43;
            this.AddReservedTimeBtn.Text = "ADD ";
            this.AddReservedTimeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddReservedTimeBtn.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomNameTB;
        private ePOSOne.btnProduct.Button_WOC AddReservedTimeBtn;
    }
}
