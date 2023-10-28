using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiSpitalit
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Staff_login staff_lg = new Staff_login();
            this.Hide();
            staff_lg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_patient shto_pacient = new add_patient();
            shto_pacient.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Doni te mbyllni programin?","Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 logini = new Form1();
            DialogResult dialog = MessageBox.Show("Doni te dilni nga llogaria?", "LogOut", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                logini.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showinfpatient showinf = new showinfpatient();
            showinf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roominfo rm = new roominfo();
            rm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkout p = new checkout();
            p.ShowDialog();
        }
    }
}
