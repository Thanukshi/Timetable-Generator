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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBuildingUC));
            this.showBuildingPanel = new System.Windows.Forms.Panel();
            this.BuildingDeleteBtn = new ePOSOne.btnProduct.Button_WOC();
            this.BuildingUpBtn = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showBuildingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showBuildingPanel
            // 
            this.showBuildingPanel.BackColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
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
    }
}
