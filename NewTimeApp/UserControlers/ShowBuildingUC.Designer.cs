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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBuildingUC));
            this.showBuildingPanel = new System.Windows.Forms.Panel();
            this.BuildingDeleteBtn = new ePOSOne.btnProduct.Button_WOC();
            this.BuildingUpBtn = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buildingNameTB = new System.Windows.Forms.TextBox();
            this.showBuildingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showBuildingPanel
            // 
            this.showBuildingPanel.BackColor = System.Drawing.Color.White;
            this.showBuildingPanel.Controls.Add(this.buildingNameTB);
            this.showBuildingPanel.Controls.Add(this.label2);
            this.showBuildingPanel.Controls.Add(this.BuildingDeleteBtn);
            this.showBuildingPanel.Controls.Add(this.BuildingUpBtn);
            this.showBuildingPanel.Controls.Add(this.dataGridView1);
            this.showBuildingPanel.Controls.Add(this.backBtn);
            this.showBuildingPanel.Controls.Add(this.label1);
            this.showBuildingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showBuildingPanel.Location = new System.Drawing.Point(0, 0);
            this.showBuildingPanel.Name = "showBuildingPanel";
            this.showBuildingPanel.Size = new System.Drawing.Size(772, 720);
            this.showBuildingPanel.TabIndex = 1;
            this.showBuildingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showBuildingPanel_Paint);
            // 
            // BuildingDeleteBtn
            // 
            this.BuildingDeleteBtn.BackColor = System.Drawing.Color.White;
            this.BuildingDeleteBtn.BorderColor = System.Drawing.Color.Black;
            this.BuildingDeleteBtn.ButtonColor = System.Drawing.Color.White;
            this.BuildingDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BuildingDeleteBtn.FlatAppearance.BorderSize = 0;
            this.BuildingDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BuildingDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BuildingDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildingDeleteBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingDeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.BuildingDeleteBtn.Location = new System.Drawing.Point(501, 564);
            this.BuildingDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuildingDeleteBtn.Name = "BuildingDeleteBtn";
            this.BuildingDeleteBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.BuildingDeleteBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BuildingDeleteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BuildingDeleteBtn.Size = new System.Drawing.Size(161, 54);
            this.BuildingDeleteBtn.TabIndex = 30;
            this.BuildingDeleteBtn.Text = "DELETE";
            this.BuildingDeleteBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BuildingDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // BuildingUpBtn
            // 
            this.BuildingUpBtn.BackColor = System.Drawing.Color.White;
            this.BuildingUpBtn.BorderColor = System.Drawing.Color.Black;
            this.BuildingUpBtn.ButtonColor = System.Drawing.Color.White;
            this.BuildingUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BuildingUpBtn.FlatAppearance.BorderSize = 0;
            this.BuildingUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BuildingUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BuildingUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildingUpBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingUpBtn.ForeColor = System.Drawing.Color.Black;
            this.BuildingUpBtn.Location = new System.Drawing.Point(111, 564);
            this.BuildingUpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuildingUpBtn.Name = "BuildingUpBtn";
            this.BuildingUpBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.BuildingUpBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BuildingUpBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BuildingUpBtn.Size = new System.Drawing.Size(161, 54);
            this.BuildingUpBtn.TabIndex = 29;
            this.BuildingUpBtn.Text = "UPDATE";
            this.BuildingUpBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BuildingUpBtn.UseVisualStyleBackColor = false;
            this.BuildingUpBtn.Click += new System.EventHandler(this.BuildingUpBtn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(36, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 303);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "buildingName";
            this.Column2.HeaderText = "Building Name";
            this.Column2.Name = "Column2";
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
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buildings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(135, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "Building Name";
            // 
            // buildingNameTB
            // 
            this.buildingNameTB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameTB.Location = new System.Drawing.Point(325, 130);
            this.buildingNameTB.Multiline = true;
            this.buildingNameTB.Name = "buildingNameTB";
            this.buildingNameTB.Size = new System.Drawing.Size(337, 44);
            this.buildingNameTB.TabIndex = 32;
            // 
            // ShowBuildingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showBuildingPanel);
            this.Name = "ShowBuildingUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.Load += new System.EventHandler(this.ShowBuildingUC_Load);
            this.showBuildingPanel.ResumeLayout(false);
            this.showBuildingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showBuildingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ePOSOne.btnProduct.Button_WOC BuildingUpBtn;
        private ePOSOne.btnProduct.Button_WOC BuildingDeleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buildingNameTB;
    }
}
