using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerForm
{
    public class NoteDal
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=YOUR-SERVER-NAME
        ; initial catalog=TaskManager; integrated security=true");
        public List<Note> GetAll()
        {
            List<Note> notes = new List<Note>();
            isConnected();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Notes", _sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Note note = new Note
                {
                    id = Convert.ToInt32(reader["id"]),
                    title = reader["title"].ToString(),
                    content = reader["content"].ToString(),
                    CreatedDate = Convert.ToDateTime(reader["created_date"]),
                    UpdatedDate = Convert.ToDateTime(reader["updated_date"]),
                    Userid = Convert.ToInt32(reader["user_id"]),
                };
                notes.Add(note);
            }
            reader.Close();
            _sqlConnection.Close();
            return notes;
            
        }



        public List<Note> GetNotesForUsers(int user_id)
        {
            List<Note> notes = new List<Note>();
            isConnected();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Notes where user_id=@User_id ", _sqlConnection);
            cmd.Parameters.AddWithValue("@User_id", user_id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Note note = new Note
                {
                    id = Convert.ToInt32(reader["id"]),
                    title = reader["title"].ToString(),
                    content = reader["content"].ToString(),
                    CreatedDate = Convert.ToDateTime(reader["created_date"]),
                    UpdatedDate = Convert.ToDateTime(reader["updated_date"]),
                    Userid = Convert.ToInt32(reader["user_id"])
                };
                notes.Add(note);
            }
            reader.Close();
            _sqlConnection.Close();
            return notes;

        }




        public void AddNote(Note note)
        {
            isConnected();
            SqlCommand cmd = new SqlCommand("insert into Notes values( @title, @content, @created_date, @updated_date, @user_id)", _sqlConnection);
            cmd.Parameters.AddWithValue("@title", note.title);
            cmd.Parameters.AddWithValue("@content", note.content);
            cmd.Parameters.AddWithValue("@created_date", note.CreatedDate);
            cmd.Parameters.AddWithValue("@updated_date", note.UpdatedDate);
            cmd.Parameters.AddWithValue("@user_id", note.Userid);

            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void isConnected()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
                
            }
        }

        public void UpdateNote(Note note)
        {
            isConnected();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Notes SET title=@title, content=@content, created_date=@created_date, updated_date=@updated_date, user_id=@user_id WHERE id=@id",
                _sqlConnection
            );

            cmd.Parameters.AddWithValue("@title", note.title);
            cmd.Parameters.AddWithValue("@content", note.content);
            cmd.Parameters.AddWithValue("@created_date", note.CreatedDate);
            cmd.Parameters.AddWithValue("@updated_date", note.UpdatedDate);
            cmd.Parameters.AddWithValue("@id", note.id);
            cmd.Parameters.AddWithValue("@user_id", note.Userid);

            cmd.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        public void DeleteNote(int id)
        {
            isConnected();
            SqlCommand cmd = new SqlCommand(
                "Delete from Notes  WHERE id=@id",
                _sqlConnection
            );
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
