namespace NewTimeApp.UserControlers
{
    partial class DegreeDetailsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DegreeDetailsView));
            this.mainGroupDetailsPanel = new System.Windows.Forms.Panel();
            this.acSem = new System.Windows.Forms.ComboBox();
            this.acYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.academicDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDetailsBtn = new ePOSOne.btnProduct.Button_WOC();
            this.viewBtn = new ePOSOne.btnProduct.Button_WOC();
            this.backBtnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainGroupDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGroupDetailsPanel
            // 
            this.mainGroupDetailsPanel.BackColor = System.Drawing.Color.White;
            this.mainGroupDetailsPanel.Controls.Add(this.acSem);
            this.mainGroupDetailsPanel.Controls.Add(this.acYear);
            this.mainGroupDetailsPanel.Controls.Add(this.label3);
            this.mainGroupDetailsPanel.Controls.Add(this.label2);
            this.mainGroupDetailsPanel.Controls.Add(this.academicDataGrid);
            this.mainGroupDetailsPanel.Controls.Add(this.updateDetailsBtn);
            this.mainGroupDetailsPanel.Controls.Add(this.viewBtn);
            this.mainGroupDetailsPanel.Controls.Add(this.backBtnS);
            this.mainGroupDetailsPanel.Controls.Add(this.label1);
            this.mainGroupDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.mainGroupDetailsPanel.Name = "mainGroupDetailsPanel";
            this.mainGroupDetailsPanel.Size = new System.Drawing.Size(1000, 790);
            this.mainGroupDetailsPanel.TabIndex = 0;
            // 
            // acSem
            // 
            this.acSem.BackColor = System.Drawing.Color.White;
            this.acSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acSem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acSem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.acSem.FormattingEnabled = true;
            this.acSem.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.acSem.Location = new System.Drawing.Point(495, 264);
            this.acSem.Name = "acSem";
            this.acSem.Size = new System.Drawing.Size(417, 46);
            this.acSem.TabIndex = 209;
            // 
            // acYear
            // 
            this.acYear.BackColor = System.Drawing.Color.White;
            this.acYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acYear.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.acYear.FormattingEnabled = true;
            this.acYear.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.acYear.Location = new System.Drawing.Point(495, 140);
            this.acYear.Name = "acYear";
            this.acYear.Size = new System.Drawing.Size(417, 46);
            this.acYear.TabIndex = 208;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(126, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 38);
            this.label3.TabIndex = 207;
            this.label3.Text = "Prefered Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(126, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 38);
            this.label2.TabIndex = 206;
            this.label2.Text = "Program Name";
            // 
            // academicDataGrid
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.academicDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.academicDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.academicDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.academicDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.academicDataGrid.ColumnHeadersHeight = 80;
            this.academicDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.academicDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.academicDataGrid.GridColor = System.Drawing.Color.White;
            this.academicDataGrid.Location = new System.Drawing.Point(38, 480);
            this.academicDataGrid.Name = "academicDataGrid";
            this.academicDataGrid.RowHeadersWidth = 50;
            this.academicDataGrid.RowTemplate.Height = 24;
            this.academicDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.academicDataGrid.Size = new System.Drawing.Size(930, 254);
            this.academicDataGrid.TabIndex = 205;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "degreeID";
            this.Column1.HeaderText = "Index";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "degreeName";
            this.Column2.HeaderText = "Program Name";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Prefered Name";
            this.Column3.HeaderText = "Prefered Name";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // updateDetailsBtn
            // 
            this.updateDetailsBtn.BackColor = System.Drawing.Color.White;
            this.updateDetailsBtn.BorderColor = System.Drawing.Color.Black;
            this.updateDetailsBtn.ButtonColor = System.Drawing.Color.White;
            this.updateDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateDetailsBtn.FlatAppearance.BorderSize = 0;
            this.updateDetailsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.updateDetailsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updateDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDetailsBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDetailsBtn.ForeColor = System.Drawing.Color.Black;
            this.updateDetailsBtn.Location = new System.Drawing.Point(495, 359);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.updateDetailsBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateDetailsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateDetailsBtn.Size = new System.Drawing.Size(167, 67);
            this.updateDetailsBtn.TabIndex = 204;
            this.updateDetailsBtn.Text = "Update";
            this.updateDetailsBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.White;
            this.viewBtn.BorderColor = System.Drawing.Color.Black;
            this.viewBtn.ButtonColor = System.Drawing.Color.White;
            this.viewBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.viewBtn.FlatAppearance.BorderSize = 0;
            this.viewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.viewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.Black;
            this.viewBtn.Location = new System.Drawing.Point(745, 359);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.viewBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewBtn.Size = new System.Drawing.Size(167, 67);
            this.viewBtn.TabIndex = 203;
            this.viewBtn.Text = "Delete";
            this.viewBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // backBtnS
            // 
            this.backBtnS.FlatAppearance.BorderSize = 0;
            this.backBtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnS.Image = ((System.Drawing.Image)(resources.GetObject("backBtnS.Image")));
            this.backBtnS.Location = new System.Drawing.Point(38, 30);
            this.backBtnS.Name = "backBtnS";
            this.backBtnS.Size = new System.Drawing.Size(66, 56);
            this.backBtnS.TabIndex = 202;
            this.backBtnS.UseVisualStyleBackColor = true;
            this.backBtnS.Click += new System.EventHandler(this.backBtnS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(126, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 41);
            this.label1.TabIndex = 201;
            this.label1.Text = "Degree Program Details";
            // 
            // DegreeDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainGroupDetailsPanel);
            this.Name = "DegreeDetailsView";
            this.Size = new System.Drawing.Size(1000, 790);
            this.Load += new System.EventHandler(this.DegreeDetailsView_Load);
            this.mainGroupDetailsPanel.ResumeLayout(false);
            this.mainGroupDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainGroupDetailsPanel;
        private ePOSOne.btnProduct.Button_WOC updateDetailsBtn;
        private ePOSOne.btnProduct.Button_WOC viewBtn;
        private System.Windows.Forms.Button backBtnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView academicDataGrid;
        private System.Windows.Forms.ComboBox acSem;
        private System.Windows.Forms.ComboBox acYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
