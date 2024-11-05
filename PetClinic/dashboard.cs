using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinic
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox7_logout_Click(object sender, EventArgs e)
        {
            
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_pets_Click(object sender, EventArgs e)
        {
            pets obj = new pets();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_doctors_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void _receptionist_Click(object sender, EventArgs e)
        {
            Receptionists obj = new Receptionists();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_prescription_Click(object sender, EventArgs e)
        {
            Prescription obj = new Prescription();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_billing_Click(object sender, EventArgs e)
        {
            billing obj = new billing();
            obj.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
