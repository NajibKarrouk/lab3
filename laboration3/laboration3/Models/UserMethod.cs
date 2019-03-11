using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace laboration3.Models
{
    public class UserMethod
    {
        public UserMethod() { }

        // Skapa en ny användare
        public int NewUser(UserDetail ud, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "INSERT INTO Tbl_User ( Usr_Username, Usr_Password ) VALUES ( @username, @password );";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("username", SqlDbType.NVarChar, 50).Value = ud.Username;
            dbCommand.Parameters.Add("password", SqlDbType.NVarChar).Value = ud.Password;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = "";  }
                else { errormsg = "No user created."; }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            } finally
            {
                dbConnection.Close();
            }
        }

        // Hämta samtliga användare
        public List<UserDetail> GetUsers(out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "SELECT * FROM Tbl_User";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            SqlDataReader reader = null;

            List<UserDetail> Userlist = new List<UserDetail>();

            errormsg = "";

            try
            {
                // Open the connection
                dbConnection.Open();

                // 1. Get an instance of the SqlDataReader
                reader = dbCommand.ExecuteReader();

                // 2. read necessary columns of each record
                while (reader.Read())
                {
                    UserDetail User = new UserDetail();
                    User.Id = Convert.ToInt16(reader["Usr_Id"]);
                    User.Username = reader["Usr_Username"].ToString();
                    User.Password = reader["Usr_Password"].ToString();

                    Userlist.Add(User);
                }
                reader.Close();
                return Userlist;
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return Userlist;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        // Uppdatera information om en användare

        // Radera en användare
        public int DeleteUser(int user_id, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "DELETE FROM Tbl_User WHERE Usr_Id = @id;";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = user_id;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "No user was deleted."; }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        // Update information about a user
        public int UpdateUser(UserDetail ud, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "UPDATE Tbl_User SET Usr_Username = @username, Usr_Password = @password WHERE Usr_Id = @id;";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = ud.Id;
            dbCommand.Parameters.Add("username", SqlDbType.NVarChar, 50).Value = ud.Username;
            dbCommand.Parameters.Add("password", SqlDbType.NVarChar, 50).Value = ud.Password;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "No user updated."; }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
