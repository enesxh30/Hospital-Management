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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            try
            {
                string query = "select* from stafi where stafid='" + textBox1.Text.Trim() + "' and fjalekalimi='" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Jeni loguar me sukses!");
                    Dashboard obj1 = new Dashboard();
                    this.Hide();
                    obj1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Te dhenat nuk jane te sakta !");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            conn.Close();
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Staff_login staff_lg = new Staff_login();
            this.Hide();
            staff_lg.ShowDialog();
            this.Close();
            
        }
    }
}
