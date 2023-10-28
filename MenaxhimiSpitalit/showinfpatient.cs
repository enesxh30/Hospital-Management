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
    public partial class showinfpatient : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public showinfpatient()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            conn.Open();
            try
            {

                sda = new SqlDataAdapter("select* from Pacient",conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                nr_pacienteve1.Text = dt.Rows.Count.ToString();


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    try
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                        int pacient_id = Convert.ToInt32(item.Cells[0].Value);
                        
                        SqlConnection con = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
                        con.Open();
                        string query = "DELETE FROM Pacient WHERE pid = @PacientId";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@PacientId", pacient_id);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        scb = new SqlCommandBuilder(sda);
                        sda.Update(dt);
                        nr_pacienteve1.Text = dt.Rows.Count.ToString();
                        MessageBox.Show("U fshi me sukses!");

                    }
                    catch (SqlException excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }

            }

        }

        private void nr_pacienteve1_Click(object sender, EventArgs e)
        {

        }

        private void showinfpatient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ENES\SQLEXPRESS;Initial Catalog=menaxhimi_spitalit;Integrated Security=True");
            con.Open();
            string query = "select* from Pacient";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            da.SelectCommand.ExecuteNonQuery();
            nr_pacienteve1.Text = "";
            nr_pacienteve1.Text = dtbl.Rows.Count.ToString();
        }
    }
}
