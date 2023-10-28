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
    public partial class roominfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;
        public roominfo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT nrpavjoni, llojidhomes, numerdhome, pid, emri, mbiemri, mosha, semundja, dtrregjistrim FROM Pacient ORDER BY numerdhome";
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
