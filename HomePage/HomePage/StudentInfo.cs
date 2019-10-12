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
    public partial class StudentInfo : MaterialSkin.Controls.MaterialForm
    {
        //private MySqlCommand command;
        //private MySqlDataAdapter adapter;
        //private DataTable table;

        public StudentInfo()
        {

            InitializeComponent();
            showdata();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


        }

       


        public void delete()
        {



            try
            {
                SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
                cons.Open();
                SqlCommand command = new SqlCommand("DELETE FROM t_sIs WHERE f_Id='" + sId.Text.ToString() + "'", cons);
                command.ExecuteNonQuery();
                cons.Close();
                MessageBox.Show("Successfully Deleted !");
                showdata();
                Ueset();
                count();
                Save.Enabled = true;
                button2.Enabled = false;
                del.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //reset
        public void Ueset()
        {

            sId.Text = "";
            Lname.Text = "";
            Fname.Text = "";
            Mi.Text = "";
            Mn.Text = "";
            dob.Text = "";
            Pres.Text = "";
            PsA.Text = "";
            age.Text = "";
            gen.Text = "";
            moth.Text = "";
            fath.Text = "";
            occup1.Text = "";
            occup2.Text = "";
            guard.Text = "";
            textCourse.Text = "";
            textYear.Text = "";


        }
        public void count()
        {
            int count = dataGridView2.RowCount;
            Total.Text = count.ToString();
        }

        public void update()
        {
            try
            {
                SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
                cons.Open();
                SqlCommand command = new SqlCommand(("UPDATE t_sIs SET f_Id='" + sId.Text.ToString() + "'," +
                    "f_lname='" + Lname.Text.ToString() + "',f_fname='" + Fname.Text.ToString() + "'," +
                    "f_mi='" + Mi.Text.ToString() + "',f_mn= '" + Mn.Text.ToString() + "',f_dob='" + dob.Text.ToString() + "'," +
                    "f_pres='" + Pres.Text.ToString() + "',f_prev='" + PsA.Text.ToString() + "'," +
                    "f_age='" + age.Text.ToString() + "',f_gen='" + gen.Text.ToString() + "'," +
                    "f_moth= '" + moth.Text.ToString() + "',f_fath ='" + fath.Text.ToString() + "'," +
                    "f_occup1='" + occup1.Text.ToString() + "',f_occup2='" + occup2.Text.ToString() + "'," +
                    " f_guard='" + guard.Text.ToString() + "',f_dept='"+ textCourse.Text.ToString() + "',Year='"+textYear.Text.ToString()+ "' WHERE f_Id='" + sId.Text.ToString() + "'"), cons);
                command.ExecuteNonQuery();
                cons.Close();
                MessageBox.Show("Successfully Updated !");
                showdata();
                Ueset();
                count();
                Save.Enabled = true;
                button2.Enabled = false;
                del.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Show ug Data
        public void showdata()
        {
            try
            {
                SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
                SqlDataAdapter adpt;
                DataTable dt;
                adpt = new SqlDataAdapter("SELECT f_Id, f_lname, f_fname,f_mi,f_mn,f_dept,Year FROM t_sIs ORDER BY f_fname", cons);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView2.DataSource = dt;
                count();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void saveit()
        {



            try
            {
                SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
                cons.Open();
                SqlCommand command = new SqlCommand("INSERT INTO t_sIs (f_Id, f_lname, f_fname, f_mi, f_mn," +
                    " f_dob, f_pres, f_prev, f_age,f_gen,f_moth,f_fath,f_occup1,f_occup2,f_guard,f_dept,Year) " +
                "VALUES ('" + sId.Text.ToString() + "', '" + Lname.Text.ToString() + "','" + Fname.Text.ToString() + "'," +
                "'" + Mi.Text.ToString() + "','" + Mn.Text.ToString() + "','" + dob.Text.ToString() + "','" + Pres.Text.ToString() + "','" + PsA.Text.ToString() + "'," +
                "'" + age.Text.ToString() + "','" + gen.Text.ToString() + "','" + moth.Text.ToString() + "'," +
                "'" + fath.Text.ToString() + "','" + occup1.Text.ToString() + "','" + occup2.Text.ToString() + "'," +
                "'" + guard.Text.ToString() + "','"+textCourse.Text.ToString()+"','"+textYear.Text.ToString()+"')", cons);
                command.ExecuteNonQuery();
                MessageBox.Show("Succesfully!!");
                showdata();
                Ueset();
                count();
                Save.Enabled = true;
                button2.Enabled = false;
                del.Enabled = false;
                cons.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sAoPage ss = new sAoPage();
            ss.Show();


        }

        private void Del_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveit();
        }

        private void DataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView2_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
       

        private void Save_Click_1(object sender, EventArgs e)
        {
            
            saveit();
            sId.Focus();
        }

        private void Gen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            showdata();
            sId.Focus();
        }

        private void DataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Are you want to Update it?",
                    "", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    update();
                    sId.Focus();
                }
                else if (dialog == DialogResult.No)
                {

                }

            }

        }

        private void DataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sId.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                Lname.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                Fname.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                Mi.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                Mn.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                dob.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                Pres.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                PsA.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                age.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                gen.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
                moth.Text = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
                fath.Text = dataGridView2.Rows[e.RowIndex].Cells[11].Value.ToString();
                occup1.Text = dataGridView2.Rows[e.RowIndex].Cells[12].Value.ToString();
                occup2.Text = dataGridView2.Rows[e.RowIndex].Cells[13].Value.ToString();
                guard.Text = dataGridView2.Rows[e.RowIndex].Cells[14].Value.ToString();
                textCourse.Text = dataGridView2.Rows[e.RowIndex].Cells[15].Value.ToString();
                textYear.Text = dataGridView2.Rows[e.RowIndex].Cells[16].Value.ToString();
                Save.Enabled = false;
                button2.Enabled = true;
                del.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Del_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Are you want to sure to delete it?",
                    "", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    delete();
                    sId.Focus();

                }
                else if (dialog == DialogResult.No)
                {

                }

            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
       
        }

        private void SId_TextChanged_1(object sender, EventArgs e)
        {

        }

        //private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        SearchByButton.PerformClick();
        //    }
        //}

        private void Button5_Click(object sender, EventArgs e)
        {
            Ueset();
            search.Focus();

        }

        private void Dob_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectCourse.Text == "ALL COURSES")
            {
                showdata();
            }
            else {
                SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
                SqlDataAdapter adpt;
                DataTable dt;
                adpt = new SqlDataAdapter("SELECT * FROM t_sIs WHERE f_dept  = '" + SelectCourse.Text + "'ORDER BY Year", cons);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView2.DataSource = dt;
                count();
            }




        }


        private void SelectCourse_ValueMemberChanged(object sender, EventArgs e)
        {
            //selectcourse();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            //selectcourse();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
          
            SqlConnection cons = new SqlConnection(Properties.Settings.Default.conString);
            SqlDataAdapter adpt;
            DataTable dt;
            adpt = new SqlDataAdapter("SELECT * FROM t_sIs WHERE f_Id like '" + search.Text + "%'", cons);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
            count();
    
        }

       
        private void Total_TextChanged(object sender, EventArgs e)
        {
            //count = dataGridView2.Count;
            //Total.Text = count.ToString();

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
