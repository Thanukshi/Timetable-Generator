namespace NewTimeApp.UserControlers
{
    partial class RoomAllocationUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomAllocationUC));
            this.RoomAllocationPanel = new System.Windows.Forms.Panel();
            this.PreRoomBtn = new NewTimeApp.CircularButton();
            this.sutRoomBtn = new NewTimeApp.CircularButton();
            this.sessConRBtn = new NewTimeApp.CircularButton();
            this.LecGroupRBtn = new NewTimeApp.CircularButton();
            this.TimeRoomBtn = new NewTimeApp.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoomAllocationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomAllocationPanel
            // 
            this.RoomAllocationPanel.Controls.Add(this.PreRoomBtn);
            this.RoomAllocationPanel.Controls.Add(this.sutRoomBtn);
            this.RoomAllocationPanel.Controls.Add(this.sessConRBtn);
            this.RoomAllocationPanel.Controls.Add(this.LecGroupRBtn);
            this.RoomAllocationPanel.Controls.Add(this.TimeRoomBtn);
            this.RoomAllocationPanel.Controls.Add(this.pictureBox1);
            this.RoomAllocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomAllocationPanel.Location = new System.Drawing.Point(0, 0);
            this.RoomAllocationPanel.Name = "RoomAllocationPanel";
            this.RoomAllocationPanel.Size = new System.Drawing.Size(772, 720);
            this.RoomAllocationPanel.TabIndex = 0;
            // 
            // PreRoomBtn
            // 
            this.PreRoomBtn.BackColor = System.Drawing.Color.Plum;
            this.PreRoomBtn.FlatAppearance.BorderSize = 0;
            this.PreRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.PreRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreRoomBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreRoomBtn.ForeColor = System.Drawing.Color.White;
            this.PreRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("PreRoomBtn.Image")));
            this.PreRoomBtn.Location = new System.Drawing.Point(524, 56);
            this.PreRoomBtn.Name = "PreRoomBtn";
            this.PreRoomBtn.Size = new System.Drawing.Size(170, 170);
            this.PreRoomBtn.TabIndex = 42;
            this.PreRoomBtn.Text = "Add Preferred Room ";
            this.PreRoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PreRoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PreRoomBtn.UseVisualStyleBackColor = false;
            this.PreRoomBtn.Click += new System.EventHandler(this.PreRoomBtn_Click);
            // 
            // sutRoomBtn
            // 
            this.sutRoomBtn.BackColor = System.Drawing.Color.Plum;
            this.sutRoomBtn.FlatAppearance.BorderSize = 0;
            this.sutRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.sutRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sutRoomBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sutRoomBtn.ForeColor = System.Drawing.Color.White;
            this.sutRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("sutRoomBtn.Image")));
            this.sutRoomBtn.Location = new System.Drawing.Point(59, 56);
            this.sutRoomBtn.Name = "sutRoomBtn";
            this.sutRoomBtn.Size = new System.Drawing.Size(170, 170);
            this.sutRoomBtn.TabIndex = 41;
            this.sutRoomBtn.Text = "Add Suitable Room";
            this.sutRoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sutRoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sutRoomBtn.UseVisualStyleBackColor = false;
            this.sutRoomBtn.Click += new System.EventHandler(this.sutRoomBtn_Click);
            // 
            // sessConRBtn
            // 
            this.sessConRBtn.BackColor = System.Drawing.Color.Plum;
            this.sessConRBtn.FlatAppearance.BorderSize = 0;
            this.sessConRBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.sessConRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sessConRBtn.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessConRBtn.ForeColor = System.Drawing.Color.White;
            this.sessConRBtn.Image = ((System.Drawing.Image)(resources.GetObject("sessConRBtn.Image")));
            this.sessConRBtn.Location = new System.Drawing.Point(524, 428);
            this.sessConRBtn.Name = "sessConRBtn";
            this.sessConRBtn.Size = new System.Drawing.Size(170, 170);
            this.sessConRBtn.TabIndex = 40;
            this.sessConRBtn.Text = "Add Rooms for Session And Consecutive Sessions";
            this.sessConRBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sessConRBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sessConRBtn.UseVisualStyleBackColor = false;
            this.sessConRBtn.Click += new System.EventHandler(this.sessConRBtn_Click);
            // 
            // LecGroupRBtn
            // 
            this.LecGroupRBtn.BackColor = System.Drawing.Color.Plum;
            this.LecGroupRBtn.FlatAppearance.BorderSize = 0;
            this.LecGroupRBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.LecGroupRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LecGroupRBtn.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecGroupRBtn.ForeColor = System.Drawing.Color.White;
            this.LecGroupRBtn.Image = ((System.Drawing.Image)(resources.GetObject("LecGroupRBtn.Image")));
            this.LecGroupRBtn.Location = new System.Drawing.Point(59, 428);
            this.LecGroupRBtn.Name = "LecGroupRBtn";
            this.LecGroupRBtn.Size = new System.Drawing.Size(170, 170);
            this.LecGroupRBtn.TabIndex = 39;
            this.LecGroupRBtn.Text = "Add Rooms for Lecturers and Group or Sub Group ";
            this.LecGroupRBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LecGroupRBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LecGroupRBtn.UseVisualStyleBackColor = false;
            this.LecGroupRBtn.Click += new System.EventHandler(this.LecGroupRBtn_Click);
            // 
            // TimeRoomBtn
            // 
            this.TimeRoomBtn.BackColor = System.Drawing.Color.Plum;
            this.TimeRoomBtn.FlatAppearance.BorderSize = 0;
            this.TimeRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.TimeRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeRoomBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRoomBtn.ForeColor = System.Drawing.Color.White;
            this.TimeRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("TimeRoomBtn.Image")));
            this.TimeRoomBtn.Location = new System.Drawing.Point(291, 254);
            this.TimeRoomBtn.Name = "TimeRoomBtn";
            this.TimeRoomBtn.Size = new System.Drawing.Size(170, 170);
            this.TimeRoomBtn.TabIndex = 37;
            this.TimeRoomBtn.Text = "Add Reserved Time For Room ";
            this.TimeRoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TimeRoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TimeRoomBtn.UseVisualStyleBackColor = false;
            this.TimeRoomBtn.Click += new System.EventHandler(this.TimeRoomBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NewTimeApp.Properties.Resources.back1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RoomAllocationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RoomAllocationPanel);
            this.Name = "RoomAllocationUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.RoomAllocationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RoomAllocationPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton PreRoomBtn;
        private CircularButton sutRoomBtn;
        private CircularButton sessConRBtn;
        private CircularButton LecGroupRBtn;
        private CircularButton TimeRoomBtn;
    }
}
