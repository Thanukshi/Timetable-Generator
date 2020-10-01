namespace NewTimeApp.UserControlers
{
    partial class roomUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomUC));
            this.roompanel = new System.Windows.Forms.Panel();
            this.roomAddBtn = new ePOSOne.btnProduct.Button_WOC();
            this.backBtn = new System.Windows.Forms.Button();
            this.capacityCB = new System.Windows.Forms.ComboBox();
            this.RoomNameTB = new System.Windows.Forms.TextBox();
            this.RoomTypeTB = new System.Windows.Forms.ComboBox();
            this.buildingNameCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.roompanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roompanel
            // 
            this.roompanel.BackColor = System.Drawing.Color.White;
            this.roompanel.Controls.Add(this.button_WOC1);
            this.roompanel.Controls.Add(this.roomAddBtn);
            this.roompanel.Controls.Add(this.backBtn);
            this.roompanel.Controls.Add(this.capacityCB);
            this.roompanel.Controls.Add(this.RoomNameTB);
            this.roompanel.Controls.Add(this.RoomTypeTB);
            this.roompanel.Controls.Add(this.buildingNameCB);
            this.roompanel.Controls.Add(this.label5);
            this.roompanel.Controls.Add(this.label4);
            this.roompanel.Controls.Add(this.label3);
            this.roompanel.Controls.Add(this.label2);
            this.roompanel.Controls.Add(this.label1);
            this.roompanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roompanel.Location = new System.Drawing.Point(0, 0);
            this.roompanel.Name = "roompanel";
            this.roompanel.Size = new System.Drawing.Size(772, 720);
            this.roompanel.TabIndex = 0;
            // 
            // roomAddBtn
            // 
            this.roomAddBtn.BackColor = System.Drawing.Color.White;
            this.roomAddBtn.BorderColor = System.Drawing.Color.Black;
            this.roomAddBtn.ButtonColor = System.Drawing.Color.White;
            this.roomAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roomAddBtn.FlatAppearance.BorderSize = 0;
            this.roomAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.roomAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.roomAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomAddBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomAddBtn.ForeColor = System.Drawing.Color.Black;
            this.roomAddBtn.Location = new System.Drawing.Point(317, 470);
            this.roomAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.roomAddBtn.Name = "roomAddBtn";
            this.roomAddBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.roomAddBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roomAddBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.roomAddBtn.Size = new System.Drawing.Size(161, 54);
            this.roomAddBtn.TabIndex = 26;
            this.roomAddBtn.Text = "ADD ROOM";
            this.roomAddBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.roomAddBtn.UseVisualStyleBackColor = false;
            this.roomAddBtn.Click += new System.EventHandler(this.roomAddBtn_Click);
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
            this.backBtn.TabIndex = 25;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // capacityCB
            // 
            this.capacityCB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityCB.FormattingEnabled = true;
            this.capacityCB.Items.AddRange(new object[] {
            "60",
            "120",
            "240"});
            this.capacityCB.Location = new System.Drawing.Point(305, 389);
            this.capacityCB.Name = "capacityCB";
            this.capacityCB.Size = new System.Drawing.Size(310, 38);
            this.capacityCB.TabIndex = 9;
            // 
            // RoomNameTB
            // 
            this.RoomNameTB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNameTB.Location = new System.Drawing.Point(305, 211);
            this.RoomNameTB.Multiline = true;
            this.RoomNameTB.Name = "RoomNameTB";
            this.RoomNameTB.Size = new System.Drawing.Size(310, 30);
            this.RoomNameTB.TabIndex = 8;
            // 
            // RoomTypeTB
            // 
            this.RoomTypeTB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeTB.FormattingEnabled = true;
            this.RoomTypeTB.Items.AddRange(new object[] {
            "Lecture hall",
            "Lab"});
            this.RoomTypeTB.Location = new System.Drawing.Point(305, 294);
            this.RoomTypeTB.Name = "RoomTypeTB";
            this.RoomTypeTB.Size = new System.Drawing.Size(310, 38);
            this.RoomTypeTB.TabIndex = 7;
            this.RoomTypeTB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buildingNameCB
            // 
            this.buildingNameCB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameCB.FormattingEnabled = true;
            this.buildingNameCB.Location = new System.Drawing.Point(305, 129);
            this.buildingNameCB.Name = "buildingNameCB";
            this.buildingNameCB.Size = new System.Drawing.Size(310, 38);
            this.buildingNameCB.TabIndex = 6;
            this.buildingNameCB.SelectedIndexChanged += new System.EventHandler(this.buildingNameCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(107, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(107, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(107, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(107, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Building Name";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC1.Location = new System.Drawing.Point(0, 0);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(75, 23);
            this.button_WOC1.TabIndex = 27;
            this.button_WOC1.Text = "button_WOC1";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // roomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roompanel);
            this.Name = "roomUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.roompanel.ResumeLayout(false);
            this.roompanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roompanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoomNameTB;
        private System.Windows.Forms.ComboBox RoomTypeTB;
        private System.Windows.Forms.ComboBox buildingNameCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox capacityCB;
        private System.Windows.Forms.Button backBtn;
        private ePOSOne.btnProduct.Button_WOC roomAddBtn;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}
