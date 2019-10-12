namespace HomePage
{
    partial class LogForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(208, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Affairs Office";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Uname
            // 
            this.Uname.BackColor = System.Drawing.Color.DarkGray;
            this.Uname.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Uname.Location = new System.Drawing.Point(357, 224);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(182, 23);
            this.Uname.TabIndex = 2;
            this.Uname.TextChanged += new System.EventHandler(this.Uname_TextChanged_1);
            this.Uname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Uname_KeyDown);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Lime;
            this.User.Location = new System.Drawing.Point(216, 225);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(109, 19);
            this.User.TabIndex = 3;
            this.User.Text = "User Name : ";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Lime;
            this.pass.Location = new System.Drawing.Point(220, 267);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 19);
            this.pass.TabIndex = 5;
            this.pass.Text = "Password :";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.DarkGray;
            this.password.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Location = new System.Drawing.Point(357, 267);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(182, 23);
            this.password.TabIndex = 4;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Lime;
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.Color.Gray;
            this.LogIn.Location = new System.Drawing.Point(303, 348);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 33);
            this.LogIn.TabIndex = 6;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(695, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(497, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sign Up";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 27);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(218, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOG IN";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HomePage.Properties.Resources.log_in;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(554, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // eye
            // 
            this.eye.BackColor = System.Drawing.Color.Transparent;
            this.eye.BackgroundImage = global::HomePage.Properties.Resources.eye;
            this.eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye.Location = new System.Drawing.Point(554, 271);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(27, 19);
            this.eye.TabIndex = 19;
            this.eye.TabStop = false;
            this.eye.Click += new System.EventHandler(this.Eye_Click);
            this.eye.MouseLeave += new System.EventHandler(this.Eye_MouseLeave_1);
            this.eye.MouseHover += new System.EventHandler(this.Eye_MouseHover_1);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "LogForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox eye;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

