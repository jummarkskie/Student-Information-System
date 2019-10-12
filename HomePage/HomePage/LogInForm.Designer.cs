namespace HomePage
{
    partial class LogInForm
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
            this.UseName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Exit = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).BeginInit();
            this.SuspendLayout();
            // 
            // UseName
            // 
            this.UseName.Depth = 0;
            this.UseName.Hint = "User Name";
            this.UseName.Location = new System.Drawing.Point(105, 181);
            this.UseName.MouseState = MaterialSkin.MouseState.HOVER;
            this.UseName.Name = "UseName";
            this.UseName.PasswordChar = '\0';
            this.UseName.SelectedText = "";
            this.UseName.SelectionLength = 0;
            this.UseName.SelectionStart = 0;
            this.UseName.Size = new System.Drawing.Size(167, 23);
            this.UseName.TabIndex = 0;
            this.UseName.UseSystemPasswordChar = false;
            this.UseName.Click += new System.EventHandler(this.MaterialSingleLineTextField1_Click);
            this.UseName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UseName_KeyDown);
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "Password";
            this.password.Location = new System.Drawing.Point(105, 222);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(167, 23);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = false;
            this.password.Click += new System.EventHandler(this.Password_Click);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(225, 357);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Lime;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(300, 77);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(57, 23);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Lime;
            this.LogIn.FlatAppearance.BorderSize = 0;
            this.LogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.Color.Black;
            this.LogIn.Location = new System.Drawing.Point(72, 285);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(200, 23);
            this.LogIn.TabIndex = 24;
            this.LogIn.Text = "LOG IN";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Lime;
            this.Register.FlatAppearance.BorderSize = 0;
            this.Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.Black;
            this.Register.Location = new System.Drawing.Point(72, 331);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(200, 23);
            this.Register.TabIndex = 25;
            this.Register.Text = "SIGN UP";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::HomePage.Properties.Resources.pass01;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(72, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HomePage.Properties.Resources.user01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(72, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // eye
            // 
            this.eye.BackColor = System.Drawing.Color.Transparent;
            this.eye.BackgroundImage = global::HomePage.Properties.Resources.eye;
            this.eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye.Location = new System.Drawing.Point(278, 226);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(27, 19);
            this.eye.TabIndex = 21;
            this.eye.TabStop = false;
            this.eye.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Eye_MouseClick);
            this.eye.MouseLeave += new System.EventHandler(this.Eye_MouseLeave);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.UseName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField UseName;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox eye;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}