namespace NewTimeApp.UserControlers
{
    partial class SubGroupDetailsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubGroupDetailsUC));
            this.SGDetailsPanel = new System.Windows.Forms.Panel();
            this.academicDataGrid = new System.Windows.Forms.DataGridView();
            this.updateDetailsBtn = new ePOSOne.btnProduct.Button_WOC();
            this.viewBtn = new ePOSOne.btnProduct.Button_WOC();
            this.backBtnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.TextBox();
            this.acsem = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SGDetailsPanel
            // 
            this.SGDetailsPanel.BackColor = System.Drawing.Color.White;
            this.SGDetailsPanel.Controls.Add(this.dname);
            this.SGDetailsPanel.Controls.Add(this.acsem);
            this.SGDetailsPanel.Controls.Add(this.label4);
            this.SGDetailsPanel.Controls.Add(this.label2);
            this.SGDetailsPanel.Controls.Add(this.academicDataGrid);
            this.SGDetailsPanel.Controls.Add(this.updateDetailsBtn);
            this.SGDetailsPanel.Controls.Add(this.viewBtn);
            this.SGDetailsPanel.Controls.Add(this.backBtnS);
            this.SGDetailsPanel.Controls.Add(this.label1);
            this.SGDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SGDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.SGDetailsPanel.Name = "SGDetailsPanel";
            this.SGDetailsPanel.Size = new System.Drawing.Size(1000, 790);
            this.SGDetailsPanel.TabIndex = 1;
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
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.academicDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.academicDataGrid.GridColor = System.Drawing.Color.White;
            this.academicDataGrid.Location = new System.Drawing.Point(38, 451);
            this.academicDataGrid.Name = "academicDataGrid";
            this.academicDataGrid.RowHeadersWidth = 50;
            this.academicDataGrid.RowTemplate.Height = 24;
            this.academicDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.academicDataGrid.Size = new System.Drawing.Size(902, 296);
            this.academicDataGrid.TabIndex = 210;
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
            this.updateDetailsBtn.Location = new System.Drawing.Point(801, 346);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.updateDetailsBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateDetailsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateDetailsBtn.Size = new System.Drawing.Size(139, 67);
            this.updateDetailsBtn.TabIndex = 209;
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
            this.viewBtn.Location = new System.Drawing.Point(549, 346);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.viewBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewBtn.Size = new System.Drawing.Size(139, 67);
            this.viewBtn.TabIndex = 208;
            this.viewBtn.Text = "View";
            this.viewBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.viewBtn.UseVisualStyleBackColor = false;
            // 
            // backBtnS
            // 
            this.backBtnS.FlatAppearance.BorderSize = 0;
            this.backBtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnS.Image = ((System.Drawing.Image)(resources.GetObject("backBtnS.Image")));
            this.backBtnS.Location = new System.Drawing.Point(38, 43);
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
            this.label1.Location = new System.Drawing.Point(126, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 41);
            this.label1.TabIndex = 206;
            this.label1.Text = "Sub Group Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(126, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 38);
            this.label4.TabIndex = 212;
            this.label4.Text = "Sub Group No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(126, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 38);
            this.label2.TabIndex = 211;
            this.label2.Text = "Main Group ID";
            // 
            // dname
            // 
            this.dname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dname.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.dname.Location = new System.Drawing.Point(549, 255);
            this.dname.Multiline = true;
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(391, 51);
            this.dname.TabIndex = 217;
            // 
            // acsem
            // 
            this.acsem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acsem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acsem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.acsem.Location = new System.Drawing.Point(549, 152);
            this.acsem.Multiline = true;
            this.acsem.Name = "acsem";
            this.acsem.Size = new System.Drawing.Size(391, 51);
            this.acsem.TabIndex = 216;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "subID";
            this.Column1.HeaderText = "Index";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MainGroupID";
            this.Column2.HeaderText = "Main Group ID";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "subGroupNo";
            this.Column4.HeaderText = "Sub Group No";
            this.Column4.MinimumWidth = 15;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // SubGroupDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SGDetailsPanel);
            this.Name = "SubGroupDetailsUC";
            this.Size = new System.Drawing.Size(1000, 790);
            this.SGDetailsPanel.ResumeLayout(false);
            this.SGDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SGDetailsPanel;
        private System.Windows.Forms.DataGridView academicDataGrid;
        private ePOSOne.btnProduct.Button_WOC updateDetailsBtn;
        private ePOSOne.btnProduct.Button_WOC viewBtn;
        private System.Windows.Forms.Button backBtnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.TextBox acsem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
