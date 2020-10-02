namespace NewTimeApp.UserControlers
{
    partial class showroomUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showroomUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showRoomPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.roomAddBtn = new ePOSOne.btnProduct.Button_WOC();
            this.showRoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rooms";
            // 
            // showRoomPanel
            // 
            this.showRoomPanel.BackColor = System.Drawing.Color.White;
            this.showRoomPanel.Controls.Add(this.button_WOC1);
            this.showRoomPanel.Controls.Add(this.roomAddBtn);
            this.showRoomPanel.Controls.Add(this.dataGridView2);
            this.showRoomPanel.Controls.Add(this.backBtn);
            this.showRoomPanel.Controls.Add(this.label1);
            this.showRoomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showRoomPanel.Location = new System.Drawing.Point(0, 0);
            this.showRoomPanel.Name = "showRoomPanel";
            this.showRoomPanel.Size = new System.Drawing.Size(772, 720);
            this.showRoomPanel.TabIndex = 2;
            this.showRoomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showRoomPanel_Paint);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(40, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(564, 221);
            this.dataGridView2.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "roomID";
            this.Column1.HeaderText = "Room Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "buildingName";
            this.Column2.HeaderText = "Building Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "roomName";
            this.Column3.HeaderText = "Room Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "roomType";
            this.Column4.HeaderText = "Room Type";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "capacity";
            this.Column5.HeaderText = "Capacity";
            this.Column5.Name = "Column5";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.White;
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Black;
            this.button_WOC1.Location = new System.Drawing.Point(477, 461);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(2);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(161, 54);
            this.button_WOC1.TabIndex = 29;
            this.button_WOC1.Text = "DELETE";
            this.button_WOC1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_WOC1.UseVisualStyleBackColor = false;
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
            this.roomAddBtn.Location = new System.Drawing.Point(102, 461);
            this.roomAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.roomAddBtn.Name = "roomAddBtn";
            this.roomAddBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.roomAddBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roomAddBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.roomAddBtn.Size = new System.Drawing.Size(161, 54);
            this.roomAddBtn.TabIndex = 28;
            this.roomAddBtn.Text = "UPDATE";
            this.roomAddBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.roomAddBtn.UseVisualStyleBackColor = false;
            // 
            // showroomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showRoomPanel);
            this.Name = "showroomUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.Load += new System.EventHandler(this.showroomUC_Load);
            this.showRoomPanel.ResumeLayout(false);
            this.showRoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel showRoomPanel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC roomAddBtn;
    }
}
