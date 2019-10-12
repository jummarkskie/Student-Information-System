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
    public partial class sAoPage : MaterialSkin.Controls.MaterialForm
    {
    
        public sAoPage()
        {
            InitializeComponent();
        }

          private void SAoPage_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.WHITE);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

            this.Hide();
            StudentInfo ss = new StudentInfo();
            ss.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Do you want to Log Out?",
                    "LOG OUT", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    this.Hide();
                    LogInForm ss = new LogInForm();
                    ss.Show();
                }
                else if (dialog == DialogResult.No)
                {


                }
            }


        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sms mark = new Sms();
            mark.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
           
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentInfo ss = new StudentInfo();
            ss.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sms ss = new Sms();
            ss.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            schoolActivities ss = new schoolActivities();
            ss.Show();
        }
    }
    
}
