namespace HomePage
{
    partial class StudentInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.del = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.guardian = new System.Windows.Forms.Label();
            this.guard = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.occup2 = new System.Windows.Forms.TextBox();
            this.occup1 = new System.Windows.Forms.TextBox();
            this.occupation2 = new System.Windows.Forms.Label();
            this.occupation1 = new System.Windows.Forms.Label();
            this.fath = new System.Windows.Forms.TextBox();
            this.fathName = new System.Windows.Forms.Label();
            this.moth = new System.Windows.Forms.TextBox();
            this.mothName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.Mn = new System.Windows.Forms.TextBox();
            this.Mi = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.aged = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Label();
            this.pA = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.mob = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.Label();
            this.sI = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sId = new System.Windows.Forms.TextBox();
            this.Pres = new System.Windows.Forms.TextBox();
            this.PsA = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.SelectCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCourse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Lime;
            this.del.Enabled = false;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.ForeColor = System.Drawing.SystemColors.ControlText;
            this.del.Location = new System.Drawing.Point(525, 496);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 22;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.Del_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(364, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(222, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.LimeGreen;
            this.dataGridView2.Location = new System.Drawing.Point(380, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 229);
            this.dataGridView2.TabIndex = 68;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick_1);
            // 
            // guardian
            // 
            this.guardian.AutoSize = true;
            this.guardian.BackColor = System.Drawing.Color.Transparent;
            this.guardian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardian.ForeColor = System.Drawing.Color.Lime;
            this.guardian.Location = new System.Drawing.Point(101, 459);
            this.guardian.Name = "guardian";
            this.guardian.Size = new System.Drawing.Size(74, 15);
            this.guardian.TabIndex = 67;
            this.guardian.Text = "Guardian :";
            // 
            // guard
            // 
            this.guard.BackColor = System.Drawing.Color.Silver;
            this.guard.Location = new System.Drawing.Point(194, 454);
            this.guard.Name = "guard";
            this.guard.Size = new System.Drawing.Size(145, 20);
            this.guard.TabIndex = 19;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Lime;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(69, 496);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 19;
            this.Save.Text = "save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // occup2
            // 
            this.occup2.BackColor = System.Drawing.Color.Silver;
            this.occup2.Location = new System.Drawing.Point(491, 430);
            this.occup2.Name = "occup2";
            this.occup2.Size = new System.Drawing.Size(128, 20);
            this.occup2.TabIndex = 16;
            // 
            // occup1
            // 
            this.occup1.BackColor = System.Drawing.Color.Silver;
            this.occup1.Location = new System.Drawing.Point(491, 402);
            this.occup1.Name = "occup1";
            this.occup1.Size = new System.Drawing.Size(128, 20);
            this.occup1.TabIndex = 15;
            // 
            // occupation2
            // 
            this.occupation2.AutoSize = true;
            this.occupation2.BackColor = System.Drawing.Color.Transparent;
            this.occupation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupation2.ForeColor = System.Drawing.Color.Lime;
            this.occupation2.Location = new System.Drawing.Point(377, 428);
            this.occupation2.Name = "occupation2";
            this.occupation2.Size = new System.Drawing.Size(87, 15);
            this.occupation2.TabIndex = 62;
            this.occupation2.Text = "Occupation :";
            // 
            // occupation1
            // 
            this.occupation1.AutoSize = true;
            this.occupation1.BackColor = System.Drawing.Color.Transparent;
            this.occupation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupation1.ForeColor = System.Drawing.Color.Lime;
            this.occupation1.Location = new System.Drawing.Point(377, 403);
            this.occupation1.Name = "occupation1";
            this.occupation1.Size = new System.Drawing.Size(87, 15);
            this.occupation1.TabIndex = 61;
            this.occupation1.Text = "Occupation :";
            // 
            // fath
            // 
            this.fath.BackColor = System.Drawing.Color.Silver;
            this.fath.Location = new System.Drawing.Point(194, 428);
            this.fath.Name = "fath";
            this.fath.Size = new System.Drawing.Size(145, 20);
            this.fath.TabIndex = 13;
            // 
            // fathName
            // 
            this.fathName.AutoSize = true;
            this.fathName.BackColor = System.Drawing.Color.Transparent;
            this.fathName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathName.ForeColor = System.Drawing.Color.Lime;
            this.fathName.Location = new System.Drawing.Point(66, 428);
            this.fathName.Name = "fathName";
            this.fathName.Size = new System.Drawing.Size(109, 15);
            this.fathName.TabIndex = 59;
            this.fathName.Text = "Father\'s Name :";
            // 
            // moth
            // 
            this.moth.BackColor = System.Drawing.Color.Silver;
            this.moth.Location = new System.Drawing.Point(194, 402);
            this.moth.Name = "moth";
            this.moth.Size = new System.Drawing.Size(145, 20);
            this.moth.TabIndex = 12;
            // 
            // mothName
            // 
            this.mothName.AutoSize = true;
            this.mothName.BackColor = System.Drawing.Color.Transparent;
            this.mothName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mothName.ForeColor = System.Drawing.Color.Lime;
            this.mothName.Location = new System.Drawing.Point(62, 405);
            this.mothName.Name = "mothName";
            this.mothName.Size = new System.Drawing.Size(113, 15);
            this.mothName.TabIndex = 57;
            this.mothName.Text = "Mother\'s Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(349, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Student Information ";
            // 
            // gen
            // 
            this.gen.BackColor = System.Drawing.Color.Silver;
            this.gen.FormattingEnabled = true;
            this.gen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gen.Location = new System.Drawing.Point(194, 368);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(145, 21);
            this.gen.TabIndex = 11;
            this.gen.SelectedIndexChanged += new System.EventHandler(this.Gen_SelectedIndexChanged);
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.Silver;
            this.age.Location = new System.Drawing.Point(194, 332);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(145, 20);
            this.age.TabIndex = 10;
            // 
            // Mn
            // 
            this.Mn.BackColor = System.Drawing.Color.Silver;
            this.Mn.Location = new System.Drawing.Point(200, 222);
            this.Mn.Name = "Mn";
            this.Mn.Size = new System.Drawing.Size(145, 20);
            this.Mn.TabIndex = 6;
            // 
            // Mi
            // 
            this.Mi.BackColor = System.Drawing.Color.Silver;
            this.Mi.Location = new System.Drawing.Point(200, 196);
            this.Mi.Name = "Mi";
            this.Mi.Size = new System.Drawing.Size(145, 20);
            this.Mi.TabIndex = 5;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.Silver;
            this.Fname.Location = new System.Drawing.Point(200, 174);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(145, 20);
            this.Fname.TabIndex = 4;
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.Silver;
            this.Lname.Location = new System.Drawing.Point(200, 149);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(145, 20);
            this.Lname.TabIndex = 3;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.Lime;
            this.gender.Location = new System.Drawing.Point(113, 377);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(62, 15);
            this.gender.TabIndex = 45;
            this.gender.Text = "Gender :";
            // 
            // aged
            // 
            this.aged.AutoSize = true;
            this.aged.BackColor = System.Drawing.Color.Transparent;
            this.aged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aged.ForeColor = System.Drawing.Color.Lime;
            this.aged.Location = new System.Drawing.Point(136, 337);
            this.aged.Name = "aged";
            this.aged.Size = new System.Drawing.Size(39, 15);
            this.aged.TabIndex = 44;
            this.aged.Text = "Age :";
            // 
            // previous
            // 
            this.previous.AutoSize = true;
            this.previous.BackColor = System.Drawing.Color.Transparent;
            this.previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous.ForeColor = System.Drawing.Color.Lime;
            this.previous.Location = new System.Drawing.Point(1, 306);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(178, 15);
            this.previous.TabIndex = 43;
            this.previous.Text = "Previous School Attended :";
            // 
            // pA
            // 
            this.pA.AutoSize = true;
            this.pA.BackColor = System.Drawing.Color.Transparent;
            this.pA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pA.ForeColor = System.Drawing.Color.Lime;
            this.pA.Location = new System.Drawing.Point(58, 282);
            this.pA.Name = "pA";
            this.pA.Size = new System.Drawing.Size(119, 15);
            this.pA.TabIndex = 42;
            this.pA.Text = "Present Address :";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Lime;
            this.date.Location = new System.Drawing.Point(82, 255);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(95, 15);
            this.date.TabIndex = 41;
            this.date.Text = "Date of Birth :";
            // 
            // mob
            // 
            this.mob.AutoSize = true;
            this.mob.BackColor = System.Drawing.Color.Transparent;
            this.mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob.ForeColor = System.Drawing.Color.Lime;
            this.mob.Location = new System.Drawing.Point(63, 227);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(114, 15);
            this.mob.TabIndex = 40;
            this.mob.Text = "Mobile Number :";
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.BackColor = System.Drawing.Color.Transparent;
            this.mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid.ForeColor = System.Drawing.Color.Lime;
            this.mid.Location = new System.Drawing.Point(78, 201);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(99, 15);
            this.mid.TabIndex = 39;
            this.mid.Text = "Middle Initial :";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.BackColor = System.Drawing.Color.Transparent;
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.ForeColor = System.Drawing.Color.Lime;
            this.fn.Location = new System.Drawing.Point(92, 174);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(85, 15);
            this.fn.TabIndex = 38;
            this.fn.Text = "First Name :";
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.BackColor = System.Drawing.Color.Transparent;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.ForeColor = System.Drawing.Color.Lime;
            this.ln.Location = new System.Drawing.Point(93, 148);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(84, 15);
            this.ln.TabIndex = 37;
            this.ln.Text = "Last Name :";
            // 
            // sI
            // 
            this.sI.AutoSize = true;
            this.sI.BackColor = System.Drawing.Color.Transparent;
            this.sI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sI.ForeColor = System.Drawing.Color.Lime;
            this.sI.Location = new System.Drawing.Point(97, 123);
            this.sI.Name = "sI";
            this.sI.Size = new System.Drawing.Size(80, 15);
            this.sI.TabIndex = 36;
            this.sI.Text = "Student Id :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(825, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(673, 496);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // sId
            // 
            this.sId.BackColor = System.Drawing.Color.Silver;
            this.sId.Location = new System.Drawing.Point(200, 123);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(145, 20);
            this.sId.TabIndex = 2;
            this.sId.TextChanged += new System.EventHandler(this.SId_TextChanged_1);
            // 
            // Pres
            // 
            this.Pres.BackColor = System.Drawing.Color.Silver;
            this.Pres.Location = new System.Drawing.Point(199, 282);
            this.Pres.Name = "Pres";
            this.Pres.Size = new System.Drawing.Size(145, 20);
            this.Pres.TabIndex = 8;
            // 
            // PsA
            // 
            this.PsA.BackColor = System.Drawing.Color.Silver;
            this.PsA.Location = new System.Drawing.Point(199, 305);
            this.PsA.Name = "PsA";
            this.PsA.Size = new System.Drawing.Size(134, 20);
            this.PsA.TabIndex = 9;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Silver;
            this.search.Location = new System.Drawing.Point(200, 82);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(138, 20);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // SelectCourse
            // 
            this.SelectCourse.BackColor = System.Drawing.Color.DarkGray;
            this.SelectCourse.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectCourse.FormattingEnabled = true;
            this.SelectCourse.Items.AddRange(new object[] {
            "BSIT",
            "BSHM",
            "BSTM",
            "BSBA",
            "BSED",
            "BEED",
            "ALL COURSES"});
            this.SelectCourse.Location = new System.Drawing.Point(453, 115);
            this.SelectCourse.MaxLength = 1;
            this.SelectCourse.Name = "SelectCourse";
            this.SelectCourse.Size = new System.Drawing.Size(117, 26);
            this.SelectCourse.TabIndex = 20;
            this.SelectCourse.SelectedIndexChanged += new System.EventHandler(this.SelectCourse_SelectedIndexChanged);
            this.SelectCourse.ValueMemberChanged += new System.EventHandler(this.SelectCourse_ValueMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(351, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Find Course:";
            // 
            // textCourse
            // 
            this.textCourse.BackColor = System.Drawing.Color.Silver;
            this.textCourse.Location = new System.Drawing.Point(758, 407);
            this.textCourse.Name = "textCourse";
            this.textCourse.Size = new System.Drawing.Size(128, 20);
            this.textCourse.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(644, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Course";
            // 
            // textYear
            // 
            this.textYear.BackColor = System.Drawing.Color.Silver;
            this.textYear.Location = new System.Drawing.Point(758, 437);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(128, 20);
            this.textYear.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(644, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 85;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(105, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 87;
            this.label4.Text = "Search Id:";
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.Silver;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(814, 539);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(72, 22);
            this.Total.TabIndex = 89;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(610, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 15);
            this.label5.TabIndex = 88;
            this.label5.Text = "Total Number of Students:";
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(200, 248);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(145, 20);
            this.dob.TabIndex = 7;
            this.dob.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 569);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectCourse);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.del);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.guardian);
            this.Controls.Add(this.guard);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.occup2);
            this.Controls.Add(this.occup1);
            this.Controls.Add(this.occupation2);
            this.Controls.Add(this.occupation1);
            this.Controls.Add(this.fath);
            this.Controls.Add(this.fathName);
            this.Controls.Add(this.moth);
            this.Controls.Add(this.mothName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.age);
            this.Controls.Add(this.PsA);
            this.Controls.Add(this.Pres);
            this.Controls.Add(this.Mn);
            this.Controls.Add(this.Mi);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.sId);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.aged);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.pA);
            this.Controls.Add(this.date);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.sI);
            this.Name = "StudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label guardian;
        private System.Windows.Forms.TextBox guard;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox occup2;
        private System.Windows.Forms.TextBox occup1;
        private System.Windows.Forms.Label occupation2;
        private System.Windows.Forms.Label occupation1;
        private System.Windows.Forms.TextBox fath;
        private System.Windows.Forms.Label fathName;
        private System.Windows.Forms.TextBox moth;
        private System.Windows.Forms.Label mothName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox Mn;
        private System.Windows.Forms.TextBox Mi;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label aged;
        private System.Windows.Forms.Label previous;
        private System.Windows.Forms.Label pA;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label mob;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label sI;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox sId;
        private System.Windows.Forms.TextBox Pres;
        private System.Windows.Forms.TextBox PsA;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox SelectCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button del;
    }
}