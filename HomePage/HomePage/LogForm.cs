using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

      

        private void Button1_Click_1(object sender, EventArgs e)
        {
        


            try
            {

                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT UserName, Password FROM t_register  WHERE UserName = '" + Uname.Text.ToString() + "'" +
                        "AND Password='"+password.Text.ToString()+"' "))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            string use = sdr["UserName"].ToString();
                            String paw = sdr["Password"].ToString();

                            if (use == Uname.Text.ToString() && paw == password.Text.ToString()) 
                            {
                                MessageBox.Show("Success !!");

                                this.Hide();
                                sAoPage ss = new sAoPage();
                                ss.Show();
                            }

                           
                        }
                        con.Close();

                    }
                }
            }
            catch (Exception )
            {
 
                MessageBox.Show("Invalid User Name / Password");
               
            }
            Uname.Text = "";
            password.Text = "";
            Uname.Focus();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click_2(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to  Close this program?",
                "exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm mark = new LogInForm();
            mark.Show();    
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage ss = new sAoPage();
            ss.Show();
        }

      
        

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage mark = new sAoPage();
            mark.Show();

        }

        private void Uname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter  )

            {
                LogIn.PerformClick();
                Uname.Text = "";
                password.Text = "";
               
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                LogIn.PerformClick();
                Uname.Text = "";
                password.Text = "";
                Uname.Focus();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            regestration mark = new regestration();
            mark.Show();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage mark = new sAoPage();
            mark.Show();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Eye_MouseLeave_1(object sender, EventArgs e)
        {
            this.password.PasswordChar = '*';
        }

        private void Eye_MouseHover_1(object sender, EventArgs e)
        {
            this.password.PasswordChar = '\0';
        }

        private void Eye_Click(object sender, EventArgs e)
        {

        }
    }
    
  
  
}
