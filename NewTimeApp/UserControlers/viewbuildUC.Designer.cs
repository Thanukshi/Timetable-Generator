namespace NewTimeApp.UserControlers
{
    partial class viewbuildUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewbuildUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewbuildpanel = new System.Windows.Forms.Panel();
            this.buldingAddBtn = new ePOSOne.btnProduct.Button_WOC();
            this.buildingDGV = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biuldingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewbuildpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // viewbuildpanel
            // 
            this.viewbuildpanel.Controls.Add(this.buldingAddBtn);
            this.viewbuildpanel.Controls.Add(this.buildingDGV);
            this.viewbuildpanel.Controls.Add(this.backBtn);
            this.viewbuildpanel.Controls.Add(this.label1);
            this.viewbuildpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewbuildpanel.Location = new System.Drawing.Point(0, 0);
            this.viewbuildpanel.Name = "viewbuildpanel";
            this.viewbuildpanel.Size = new System.Drawing.Size(772, 720);
            this.viewbuildpanel.TabIndex = 0;
            // 
            // buldingAddBtn
            // 
            this.buldingAddBtn.BackColor = System.Drawing.Color.White;
            this.buldingAddBtn.BorderColor = System.Drawing.Color.Black;
            this.buldingAddBtn.ButtonColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatAppearance.BorderSize = 0;
            this.buldingAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buldingAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buldingAddBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buldingAddBtn.ForeColor = System.Drawing.Color.Black;
            this.buldingAddBtn.Location = new System.Drawing.Point(267, 94);
            this.buldingAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.buldingAddBtn.Name = "buldingAddBtn";
            this.buldingAddBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.buldingAddBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buldingAddBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buldingAddBtn.Size = new System.Drawing.Size(227, 54);
            this.buldingAddBtn.TabIndex = 33;
            this.buldingAddBtn.Text = "VIEW BUILDING";
            this.buldingAddBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buldingAddBtn.UseVisualStyleBackColor = false;
            this.buldingAddBtn.Click += new System.EventHandler(this.buldingAddBtn_Click);
            // 
            // buildingDGV
            // 
            this.buildingDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buildingDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buildingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildingDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biuldingID,
            this.buildingName});
            this.buildingDGV.Location = new System.Drawing.Point(24, 168);
            this.buildingDGV.Name = "buildingDGV";
            this.buildingDGV.Size = new System.Drawing.Size(722, 373);
            this.buildingDGV.TabIndex = 32;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(24, 19);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 46);
            this.backBtn.TabIndex = 31;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buildings";
            // 
            // buildingName
            // 
            this.buildingName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.buildingName.DefaultCellStyle = dataGridViewCellStyle3;
            this.buildingName.HeaderText = "Building Name";
            this.buildingName.Name = "buildingName";
            // 
            // biuldingID
            // 
            this.biuldingID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.biuldingID.DefaultCellStyle = dataGridViewCellStyle2;
            this.biuldingID.HeaderText = "Building ID";
            this.biuldingID.Name = "biuldingID";
            // 
            // viewbuildUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.viewbuildpanel);
            this.Name = "viewbuildUC";
            this.Size = new System.Drawing.Size(772, 720);
            this.viewbuildpanel.ResumeLayout(false);
            this.viewbuildpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewbuildpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView buildingDGV;
        private ePOSOne.btnProduct.Button_WOC buldingAddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biuldingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingName;
    }
}
