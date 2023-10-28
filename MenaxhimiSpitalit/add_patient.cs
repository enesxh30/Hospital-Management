using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MenaxhimiSpitalit
{
    public partial class add_patient : Form
    {
        string gender="";
        public add_patient()
        {
            InitializeComponent();
        }

        private void add_patient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            con.Open();
            string query = "select* from Pacient";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            da.SelectCommand.ExecuteNonQuery();
            nr_pacienteve.Text = "";
            nr_pacienteve.Text = dtbl.Rows.Count.ToString();

            con.Close();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void passw_pacient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void nr_pacienteve_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            string query = "select count(*) from Pacient";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            nr_pacienteve.Text = dt.ToString();
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void mosha_pacientit_TextChanged(object sender, EventArgs e)
        {

        }

        private void vendl_pacient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void mbiemri_pacientit_TextChanged(object sender, EventArgs e)
        {

        }

        private void emri_pacientit_TextChanged(object sender, EventArgs e)
        {

        }

        private void patient_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void female_button_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void male_button_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText= "insert into Pacient(pid,emri,mbiemri,fjalekalimi,mosha,vendlindja,gjinia,datelindja,semundja,dtrregjistrim,nrpavjoni,llojidhomes,numerdhome) values('" + patient_id.Text + "','" + emri_pacientit.Text + "','" + mbiemri_pacientit.Text + "','" + passw_pacient.Text + "','" + mosha_pacientit.Text + "','" + vendl_pacient.Text + "','" + gender + "','" + DateTime.Parse(dateTimePicker1.Text)+ "','" + textBox5.Text + "','" + DateTime.Parse(dateTimePicker2.Text) + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                cmd.ExecuteNonQuery();

                string query = "select* from Pacient";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.SelectCommand.ExecuteNonQuery();
                nr_pacienteve.Text = dt.Rows.Count.ToString();


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            conn.Close();
            patient_id.Text = "";
            emri_pacientit.Text = "";
            mbiemri_pacientit.Text = "";
            passw_pacient.Text = "";
            mosha_pacientit.Text = "";
            vendl_pacient.Text = "";
            gender = "";
            dateTimePicker1.Text = "";
            textBox5.Text = "";
            dateTimePicker2.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            MessageBox.Show("Te dhenat u shtuan me sukses!");



        }



    }
} 
