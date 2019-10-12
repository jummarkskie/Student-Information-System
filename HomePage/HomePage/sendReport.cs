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
    public partial class sendReport : MaterialSkin.Controls.MaterialForm
    {
        public sendReport()
        {
            InitializeComponent();
        }

        private void SendReport_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
            SqlDataAdapter adpt;
            DataTable dt;
            adpt = new SqlDataAdapter("SELECT * FROM t_sIs WHERE f_Id like '" + serchLabel.Text + "%'", cons);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sms mark = new Sms();
            mark.Show();    
        }

       

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
