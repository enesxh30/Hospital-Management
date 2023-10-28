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
    
    public partial class add_staff : Form
    {
        
        DataTable dt,dt1;
        SqlDataAdapter sda,sda1;
        SqlCommandBuilder scb,scb1;
        public add_staff()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_staff_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sqda = new SqlDataAdapter("select* from admini", conn);
            SqlDataAdapter sqd = new SqlDataAdapter("select* from stafi", conn);
            DataTable dtb = new DataTable();
            DataTable dtbl = new DataTable();
            sqd.Fill(dtbl);
            sqda.Fill(dtb);
            label10.Text = "";
            label1.Text = "";
            label10.Text = dtb.Rows.Count.ToString();
            label1.Text = dtbl.Rows.Count.ToString();
            conn.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into stafi(stafid,emri,mbiemri,mosha,vendlindja,fjalekalimi) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text +"')";
            cmd.ExecuteNonQuery();

            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            MessageBox.Show("Te dhenat u shtuan me sukses!");

            DialogResult = DialogResult.None;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into admini(admid,emri,fjalekalimi) values('" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "')";
            cmd.ExecuteNonQuery();
            label10.Text = dt1.Rows.Count.ToString();
            conn.Close();
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            
            MessageBox.Show("Te dhenat u shtuan me sukses!");

            DialogResult = DialogResult.None;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            try
            {

                sda = new SqlDataAdapter("select* from stafi", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                label1.Text = dt.Rows.Count.ToString();


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            scb1 = new SqlCommandBuilder(sda1);
            sda1.Update(dt1);
            label10.Text = dt1.Rows.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
                scb = new SqlCommandBuilder(sda1);
                sda1.Update(dt1);
                label10.Text = dt1.Rows.Count.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 lg = new Form1();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
                label1.Text = dt.Rows.Count.ToString();

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            try
            {

                sda1 = new SqlDataAdapter("select* from admini", conn);
                dt1 = new DataTable();
                sda1.Fill(dt1);
                dataGridView2.DataSource = dt1;
                label10.Text = dt1.Rows.Count.ToString();


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            conn.Close();
        }
    }
}
