namespace NewTimeApp.UserControlers
{
    partial class MainGroupDetaisUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGroupDetaisUC));
            this.mGDetailsPanel = new System.Windows.Forms.Panel();
            this.updateDetailsBtn = new ePOSOne.btnProduct.Button_WOC();
            this.deletebtn = new ePOSOne.btnProduct.Button_WOC();
            this.gNo = new System.Windows.Forms.TextBox();
            this.dname = new System.Windows.Forms.TextBox();
            this.acsem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.academicDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mGDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mGDetailsPanel
            // 
            this.mGDetailsPanel.BackColor = System.Drawing.Color.White;
            this.mGDetailsPanel.Controls.Add(this.updateDetailsBtn);
            this.mGDetailsPanel.Controls.Add(this.deletebtn);
            this.mGDetailsPanel.Controls.Add(this.gNo);
            this.mGDetailsPanel.Controls.Add(this.dname);
            this.mGDetailsPanel.Controls.Add(this.acsem);
            this.mGDetailsPanel.Controls.Add(this.label4);
            this.mGDetailsPanel.Controls.Add(this.label3);
            this.mGDetailsPanel.Controls.Add(this.label2);
            this.mGDetailsPanel.Controls.Add(this.academicDataGrid);
            this.mGDetailsPanel.Controls.Add(this.backBtnS);
            this.mGDetailsPanel.Controls.Add(this.label1);
            this.mGDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mGDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.mGDetailsPanel.Name = "mGDetailsPanel";
            this.mGDetailsPanel.Size = new System.Drawing.Size(1000, 790);
            this.mGDetailsPanel.TabIndex = 0;
            this.mGDetailsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mGDetailsPanel_Paint);
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
            this.updateDetailsBtn.Location = new System.Drawing.Point(567, 428);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.updateDetailsBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateDetailsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateDetailsBtn.Size = new System.Drawing.Size(167, 67);
            this.updateDetailsBtn.TabIndex = 218;
            this.updateDetailsBtn.Text = "Update";
            this.updateDetailsBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateDetailsBtn.UseVisualStyleBackColor = false;
            this.updateDetailsBtn.Click += new System.EventHandler(this.updateDetailsBtn_Click_1);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.BorderColor = System.Drawing.Color.Black;
            this.deletebtn.ButtonColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Black;
            this.deletebtn.Location = new System.Drawing.Point(817, 428);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.deletebtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deletebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deletebtn.Size = new System.Drawing.Size(167, 67);
            this.deletebtn.TabIndex = 217;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // gNo
            // 
            this.gNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gNo.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.gNo.Location = new System.Drawing.Point(593, 346);
            this.gNo.Multiline = true;
            this.gNo.Name = "gNo";
            this.gNo.Size = new System.Drawing.Size(391, 51);
            this.gNo.TabIndex = 216;
            // 
            // dname
            // 
            this.dname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dname.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.dname.Location = new System.Drawing.Point(593, 243);
            this.dname.Multiline = true;
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(391, 51);
            this.dname.TabIndex = 215;
            // 
            // acsem
            // 
            this.acsem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acsem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acsem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.acsem.Location = new System.Drawing.Point(593, 140);
            this.acsem.Multiline = true;
            this.acsem.Name = "acsem";
            this.acsem.Size = new System.Drawing.Size(391, 51);
            this.acsem.TabIndex = 214;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(78, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 38);
            this.label4.TabIndex = 213;
            this.label4.Text = "Degree Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(78, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 38);
            this.label3.TabIndex = 212;
            this.label3.Text = "Groups No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(78, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 38);
            this.label2.TabIndex = 211;
            this.label2.Text = "Academic Year And Semester";
            // 
            // academicDataGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.academicDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.academicDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.academicDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.academicDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.academicDataGrid.ColumnHeadersHeight = 90;
            this.academicDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.academicDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.academicDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.academicDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.academicDataGrid.GridColor = System.Drawing.Color.White;
            this.academicDataGrid.Location = new System.Drawing.Point(38, 511);
            this.academicDataGrid.Name = "academicDataGrid";
            this.academicDataGrid.ReadOnly = true;
            this.academicDataGrid.RowHeadersWidth = 50;
            this.academicDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.academicDataGrid.RowTemplate.Height = 24;
            this.academicDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.academicDataGrid.Size = new System.Drawing.Size(900, 260);
            this.academicDataGrid.TabIndex = 210;
            this.academicDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.academicDataGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MID";
            this.Column1.HeaderText = "Index";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "macademicDetails";
            this.Column2.HeaderText = "Year and Semester";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mDegereeName";
            this.Column4.HeaderText = "Degree";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "mGroupNo";
            this.Column3.HeaderText = "Main Group No";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // backBtnS
            // 
            this.backBtnS.FlatAppearance.BorderSize = 0;
            this.backBtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnS.Image = ((System.Drawing.Image)(resources.GetObject("backBtnS.Image")));
            this.backBtnS.Location = new System.Drawing.Point(38, 29);
            this.backBtnS.Name = "backBtnS";
            this.backBtnS.Size = new System.Drawing.Size(66, 56);
            this.backBtnS.TabIndex = 207;
            this.backBtnS.UseVisualStyleBackColor = true;
            this.backBtnS.Click += new System.EventHandler(this.backBtnS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(126, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 41);
            this.label1.TabIndex = 206;
            this.label1.Text = "Main Group Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainGroupDetaisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mGDetailsPanel);
            this.Name = "MainGroupDetaisUC";
            this.Size = new System.Drawing.Size(1000, 790);
            this.Load += new System.EventHandler(this.MainGroupDetaisUC_Load);
            this.mGDetailsPanel.ResumeLayout(false);
            this.mGDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mGDetailsPanel;
        private System.Windows.Forms.DataGridView academicDataGrid;
        private System.Windows.Forms.Button backBtnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gNo;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.TextBox acsem;
        private ePOSOne.btnProduct.Button_WOC updateDetailsBtn;
        private ePOSOne.btnProduct.Button_WOC deletebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
