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
    public partial class Staff_login : Form
    {
        public Staff_login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Staff_login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            string query = "select* from admini where admid='" + textBox1.Text.Trim() + "' and fjalekalimi='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                add_staff adm_panel = new add_staff();
                this.Hide();
                adm_panel.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Te dhenat nuk jane te sakta !");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
