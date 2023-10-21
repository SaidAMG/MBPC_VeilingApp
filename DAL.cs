using MBPC_VeilingApp.Classes;
using System.Data.SqlClient;

namespace MBPC_VeilingApp
{
    public static class DAL
    {
        static string connectionString = "Data Source=.;Initial Catalog=MBPC;Integrated Security=True";
        public static List<Booklet> booklets = new List<Booklet>();


        public static void RefreshDAL()
        {
            // hier alle reads
            ReadBooklets();
            //memerread
            //Auction
            //lot
            //lot2mem
        }

        //CRUD Booklet
        public static void CreateBooklet(Booklet _booklet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "INSERT INTO BOOKLET(name, pane, description) VALUES(@name, @pane, @description)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    //command.Parameters.AddWithValue("@bookletID",_booklet.GetId());
                    command.Parameters.AddWithValue("@name", _booklet.GetName());
                    command.Parameters.AddWithValue("@pane",_booklet.GetPane());
                    command.Parameters.AddWithValue("@description",_booklet.GetDescription());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void ReadBooklets()
        {
            booklets.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "SELECT bookletID, name, pane, description FROM BOOKLET";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booklet booklet = new Booklet(
                                (int)reader[0], 
                                (string)reader[1], 
                                (string)reader[2], 
                                (string)reader[3]);
                            
                            booklets.Add(booklet);
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void UpdateBooklet(Booklet _booklet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "UPDATE BOOKLET SET name = @name, pane = @pane, description = @description WHERE bookletID = @bookletID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@bookletID",_booklet.GetId());
                    command.Parameters.AddWithValue("@name", _booklet.GetName());
                    command.Parameters.AddWithValue("@pane", _booklet.GetPane());
                    command.Parameters.AddWithValue("@description", _booklet.GetDescription());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void DeleteBooklet(Booklet _booklet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "DELETE BOOKLET WHERE bookletID = @bookletID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@bookletID", _booklet.GetId());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        //CRUD Member


        //CRUD Lot


        //CRUD Aution


        //CRUD Lot2Mem

    }
}
