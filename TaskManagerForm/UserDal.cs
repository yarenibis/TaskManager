using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerForm
{
    public class UserDal
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=YAREN
            ; initial catalog=TaskManager; integrated security=true");
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            isConnected();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", _sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                User user = new User
                {
                    id = Convert.ToInt32(reader["Id"]),
                    name = reader["name"].ToString(),
                    email = reader["mail"].ToString(),
                    password = reader["password"].ToString(),
                    role = reader["role"].ToString()
                };
                users.Add(user);
            }

            reader.Close();
            _sqlConnection.Close();

            return users;
        }

        private void isConnected()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }


        public void AddUser(User user)
        {
            isConnected();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Users (name, mail, password, role) VALUES (@name, @mail, @password, @role)",
                _sqlConnection
            );
            cmd.Parameters.AddWithValue("@name", user.name);
            cmd.Parameters.AddWithValue("@mail", user.email);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@role", user.role);

            cmd.ExecuteNonQuery(); // ← INSERT için bu kullanılmalı
            _sqlConnection.Close();
        }

        public void UpdateUser(User user)
        {
            isConnected();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Users SET name=@name, mail=@mail, password=@password, role=@role WHERE Id=@Id",
                _sqlConnection
            );

            cmd.Parameters.AddWithValue("@name", user.name);
            cmd.Parameters.AddWithValue("@mail", user.email);  // user.email doğru
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@role", user.role);
            cmd.Parameters.AddWithValue("@Id", user.id);

            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }


        public void DeleteUser(int id) {
            isConnected();
            SqlCommand cmd = new SqlCommand(
                "Delete from Users WHERE Id=@Id",
                _sqlConnection
            );
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
