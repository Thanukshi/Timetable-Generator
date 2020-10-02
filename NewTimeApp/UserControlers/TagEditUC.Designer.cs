namespace NewTimeApp.UserControlers
{
    partial class TagEditUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagEditUC));
            this.tpanel = new System.Windows.Forms.Panel();
            this.tName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.academicDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtnS = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDetailsBtn = new ePOSOne.btnProduct.Button_WOC();
            this.deletebtn = new ePOSOne.btnProduct.Button_WOC();
            this.tpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tpanel
            // 
            this.tpanel.BackColor = System.Drawing.Color.White;
            this.tpanel.Controls.Add(this.tName);
            this.tpanel.Controls.Add(this.label2);
            this.tpanel.Controls.Add(this.academicDataGrid);
            this.tpanel.Controls.Add(this.updateDetailsBtn);
            this.tpanel.Controls.Add(this.deletebtn);
            this.tpanel.Controls.Add(this.backBtnS);
            this.tpanel.Controls.Add(this.label1);
            this.tpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanel.Location = new System.Drawing.Point(0, 0);
            this.tpanel.Name = "tpanel";
            this.tpanel.Size = new System.Drawing.Size(1000, 790);
            this.tpanel.TabIndex = 1;
            // 
            // tName
            // 
            this.tName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.tName.Location = new System.Drawing.Point(495, 205);
            this.tName.Multiline = true;
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(417, 45);
            this.tName.TabIndex = 208;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(126, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 38);
            this.label2.TabIndex = 206;
            this.label2.Text = "Tag Name";
            // 
            // academicDataGrid
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.academicDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.academicDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.academicDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.academicDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
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
            this.academicDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.academicDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.academicDataGrid.Location = new System.Drawing.Point(38, 480);
            this.academicDataGrid.Name = "academicDataGrid";
            this.academicDataGrid.ReadOnly = true;
            this.academicDataGrid.RowHeadersWidth = 50;
            this.academicDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.academicDataGrid.RowTemplate.Height = 24;
            this.academicDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.academicDataGrid.Size = new System.Drawing.Size(930, 254);
            this.academicDataGrid.TabIndex = 205;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(126, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 201;
            this.label1.Text = "Tag Details";
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
            // Column1
            // 
            this.Column1.DataPropertyName = "degreeID";
            this.Column1.HeaderText = "Index";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tags";
            this.Column2.HeaderText = "Tag Name";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
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
            this.updateDetailsBtn.Location = new System.Drawing.Point(495, 346);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.updateDetailsBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateDetailsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateDetailsBtn.Size = new System.Drawing.Size(167, 67);
            this.updateDetailsBtn.TabIndex = 204;
            this.updateDetailsBtn.Text = "Update";
            this.updateDetailsBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateDetailsBtn.UseVisualStyleBackColor = false;
            this.updateDetailsBtn.Click += new System.EventHandler(this.updateDetailsBtn_Click);
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
            this.deletebtn.Location = new System.Drawing.Point(745, 346);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.deletebtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deletebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deletebtn.Size = new System.Drawing.Size(167, 67);
            this.deletebtn.TabIndex = 203;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // TagEditUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tpanel);
            this.Name = "TagEditUC";
            this.Size = new System.Drawing.Size(1000, 790);
            this.Load += new System.EventHandler(this.TagEditUC_Load);
            this.tpanel.ResumeLayout(false);
            this.tpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tpanel;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView academicDataGrid;
        private ePOSOne.btnProduct.Button_WOC updateDetailsBtn;
        private ePOSOne.btnProduct.Button_WOC deletebtn;
        private System.Windows.Forms.Button backBtnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
