using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomePage
{
    public partial class regestration : MaterialSkin.Controls.MaterialForm
    {
        public regestration()
        {
            InitializeComponent();
        }

      
        public void reset()
        {
            reg_fname.Text = "";
            reg_last.Text = "";
            UseName.Text = "";
            Pass.Text = "";
        


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
                cons.Open();
                SqlCommand command = new SqlCommand("INSERT INTO t_register (UserName, Password, reg_fname, reg_LName ) " +
                "VALUES ('" + UseName.Text.ToString() + "', '" + Pass.Text.ToString() + "','" + reg_fname.Text.ToString() + "'," +
                "'" + reg_last.Text.ToString() + "')", cons);
                command.ExecuteNonQuery();
                MessageBox.Show("Success !!");
                reset();

                reg_fname.Focus();
                this.Hide();
                LogInForm mark = new LogInForm();
                mark.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid UserName");
                reset();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm mark = new LogInForm();
            mark.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            reset();
            reg_fname.Focus();
        }

        private void R_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                RegSubmit.PerformClick();
                reg_last.Text = "";
                reg_fname.Text = "";

            }
        }

        private void Regestration_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


        }
    }

}

