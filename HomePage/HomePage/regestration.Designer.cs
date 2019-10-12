namespace HomePage
{
    partial class regestration
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
            this.label1 = new System.Windows.Forms.Label();
            this.reg_fname = new System.Windows.Forms.TextBox();
            this.reg_last = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(186, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // reg_fname
            // 
            this.reg_fname.BackColor = System.Drawing.Color.Silver;
            this.reg_fname.Location = new System.Drawing.Point(324, 291);
            this.reg_fname.Name = "reg_fname";
            this.reg_fname.Size = new System.Drawing.Size(198, 20);
            this.reg_fname.TabIndex = 3;
            this.reg_fname.TextChanged += new System.EventHandler(this.R_userName_TextChanged);
            this.reg_fname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.R_userName_KeyDown);
            // 
            // reg_last
            // 
            this.reg_last.BackColor = System.Drawing.Color.Silver;
            this.reg_last.Location = new System.Drawing.Point(324, 340);
            this.reg_last.Name = "reg_last";
            this.reg_last.Size = new System.Drawing.Size(198, 20);
            this.reg_last.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(186, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // UseName
            // 
            this.UseName.BackColor = System.Drawing.Color.Silver;
            this.UseName.Location = new System.Drawing.Point(324, 193);
            this.UseName.Name = "UseName";
            this.UseName.Size = new System.Drawing.Size(198, 20);
            this.UseName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(190, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Silver;
            this.Pass.Location = new System.Drawing.Point(324, 240);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(198, 20);
            this.Pass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(203, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // RegSubmit
            // 
            this.RegSubmit.BackColor = System.Drawing.Color.Lime;
            this.RegSubmit.FlatAppearance.BorderSize = 0;
            this.RegSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RegSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegSubmit.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegSubmit.Location = new System.Drawing.Point(288, 411);
            this.RegSubmit.Name = "RegSubmit";
            this.RegSubmit.Size = new System.Drawing.Size(75, 29);
            this.RegSubmit.TabIndex = 10;
            this.RegSubmit.Text = "Submit";
            this.RegSubmit.UseVisualStyleBackColor = false;
            this.RegSubmit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(299, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Registration Form";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(689, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Log in";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(441, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegSubmit);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_last);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg_fname);
            this.Controls.Add(this.label1);
            this.Name = "regestration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Regestration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_fname;
        private System.Windows.Forms.TextBox reg_last;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}