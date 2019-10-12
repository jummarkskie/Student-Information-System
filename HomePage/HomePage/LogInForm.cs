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
    public partial class LogInForm : MaterialSkin.Controls.MaterialForm
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
                }

        private void MaterialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void UseName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                LogIn.PerformClick();
                UseName.Text = "";
                password.Text = "";

            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogIn.PerformClick();
                UseName.Text = "";
                password.Text = "";
                UseName.Focus();
            }
        }

        private void MaterialRaisedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void MaterialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage mark = new sAoPage();
            mark.Show();
        }

        private void Eye_MouseClick(object sender, MouseEventArgs e)
        {
            this.password.PasswordChar = '\0';
        }

        private void Eye_MouseLeave(object sender, EventArgs e)
        {
            this.password.PasswordChar = '*';
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage mark = new sAoPage();
            mark.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to  Close this program?",
                "exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           Security mark = new Security();
            mark.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT UserName, Password FROM t_register  WHERE UserName = '" + UseName.Text.ToString() + "'" +
                        "AND Password='" + password.Text.ToString() + "' "))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            string use = sdr["UserName"].ToString();
                            String paw = sdr["Password"].ToString();

                            if (use == UseName.Text.ToString() && paw == password.Text.ToString())
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
            catch (Exception)
            {

                MessageBox.Show("Invalid User Name / Password");

            }
            UseName.Text = "";
            password.Text = "";
            UseName.Focus();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage mark = new sAoPage();
            mark.Show();
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }
    } 
}
