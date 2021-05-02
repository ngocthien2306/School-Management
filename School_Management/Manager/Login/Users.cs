using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace School_Management.Manager.Login
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Users(string user = "", string pass = "")
        {
            this.Username = user;
            this.Password = pass;
        }
        static My_Database connect = new My_Database();
        public bool GetUser(string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (Username, Password) + VALUES (@user, @pass", connect.GetConnection);
            command.Parameters.Add(@"user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add(@"pass", SqlDbType.NVarChar).Value = pass;
            connect.Openconnection();
            if(command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                connect.Closeconnection();
                return false;
            }
        }
        public DataTable GetUser(SqlCommand command)
        {
            command.Connection = connect.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public bool Login(string user, string pass)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Login where Username = @user AND Password = @pass", connect.GetConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Insert_User(int id, string fname, string lname, string username, string pass, MemoryStream picture)
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("INSERT INTO New_User Id, firstname, lastname, username, password, picture " +
                "VALUES @ID, @fname, @lname, @uname, @pass, @picture", data.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            data.Openconnection();
            if(command.ExecuteNonQuery() == 1)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
