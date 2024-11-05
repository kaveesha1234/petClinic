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
    public partial class login : Form
    {
        private DatabaseConnection dbConnection;

        public login()
        {
            InitializeComponent();
            // Initialize the database connection with the connection string
            string connectionString = "Server=EC2AMAZ-QCCVVSV\\SQLEXPRESS01;Database=petclinic;Trusted_Connection=True;";
            dbConnection = new DatabaseConnection(connectionString);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes and combobox
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string role = comboBox_role.SelectedItem?.ToString();

            // Validate the inputs (this is a simple example, you might want to add more checks or actual authentication logic)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the user using the database connection
            if (dbConnection.ValidateUser(username, password, role))
            {
                dashboard obj = new dashboard();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials or role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
