namespace NewTimeApp.UserControlers
{
    partial class AcademicDetailsViewUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademicDetailsViewUC));
            this.academicViewPanel = new System.Windows.Forms.Panel();
            this.acUpYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.academicDataGrid = new System.Windows.Forms.DataGridView();
            this.backBtnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newTimeAppDataSet = new NewTimeApp.NewTimeAppDataSet();
            this.newTimeAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dltBtn = new ePOSOne.btnProduct.Button_WOC();
            this.updateDetailsBtn = new ePOSOne.btnProduct.Button_WOC();
            this.acUpSem = new System.Windows.Forms.TextBox();
            this.academicViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTimeAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTimeAppDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // academicViewPanel
            // 
            this.academicViewPanel.BackColor = System.Drawing.Color.White;
            this.academicViewPanel.Controls.Add(this.acUpSem);
            this.academicViewPanel.Controls.Add(this.dltBtn);
            this.academicViewPanel.Controls.Add(this.acUpYear);
            this.academicViewPanel.Controls.Add(this.label3);
            this.academicViewPanel.Controls.Add(this.label2);
            this.academicViewPanel.Controls.Add(this.academicDataGrid);
            this.academicViewPanel.Controls.Add(this.updateDetailsBtn);
            this.academicViewPanel.Controls.Add(this.backBtnS);
            this.academicViewPanel.Controls.Add(this.label1);
            this.academicViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.academicViewPanel.Location = new System.Drawing.Point(0, 0);
            this.academicViewPanel.Name = "academicViewPanel";
            this.academicViewPanel.Size = new System.Drawing.Size(1000, 790);
            this.academicViewPanel.TabIndex = 0;
            this.academicViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.academicViewPanel_Paint);
            // 
            // acUpYear
            // 
            this.acUpYear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acUpYear.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acUpYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.acUpYear.Location = new System.Drawing.Point(475, 141);
            this.acUpYear.Multiline = true;
            this.acUpYear.Name = "acUpYear";
            this.acUpYear.Size = new System.Drawing.Size(417, 45);
            this.acUpYear.TabIndex = 203;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(106, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 38);
            this.label3.TabIndex = 202;
            this.label3.Text = "Academic Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(106, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 38);
            this.label2.TabIndex = 201;
            this.label2.Text = "Academic Year";
            // 
            // academicDataGrid
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.academicDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.academicDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.academicDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.academicDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.academicDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.academicDataGrid.ColumnHeadersHeight = 90;
            this.academicDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.academicDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.academicDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.academicDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.academicDataGrid.GridColor = System.Drawing.Color.White;
            this.academicDataGrid.Location = new System.Drawing.Point(33, 437);
            this.academicDataGrid.Name = "academicDataGrid";
            this.academicDataGrid.ReadOnly = true;
            this.academicDataGrid.RowHeadersWidth = 40;
            this.academicDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.academicDataGrid.RowTemplate.Height = 24;
            this.academicDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.academicDataGrid.Size = new System.Drawing.Size(925, 319);
            this.academicDataGrid.TabIndex = 200;
            this.academicDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.academicDataGrid_CellClick);
            // 
            // backBtnS
            // 
            this.backBtnS.FlatAppearance.BorderSize = 0;
            this.backBtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnS.Image = ((System.Drawing.Image)(resources.GetObject("backBtnS.Image")));
            this.backBtnS.Location = new System.Drawing.Point(33, 26);
            this.backBtnS.Name = "backBtnS";
            this.backBtnS.Size = new System.Drawing.Size(66, 56);
            this.backBtnS.TabIndex = 48;
            this.backBtnS.UseVisualStyleBackColor = true;
            this.backBtnS.Click += new System.EventHandler(this.backBtnS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(121, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 47;
            this.label1.Text = "Academic Details";
            // 
            // newTimeAppDataSet
            // 
            this.newTimeAppDataSet.DataSetName = "NewTimeAppDataSet";
            this.newTimeAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newTimeAppDataSetBindingSource
            // 
            this.newTimeAppDataSetBindingSource.DataSource = this.newTimeAppDataSet;
            this.newTimeAppDataSetBindingSource.Position = 0;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "acID";
            this.Column3.HeaderText = "Index";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "acYear";
            this.Column1.HeaderText = "Academic Year";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 400;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "acSem";
            this.Column2.HeaderText = "Academic Semester";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 250;
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.Color.White;
            this.dltBtn.BorderColor = System.Drawing.Color.Black;
            this.dltBtn.ButtonColor = System.Drawing.Color.White;
            this.dltBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dltBtn.FlatAppearance.BorderSize = 0;
            this.dltBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.dltBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.dltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dltBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltBtn.ForeColor = System.Drawing.Color.Black;
            this.dltBtn.Location = new System.Drawing.Point(725, 343);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.dltBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dltBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.dltBtn.Size = new System.Drawing.Size(167, 67);
            this.dltBtn.TabIndex = 205;
            this.dltBtn.Text = "Delete";
            this.dltBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
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
            this.updateDetailsBtn.Location = new System.Drawing.Point(475, 334);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.updateDetailsBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateDetailsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateDetailsBtn.Size = new System.Drawing.Size(167, 67);
            this.updateDetailsBtn.TabIndex = 51;
            this.updateDetailsBtn.Text = "Update";
            this.updateDetailsBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateDetailsBtn.UseVisualStyleBackColor = false;
            this.updateDetailsBtn.Click += new System.EventHandler(this.updateDetailsBtn_Click);
            // 
            // acUpSem
            // 
            this.acUpSem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acUpSem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acUpSem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.acUpSem.Location = new System.Drawing.Point(475, 260);
            this.acUpSem.Multiline = true;
            this.acUpSem.Name = "acUpSem";
            this.acUpSem.Size = new System.Drawing.Size(417, 45);
            this.acUpSem.TabIndex = 206;
            // 
            // AcademicDetailsViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.academicViewPanel);
            this.Name = "AcademicDetailsViewUC";
            this.Size = new System.Drawing.Size(1000, 790);
            this.Load += new System.EventHandler(this.AcademicDetailsViewUC_Load);
            this.academicViewPanel.ResumeLayout(false);
            this.academicViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTimeAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTimeAppDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel academicViewPanel;
        private System.Windows.Forms.Button backBtnS;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC updateDetailsBtn;
        private System.Windows.Forms.DataGridView academicDataGrid;
        private System.Windows.Forms.BindingSource newTimeAppDataSetBindingSource;
        private NewTimeAppDataSet newTimeAppDataSet;
        private System.Windows.Forms.TextBox acUpYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC dltBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox acUpSem;
    }
}
