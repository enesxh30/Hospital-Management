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
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void checkout_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            if (textBox1.Text != "")
            {

            }
            string query = "select emri,mbiemri,dtrregjistrim from Pacient where pid="+textBox1.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                label10.Text = da.GetValue(0).ToString();
                label8.Text = da.GetValue(1).ToString();
                DateTime a;
                a = Convert.ToDateTime(da.GetValue(2).ToString());
                label11.Text = da.GetValue(2).ToString();
                DateTime b = DateTime.Today;
                string dif = (b - a).TotalDays.ToString();
                label9.Text = dif+" dite";
                label13.Text = textBox2.Text+ " €";

            }
            conn.Close();
            

        }
    }
}
