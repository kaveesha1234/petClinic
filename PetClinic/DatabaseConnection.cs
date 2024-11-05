using System.Collections.Generic;
using System.Data.SqlClient;
using System;

public class DatabaseConnection
{
    private string connectionString;

    public DatabaseConnection(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public bool ValidateUser(string username, string password, string role)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@password AND Role=@role";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", role);

            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return count == 1;
        }
    }

    public void AddDoctor(string name, string id, string gender, DateTime dob, string address, string phone, string password, int experience, string specialisation)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Doctors (Name, DoctorID, Gender, DateOfBirth, Address, Phone, Password, Experience, Specialisation) " +
                           "VALUES (@name, @id, @gender, @dob, @address, @phone, @password, @experience, @specialisation)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@experience", experience);
            cmd.Parameters.AddWithValue("@specialisation", specialisation);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public void EditDoctor(string name, string id, string gender, DateTime dob, string address, string phone, string password, int experience, string specialisation)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "UPDATE Doctors SET Name=@name, Gender=@gender, DateOfBirth=@dob, Address=@address, Phone=@phone, Password=@password, " +
                           "Experience=@experience, Specialisation=@specialisation WHERE DoctorID=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@experience", experience);
            cmd.Parameters.AddWithValue("@specialisation", specialisation);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public void DeleteDoctor(string id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Doctors WHERE DoctorID=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public List<string> GetDoctorIDs()
    {
        List<string> doctorIDs = new List<string>();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT DoctorID FROM Doctors";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    doctorIDs.Add(reader["DoctorID"].ToString());
                }
            }
            con.Close();
        }

        return doctorIDs;
    }

    public bool DoctorExists(string id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(1) FROM Doctors WHERE DoctorID=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return count == 1;
        }
    }

    public Doctor GetDoctorDetails(string id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Doctors WHERE DoctorID=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Doctor
                    {
                        Name = reader["Name"].ToString(),
                        DoctorID = reader["DoctorID"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Password = reader["Password"].ToString(),
                        Experience = Convert.ToInt32(reader["Experience"]),
                        Specialisation = reader["Specialisation"].ToString()
                    };
                }
            }
            con.Close();
        }

        return null;
    }
}

public class Doctor
{
    public string Name { get; set; }
    public string DoctorID { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public int Experience { get; set; }
    public string Specialisation { get; set; }
}
