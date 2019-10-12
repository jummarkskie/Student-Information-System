using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Security : MaterialSkin.Controls.MaterialForm
    {
        public Security()
        {
            InitializeComponent();
        }

        private void Security_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }


       

        private void Submit_Click(object sender, EventArgs e)
        {
          
                if (SecurityText.Text == "cabalan1973")
                {
                    MessageBox.Show("Success!!!");
                    this.Hide();
                    regestration mark = new regestration();
                    mark.Show();
            }
            else
            {
                MessageBox.Show("Invalid Code!!");
                SecurityText.Text = "";
            }

            
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm mark = new LogInForm();
            mark.Show();
        }

        private void SecurityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecurityText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit.PerformClick();
             
            }
        }
    }
}
