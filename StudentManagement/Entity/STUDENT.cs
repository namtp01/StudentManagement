using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace StudentManagement.Entity
{
    class STUDENT
    {
        MY_DB conn = new MY_DB();

        public bool insertStudent(string studentId, string fname, string lname, string major, DateTime bdate, string citizenId, 
            string gender, string email, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (studentId, fname, lname, major, bdate, citizenId, gender, email, phone, address, picture)" +
                " VALUES (@sid, @fn, @ln, @mj, @bd, @czId, @gdr, @em, @phn, @adrs, @pic)", conn.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@mj", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@bd", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@czId", SqlDbType.VarChar).Value = citizenId;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            conn.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public bool updateStudent(string studentId, string fname, string lname, string major, DateTime bdate, string citizenId,
            string gender, string email, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET studentId=@sid, fname=@fn, lname=@ln, major=@mj, " +
                "bdate=@bd, citizenId=@czId, gender=@gdr, email=@em, phone=@phn, address=@adrs, picture=@pic WHERE studentId=@sid", conn.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@mj", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@bd", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@czId", SqlDbType.VarChar).Value = citizenId;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            conn.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public bool deleteStudent(string sid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE studentId=@sid", conn.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = sid;

            conn.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = conn.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, conn.getConnection);

            conn.openConnection();
            string count = command.ExecuteScalar().ToString();
            conn.closeConnection();

            return count;
        }

        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM std");
        }

        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Male'");
        }

        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Female'");
        }
    }
}
