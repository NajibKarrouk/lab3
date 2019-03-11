using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace laboration3.Models
{
    public class BookMethod
    {
        public BookMethod() { }

        // Create a new book
        public int NewBook(BookDetail bd, int user_id, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "INSERT INTO Tbl_Book ( B_Title, B_Description, B_Price, Usr_Id ) VALUES (@title, @description, @price, @usrid);";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("title", SqlDbType.NVarChar, 50).Value = bd.Title;
            dbCommand.Parameters.Add("description", SqlDbType.NVarChar).Value = bd.Description;
            dbCommand.Parameters.Add("price", SqlDbType.Decimal).Value = bd.Price;
            dbCommand.Parameters.Add("usrid", SqlDbType.Int).Value = user_id;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "No book created."; }
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

        public List<BookDetail> GetBooksBySearch(string searchStr, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "SELECT * FROM Tbl_Book WHERE B_Description LIKE '%" + searchStr + "%'";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            SqlDataReader reader = null;

            List<BookDetail> Booklist = new List<BookDetail>();

            try
            {
                // Open the connection
                dbConnection.Open();

                // 1. Get an instance of the SqlDataReader
                reader = dbCommand.ExecuteReader();

                // 2. read necessary columns of each record
                while (reader.Read())
                {
                    BookDetail Book = new BookDetail();
                    Book.Id = Convert.ToInt32(reader["B_Id"]);
                    Book.Title = reader["B_Title"].ToString();
                    Book.Description = reader["B_Description"].ToString();
                    Book.Price = Convert.ToDecimal(reader["B_Price"]);
                    Book.Usr_Id = Convert.ToInt32(reader["Usr_Id"]);

                    Booklist.Add(Book);
                }

                reader.Close();
                errormsg = "";
                return Booklist;
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return Booklist;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public List<BookDetail> GetBooks(out string errormsg, string orderValue)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "SELECT * FROM Tbl_Book";
            if (orderValue != "")
            {
                if (orderValue == "Title")
                {
                    sqlstring = "SELECT * FROM Tbl_Book ORDER BY B_Title";
                } else if (orderValue == "Price")
                {
                    sqlstring = "SELECT * FROM Tbl_Book ORDER BY B_Price";
                }
            }
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            SqlDataReader reader = null;

            List<BookDetail> Booklist = new List<BookDetail>();

            try
            {
                // Open the connection
                dbConnection.Open();

                // 1. Get an instance of the SqlDataReader
                reader = dbCommand.ExecuteReader();

                // 2. read necessary columns of each record
                while (reader.Read())
                {
                    BookDetail Book = new BookDetail();
                    Book.Id = Convert.ToInt32(reader["B_Id"]);
                    Book.Title = reader["B_Title"].ToString();
                    Book.Description = reader["B_Description"].ToString();
                    Book.Price = Convert.ToDecimal(reader["B_Price"]);
                    Book.Usr_Id = Convert.ToInt32(reader["Usr_Id"]);

                    Booklist.Add(Book);
                }

                reader.Close();
                errormsg = "";
                return Booklist;
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return Booklist;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public List<BookDetail> FilterBooks(out string errormsg, int id)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "SELECT * FROM Tbl_Book WHERE B_Id = @id";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = id;

            SqlDataReader reader = null;

            List<BookDetail> Booklist = new List<BookDetail>();

            try
            {
                // Open the connection
                dbConnection.Open();

                // 1. Get an instance of the SqlDataReader
                reader = dbCommand.ExecuteReader();

                // 2. read necessary columns of each record
                while (reader.Read())
                {
                    BookDetail Book = new BookDetail();
                    Book.Id = Convert.ToInt32(reader["B_Id"]);
                    Book.Title = reader["B_Title"].ToString();
                    Book.Description = reader["B_Description"].ToString();
                    Book.Price = Convert.ToDecimal(reader["B_Price"]);
                    Book.Usr_Id = Convert.ToInt32(reader["Usr_Id"]);

                    Booklist.Add(Book);
                }

                reader.Close();
                errormsg = "";
                return Booklist;
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return Booklist;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        // Update information about a book
        public int EditBook(BookDetail bd, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "UPDATE Tbl_Book SET B_Title = @title, B_Description = @description, B_Price = @price WHERE B_Id = @id;";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = bd.Id;
            dbCommand.Parameters.Add("title", SqlDbType.NVarChar, 50).Value = bd.Title;
            dbCommand.Parameters.Add("description", SqlDbType.NVarChar).Value = bd.Description;
            dbCommand.Parameters.Add("price", SqlDbType.Decimal).Value = bd.Price;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "No book updated."; }
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

        // Delete a book
        public int DeleteBook(int book_id, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och lägg till en user i databasen
            String sqlstring = "DELETE FROM Tbl_Book WHERE B_Id = @id;";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = book_id;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "No book deleted."; }
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

        // Get one book
        public BookDetail GetBook(int book_id, out string errormsg)
        {
            // Skapa SqlConnection
            SqlConnection dbConnection = new SqlConnection();

            // Koppling mot SQL Server
            dbConnection.ConnectionString = @"Data Source=DESKTOP-RBA35NK;Initial Catalog=lab3;Integrated Security=True";

            // sqlstring och hämta alla böcker från databasen
            String sqlstring = "SELECT * FROM Tbl_Book WHERE B_Id = @id;";

            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = book_id;

            SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);
            DataSet ds = new DataSet();

            try
            {
                dbConnection.Open();

                adapter.Fill(ds, "book");

                int count = 0;
                int i = 0;
                count = ds.Tables["book"].Rows.Count;

                if (count > 0)
                {
                    BookDetail Book = new BookDetail();
                    Book.Id = Convert.ToInt32(ds.Tables["book"].Rows[i]["B_Id"]);
                    Book.Title = ds.Tables["book"].Rows[i]["B_Title"].ToString();
                    Book.Description = ds.Tables["book"].Rows[i]["B_Description"].ToString();
                    Book.Price = Convert.ToDecimal(ds.Tables["book"].Rows[i]["B_Price"]);
                    Book.Usr_Id = Convert.ToInt32(ds.Tables["book"].Rows[i]["Usr_Id"]);

                    errormsg = "";
                    return Book;
                }
                else
                {
                    errormsg = "Ingen bok hittades.";
                    return (null);
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return (null);
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
