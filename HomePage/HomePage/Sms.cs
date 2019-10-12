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
    public partial class Sms : MaterialSkin.Controls.MaterialForm
    {
        public Sms()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage mark = new sAoPage();
            mark.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
          

        }

        private void Sms_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


        }

        private void Button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            sendReport mark = new sendReport();
            mark.Show();
        }

        private void SelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
            SqlDataAdapter adpt;
            DataTable dt;
            adpt = new SqlDataAdapter("SELECT * FROM t_sIs WHERE f_dept  = '" + SelectCourse.Text + "'ORDER BY f_fname", cons);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
           

            }

        private void Search_TextChanged(object sender, EventArgs e)
        {

            SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
            SqlDataAdapter adpt;
            DataTable dt;
            adpt = new SqlDataAdapter("SELECT * FROM t_sIs WHERE f_Id like '" + search.Text + "%'", cons);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
