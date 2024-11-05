using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetClinic
{
    public partial class Doctors : Form
    {
        private DatabaseConnection db;
        private Button button_update;

        public Doctors()
        {
            InitializeComponent();
            db = new DatabaseConnection("Server=EC2AMAZ-QCCVVSV\\SQLEXPRESS01;Database=petclinic;Trusted_Connection=True;");
            LoadDoctorIDs();
            InitializeUI();
           
        }

        private void InitializeUI()
        {
           
            comboBox_doctorID.Visible = false;
            btn_update.Visible = false;
            button_delete.Visible = false;
        }

        private void CreateUpdateButton()
        {
            button_update = new Button
            {
                Text = "Update",
                Location = new System.Drawing.Point(150, 350) // Adjust location as needed
            };
            button_update.Click += new EventHandler(button_update_Click);
            this.Controls.Add(button_update);
            button_update.Visible = false;
            
        }

        private void LoadDoctorIDs()
        {
            List<string> doctorIDs = db.GetDoctorIDs();
            comboBox_doctorID.Items.Clear();
            comboBox_doctorID.Items.AddRange(doctorIDs.ToArray());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void lbl12_ownerAddress_Click(object sender, EventArgs e) { }

        private void pictureBox1_dashboard_Click(object sender, EventArgs e)
        {
            dashboard obj = new dashboard();
            obj.Show();
            this.Hide();
        }

        private void textBox_petid_TextChanged(object sender, EventArgs e) { }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBox_doctorName.Text) ||
                comboBox_gender.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBox_doctorAddress.Text) ||
                string.IsNullOrWhiteSpace(textBox_doctorPhone.Text) ||
                string.IsNullOrWhiteSpace(textBox_doctorPassword.Text) ||
                string.IsNullOrWhiteSpace(textBox_experience.Text) ||
                comboBox_specialisation.SelectedItem == null)
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(textBox_experience.Text, out _))
            {
                MessageBox.Show("Experience must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                string id = GenerateDoctorID();
                string name = textBox_doctorName.Text;
                string gender = comboBox_gender.SelectedItem?.ToString();
                DateTime dob = dateTimePicker_dob.Value;
                string address = textBox_doctorAddress.Text;
                string phone = textBox_doctorPhone.Text;
                string password = textBox_doctorPassword.Text;
                int experience = int.Parse(textBox_experience.Text);
                string specialisation = comboBox_specialisation.SelectedItem?.ToString();

                db.AddDoctor(name, id, gender, dob, address, phone, password, experience, specialisation);
                MessageBox.Show("Doctor added successfully.");
                LoadDoctorIDs();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GenerateDoctorID()
        {
            // Generate a new unique doctor ID
            return Guid.NewGuid().ToString();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            comboBox_doctorID.Visible = true;
            textBox_doctorName.Visible = true;
            comboBox_gender.Visible = true;
            dateTimePicker_dob.Visible = true;
            textBox_doctorAddress.Visible = true;
            textBox_doctorPhone.Visible = true;
            textBox_doctorPassword.Visible = true;
            textBox_experience.Visible = true;
            comboBox_specialisation.Visible = true;
            button_edit.Visible = false;
            button_delete.Visible = true;
            btn_update.Visible =true;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                string id = comboBox_doctorID.Text;
                string name = textBox_doctorName.Text;
                string gender = comboBox_gender.SelectedItem.ToString();
                DateTime dob = dateTimePicker_dob.Value;
                string address = textBox_doctorAddress.Text;
                string phone = textBox_doctorPhone.Text;
                string password = textBox_doctorPassword.Text;
                int experience = int.Parse(textBox_experience.Text);
                string specialisation = comboBox_specialisation.SelectedItem.ToString();

                db.EditDoctor(name, id, gender, dob, address, phone, password, experience, specialisation);
                MessageBox.Show("Doctor updated successfully.");
                LoadDoctorIDs();
                ClearFields();
                InitializeUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_doctorID.Text))
            {
                MessageBox.Show("Please select a Doctor ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string id = comboBox_doctorID.Text;
                db.DeleteDoctor(id);
                MessageBox.Show("Doctor deleted successfully.");
                LoadDoctorIDs();
                ClearFields();
                InitializeUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox_doctorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = comboBox_doctorID.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedID))
            {
                var doctor = db.GetDoctorDetails(selectedID);
                if (doctor != null)
                {
                    textBox_doctorName.Text = doctor.Name;
                    comboBox_gender.SelectedItem = doctor.Gender;
                    dateTimePicker_dob.Value = doctor.DateOfBirth;
                    textBox_doctorAddress.Text = doctor.Address;
                    textBox_doctorPhone.Text = doctor.Phone;
                    textBox_doctorPassword.Text = doctor.Password;
                    textBox_experience.Text = doctor.Experience.ToString();
                    comboBox_specialisation.SelectedItem = doctor.Specialisation;

                    button_add.Visible = false;
                    btn_update.Visible = true;
                    button_delete.Visible = true;
                    button_edit.Visible = false;
                }
                else
                {
                    ClearFields();
                    button_add.Visible = true;
                    button_edit.Visible = false;
                    button_delete.Visible = false;
                    btn_update.Visible = false;
                }
            }
        }

        private void ClearFields()
        {
            textBox_doctorName.Clear();
            comboBox_gender.SelectedIndex = -1;
            dateTimePicker_dob.Value = DateTime.Now;
            textBox_doctorAddress.Clear();
            textBox_doctorPhone.Clear();
            textBox_doctorPassword.Clear();
            textBox_experience.Clear();
            comboBox_specialisation.SelectedIndex = -1;
            btn_update.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btn_update_Click(object sender, EventArgs e)
        {
            button_update_Click(sender, e);
        }
    }
}
