namespace NewTimeApp.UserControlers
{
    partial class viewbuildingsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewbuildingsUC));
            this.viewbuildingpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.viewbuildingDGV = new System.Windows.Forms.DataGridView();
            this.buildingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewbuildingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewbuildingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // viewbuildingpanel
            // 
            this.viewbuildingpanel.Controls.Add(this.viewbuildingDGV);
            this.viewbuildingpanel.Controls.Add(this.backBtn);
            this.viewbuildingpanel.Controls.Add(this.label1);
            this.viewbuildingpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewbuildingpanel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbuildingpanel.Location = new System.Drawing.Point(0, 0);
            this.viewbuildingpanel.Name = "viewbuildingpanel";
            this.viewbuildingpanel.Size = new System.Drawing.Size(772, 720);
            this.viewbuildingpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(99, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buildings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(14, 24);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 31;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // viewbuildingDGV
            // 
            this.viewbuildingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewbuildingDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingID,
            this.buildingName});
            this.viewbuildingDGV.Location = new System.Drawing.Point(38, 199);
            this.viewbuildingDGV.Name = "viewbuildingDGV";
            this.viewbuildingDGV.Size = new System.Drawing.Size(674, 352);
            this.viewbuildingDGV.TabIndex = 32;
            // 
            // buildingID
            // 
            this.buildingID.HeaderText = "Building ID";
            this.buildingID.Name = "buildingID";
            // 
            // buildingName
            // 
            this.buildingName.HeaderText = "Building Name";
            this.buildingName.Name = "buildingName";
            // 
            // viewbuildingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.viewbuildingpanel);
            this.Name = "viewbuildingsUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.viewbuildingpanel.ResumeLayout(false);
            this.viewbuildingpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewbuildingDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewbuildingpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView viewbuildingDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingName;
    }
}
