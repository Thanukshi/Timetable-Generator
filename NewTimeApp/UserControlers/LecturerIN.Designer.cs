namespace NewTimeApp.UserControlers
{
    partial class LecturerIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerIN));
            this.Insertlecpanel = new System.Windows.Forms.Panel();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.levelcb = new System.Windows.Forms.ComboBox();
            this.centercb = new System.Windows.Forms.ComboBox();
            this.facultycb = new System.Windows.Forms.ComboBox();
            this.buildingcb = new System.Windows.Forms.ComboBox();
            this.deptb = new System.Windows.Forms.TextBox();
            this.empidtb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.ranktb = new System.Windows.Forms.TextBox();
            this.rank = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.Label();
            this.center = new System.Windows.Forms.Label();
            this.dep = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.lecturer = new System.Windows.Forms.Label();
            this.buttonaddlec = new System.Windows.Forms.Button();
            this.Insertlecpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Insertlecpanel
            // 
            this.Insertlecpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Insertlecpanel.Controls.Add(this.categorycb);
            this.Insertlecpanel.Controls.Add(this.category);
            this.Insertlecpanel.Controls.Add(this.name);
            this.Insertlecpanel.Controls.Add(this.levelcb);
            this.Insertlecpanel.Controls.Add(this.centercb);
            this.Insertlecpanel.Controls.Add(this.facultycb);
            this.Insertlecpanel.Controls.Add(this.buildingcb);
            this.Insertlecpanel.Controls.Add(this.deptb);
            this.Insertlecpanel.Controls.Add(this.empidtb);
            this.Insertlecpanel.Controls.Add(this.nametb);
            this.Insertlecpanel.Controls.Add(this.ranktb);
            this.Insertlecpanel.Controls.Add(this.rank);
            this.Insertlecpanel.Controls.Add(this.level);
            this.Insertlecpanel.Controls.Add(this.building);
            this.Insertlecpanel.Controls.Add(this.center);
            this.Insertlecpanel.Controls.Add(this.dep);
            this.Insertlecpanel.Controls.Add(this.faculty);
            this.Insertlecpanel.Controls.Add(this.empid);
            this.Insertlecpanel.Controls.Add(this.label2);
            this.Insertlecpanel.Controls.Add(this.btnback);
            this.Insertlecpanel.Controls.Add(this.lecturer);
            this.Insertlecpanel.Controls.Add(this.buttonaddlec);
            this.Insertlecpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Insertlecpanel.Location = new System.Drawing.Point(0, 0);
            this.Insertlecpanel.Name = "Insertlecpanel";
            this.Insertlecpanel.Size = new System.Drawing.Size(750, 642);
            this.Insertlecpanel.TabIndex = 0;
            this.Insertlecpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Insertlecpanel_Paint);
            // 
            // categorycb
            // 
            this.categorycb.BackColor = System.Drawing.Color.White;
            this.categorycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer",
            "Instructors"});
            this.categorycb.Location = new System.Drawing.Point(372, 410);
            this.categorycb.Margin = new System.Windows.Forms.Padding(2);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(175, 39);
            this.categorycb.TabIndex = 130;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.category.Location = new System.Drawing.Point(76, 418);
            this.category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(109, 31);
            this.category.TabIndex = 129;
            this.category.Text = "Category";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.name.Location = new System.Drawing.Point(76, 128);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 31);
            this.name.TabIndex = 128;
            this.name.Text = "Name";
            // 
            // levelcb
            // 
            this.levelcb.BackColor = System.Drawing.Color.White;
            this.levelcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelcb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.levelcb.FormattingEnabled = true;
            this.levelcb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.levelcb.Location = new System.Drawing.Point(622, 414);
            this.levelcb.Margin = new System.Windows.Forms.Padding(2);
            this.levelcb.Name = "levelcb";
            this.levelcb.Size = new System.Drawing.Size(64, 39);
            this.levelcb.TabIndex = 127;
            // 
            // centercb
            // 
            this.centercb.BackColor = System.Drawing.Color.White;
            this.centercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.centercb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centercb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.centercb.FormattingEnabled = true;
            this.centercb.Items.AddRange(new object[] {
            " Malabe",
            " Metro",
            " Matara",
            " Kandy",
            " Kurunagala",
            " Jaffna"});
            this.centercb.Location = new System.Drawing.Point(372, 313);
            this.centercb.Margin = new System.Windows.Forms.Padding(2);
            this.centercb.Name = "centercb";
            this.centercb.Size = new System.Drawing.Size(314, 39);
            this.centercb.TabIndex = 126;
            // 
            // facultycb
            // 
            this.facultycb.BackColor = System.Drawing.Color.White;
            this.facultycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultycb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultycb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.facultycb.FormattingEnabled = true;
            this.facultycb.Items.AddRange(new object[] {
            "Computing",
            " Engineering",
            " Business",
            "Humanities & Sciences"});
            this.facultycb.Location = new System.Drawing.Point(372, 220);
            this.facultycb.Margin = new System.Windows.Forms.Padding(2);
            this.facultycb.Name = "facultycb";
            this.facultycb.Size = new System.Drawing.Size(314, 39);
            this.facultycb.TabIndex = 125;
            // 
            // buildingcb
            // 
            this.buildingcb.BackColor = System.Drawing.Color.White;
            this.buildingcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingcb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(54)))));
            this.buildingcb.FormattingEnabled = true;
            this.buildingcb.Items.AddRange(new object[] {
            "New building",
            " D-block"});
            this.buildingcb.Location = new System.Drawing.Point(372, 361);
            this.buildingcb.Margin = new System.Windows.Forms.Padding(2);
            this.buildingcb.Name = "buildingcb";
            this.buildingcb.Size = new System.Drawing.Size(314, 39);
            this.buildingcb.TabIndex = 124;
            // 
            // deptb
            // 
            this.deptb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deptb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.deptb.Location = new System.Drawing.Point(372, 268);
            this.deptb.Margin = new System.Windows.Forms.Padding(2);
            this.deptb.Multiline = true;
            this.deptb.Name = "deptb";
            this.deptb.Size = new System.Drawing.Size(314, 37);
            this.deptb.TabIndex = 123;
            // 
            // empidtb
            // 
            this.empidtb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.empidtb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.empidtb.Location = new System.Drawing.Point(372, 175);
            this.empidtb.Margin = new System.Windows.Forms.Padding(2);
            this.empidtb.Multiline = true;
            this.empidtb.Name = "empidtb";
            this.empidtb.Size = new System.Drawing.Size(314, 37);
            this.empidtb.TabIndex = 122;
            // 
            // nametb
            // 
            this.nametb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nametb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.nametb.Location = new System.Drawing.Point(372, 122);
            this.nametb.Margin = new System.Windows.Forms.Padding(2);
            this.nametb.Multiline = true;
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(314, 37);
            this.nametb.TabIndex = 121;
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            // 
            // ranktb
            // 
            this.ranktb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ranktb.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranktb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.ranktb.Location = new System.Drawing.Point(372, 464);
            this.ranktb.Margin = new System.Windows.Forms.Padding(2);
            this.ranktb.Multiline = true;
            this.ranktb.Name = "ranktb";
            this.ranktb.Size = new System.Drawing.Size(314, 37);
            this.ranktb.TabIndex = 120;
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.rank.Location = new System.Drawing.Point(76, 470);
            this.rank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(64, 31);
            this.rank.TabIndex = 119;
            this.rank.Text = "Rank";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.level.Location = new System.Drawing.Point(551, 414);
            this.level.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(67, 31);
            this.level.TabIndex = 118;
            this.level.Text = "Level";
            // 
            // building
            // 
            this.building.AutoSize = true;
            this.building.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.building.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.building.Location = new System.Drawing.Point(76, 370);
            this.building.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(94, 31);
            this.building.TabIndex = 117;
            this.building.Text = "Building";
            // 
            // center
            // 
            this.center.AutoSize = true;
            this.center.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.center.Location = new System.Drawing.Point(76, 322);
            this.center.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(85, 31);
            this.center.TabIndex = 116;
            this.center.Text = "Center";
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.dep.Location = new System.Drawing.Point(76, 272);
            this.dep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(138, 31);
            this.dep.TabIndex = 115;
            this.dep.Text = "Department";
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.faculty.Location = new System.Drawing.Point(76, 224);
            this.faculty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(89, 31);
            this.faculty.TabIndex = 114;
            this.faculty.Text = "Faculty";
            // 
            // empid
            // 
            this.empid.AutoSize = true;
            this.empid.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.empid.Location = new System.Drawing.Point(76, 175);
            this.empid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(139, 31);
            this.empid.TabIndex = 113;
            this.empid.Text = "EmployeeID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(76, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 112;
            // 
            // btnback
            // 
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(65, 20);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 46);
            this.btnback.TabIndex = 110;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lecturer
            // 
            this.lecturer.AutoSize = true;
            this.lecturer.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.lecturer.Location = new System.Drawing.Point(287, 56);
            this.lecturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lecturer.Name = "lecturer";
            this.lecturer.Size = new System.Drawing.Size(203, 35);
            this.lecturer.TabIndex = 109;
            this.lecturer.Text = "Lecturer Details";
            this.lecturer.Click += new System.EventHandler(this.lecturer_Click);
            // 
            // buttonaddlec
            // 
            this.buttonaddlec.BackColor = System.Drawing.Color.White;
            this.buttonaddlec.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.buttonaddlec.ForeColor = System.Drawing.Color.Purple;
            this.buttonaddlec.Location = new System.Drawing.Point(557, 548);
            this.buttonaddlec.Name = "buttonaddlec";
            this.buttonaddlec.Size = new System.Drawing.Size(119, 38);
            this.buttonaddlec.TabIndex = 107;
            this.buttonaddlec.Text = "ADD";
            this.buttonaddlec.UseVisualStyleBackColor = false;
            this.buttonaddlec.Click += new System.EventHandler(this.buttonaddlec_Click);
            // 
            // LecturerIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Insertlecpanel);
            this.Name = "LecturerIN";
            this.Size = new System.Drawing.Size(750, 642);
            this.Insertlecpanel.ResumeLayout(false);
            this.Insertlecpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Insertlecpanel;
        private System.Windows.Forms.Button buttonaddlec;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox levelcb;
        private System.Windows.Forms.ComboBox centercb;
        private System.Windows.Forms.ComboBox facultycb;
        private System.Windows.Forms.ComboBox buildingcb;
        private System.Windows.Forms.TextBox deptb;
        private System.Windows.Forms.TextBox empidtb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox ranktb;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label building;
        private System.Windows.Forms.Label center;
        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.Label faculty;
        private System.Windows.Forms.Label empid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lecturer;
    }
}
