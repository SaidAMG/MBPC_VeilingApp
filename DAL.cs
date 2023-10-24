﻿using MBPC_VeilingApp.Classes;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace MBPC_VeilingApp
{
    public static class DAL
    {
        static string connectionString = "Data Source=.;Initial Catalog=MBPC;Integrated Security=True"; // Dit gebruik je om naar de database te verwijzen

        // De Read functies vullen de onderstaande lijsten.
        // Deze worden ook gebruikt om in de code bepaalde acties uit te voeren.
        // Je kunt deze zien als een soort database binnen de code.
        public static List<Booklet> booklets = new List<Booklet>();
        // Lijst members komt hier
        public static List<Lot> lots = new List<Lot>();
        // Lijst auctions komt hier
        // Lijst lot2Mems komt hier

        // De RefreshDal functie stelt ons in staat om de InCodeDatabase te synchroniseren met de SQLDatabase.
        // Het is vaak handig om deze functie aan te roepen nadat je een CRUD-operatie op een van de tabellen hebt uitgevoerd.
        public static void RefreshDAL()
        {
            // hier alle reads
            ReadBooklets();
            //memerread
            //Auction
            ReadLots();
            //lot2mem
        }

        //CRUD Booklet
        // Maakt een instantie Booklet aan in de database.
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
                    command.Parameters.AddWithValue("@pane", _booklet.GetPane());
                    command.Parameters.AddWithValue("@description", _booklet.GetDescription());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Alle Booklet instanties uit de database en voegt ze toe aan de List<Booklet> booklets
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
                                (int)reader["bookletID"],
                                (string)reader["name"],
                                (string)reader["pane"],
                                (string)reader["description"]);

                            booklets.Add(booklet);
                        }
                    }
                }
                connection.Close();
            }
        }

        // Update een instantie Booklet in de database aan de hand van het Id.
        public static void UpdateBooklet(Booklet _booklet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "UPDATE BOOKLET SET name = @name, pane = @pane, description = @description WHERE bookletID = @bookletID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@bookletID", _booklet.GetId());
                    command.Parameters.AddWithValue("@name", _booklet.GetName());
                    command.Parameters.AddWithValue("@pane", _booklet.GetPane());
                    command.Parameters.AddWithValue("@description", _booklet.GetDescription());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Delete een instantie Booklet in de database aan de hand van het Id.
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
        // Maakt een instantie Member aan in de database.
        public static void CreateMember(/*Member _member*/)
        {
            // Implementatie hier
        }

        // Haalt alle Member instanties uit de database en voegt ze toe aan de lijst van members.
        public static void ReadMembers()
        {
            // Implementatie hier
        }

        // Update een instantie Member in de database aan de hand van het Id.
        public static void UpdateMember(/*Member _member*/)
        {
            // Implementatie hier
        }

        // Verwijdert een instantie Member uit de database aan de hand van het Id.
        public static void DeleteMember(/*Member _member*/)
        {
            // Implementatie hier
        }


        //CRUD Lot
        // Maakt een instantie Lot aan in de database.
        public static void CreateLot(Lot _lot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "INSERT INTO LOT(id, auctionId, vendorId, bookletId, lotId, description, perfType, perfCondition, verified, reservePrice, memberReference)" +
                             "VALUES (@id, @auctionid, @vendroId, @bookletId, @lotId, @description, @perfType, @perfCondition, @verified, @reservePrice, @memberReference)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _lot.GetId());
                    command.Parameters.AddWithValue("@auctionId", _lot.GetAuctionId());
                    command.Parameters.AddWithValue("@vendorId", _lot.GetVendorId());
                    command.Parameters.AddWithValue("@bookletId", _lot.GetBookletId());
                    command.Parameters.AddWithValue("@lotId", _lot.GetLotId());
                    command.Parameters.AddWithValue("@description", _lot.GetDescription());
                    command.Parameters.AddWithValue("@perfType", _lot.GetPerfType());
                    command.Parameters.AddWithValue("@perfCondition", _lot.GetPerfCondition());
                    command.Parameters.AddWithValue("@verified", _lot.Getverified());
                    command.Parameters.AddWithValue("@reservePrice", _lot.GetReservePrice());
                    command.Parameters.AddWithValue("@memberReference", _lot.GetMemberReference());

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Haalt alle Lot instanties uit de database en voegt ze toe aan de lijst van lots.
        public static void ReadLots()
        {
            // Implementatie hier
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                lots.Clear();
                string qry = "SELECT id, auctionId, vendorId, bookletId, lotId, description, perfType, perfCondition, verified, reservePrice, memberReference FROM LOT";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lot lot = new Lot(
                                (int)reader["id"],
                                (int)reader["auctionId"],
                                (int)reader["vendorId"],
                                (int)reader["bookletId"],
                                (int)reader["lotId"],
                                (string)reader["description"],
                                (string)reader["perfType"],
                                (string)reader["perfCondition"],
                                (int)reader["verified"],
                                (double)reader["reservePrice"],
                                reader["memberReference"] == DBNull.Value ? string.Empty : (string)reader["memberReference"]);
                           
                            lots.Add(lot);
                        }
                    }
                }
                connection.Close();
            }
        }

        // Update een instantie Lot in de database aan de hand van het Id.
        public static void UpdateLot(Lot _lot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "UPDATE LOT SET auctionId = @auctionId, vendorId = @vendorId, bookletId = @bookletId, lotId = @lotId, description = @description, perType = @perfType, perfCondition = @perfCondition, verified = @verified, reservePrice = @reservePrice, memberReference = @memberReference WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _lot.GetId());
                    command.Parameters.AddWithValue("@auctionId", _lot.GetAuctionId());
                    command.Parameters.AddWithValue("@vendorId", _lot.GetVendorId());
                    command.Parameters.AddWithValue("@bookletId", _lot.GetBookletId());
                    command.Parameters.AddWithValue("@lotId", _lot.GetLotId());
                    command.Parameters.AddWithValue("@description", _lot.GetDescription());
                    command.Parameters.AddWithValue("@perfType", _lot.GetPerfType());
                    command.Parameters.AddWithValue("@perfCondition", _lot.GetPerfCondition());
                    command.Parameters.AddWithValue("@verified", _lot.Getverified());
                    command.Parameters.AddWithValue("@reservePrice", _lot.GetReservePrice());
                    command.Parameters.AddWithValue("@memberReference", _lot.GetMemberReference());

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    

    // Verwijdert een instantie Lot uit de database aan de hand van het Id.
        public static void DeleteLot(Lot _lot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "DELETE FROM LOT WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _lot.GetId());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        //CRUD Auction
        // Maakt een instantie Auction aan in de database.
        public static void CreateAuction(/*Auction _auction*/)
        {
            // Implementatie hier
        }

        // Haalt alle Auction instanties uit de database en voegt ze toe aan de lijst van auctions.
        public static void ReadAuctions()
        {
            // Implementatie hier
        }

        // Update een instantie Auction in de database aan de hand van het Id.
        public static void UpdateAuction(/*Auction _auction*/)
        {
            // Implementatie hier
        }

        // Verwijdert een instantie Auction uit de database aan de hand van het Id.
        public static void DeleteAuction(/*Auction _auction*/)
        {
            // Implementatie hier
        }


        //CRUD Lot2Mem
        // Maakt een instantie Lot2Mem aan in de database.
        public static void CreateLot2Mem(/*Lot2Mem _lot2Mem*/)
        {
            // Implementatie hier
        }

        // Haalt alle Lot2Mem instanties uit de database en voegt ze toe aan de lijst van lot2Mems.
        public static void ReadLot2Mems()
        {
            // Implementatie hier
        }

        // Update een instantie Lot2Mem in de database aan de hand van het Id.
        public static void UpdateLot2Mem(/*Lot2Mem _lot2Mem*/)
        {
            // Implementatie hier
        }

        // Verwijdert een instantie Lot2Mem uit de database aan de hand van het Id.
        public static void DeleteLot2Mem(/*Lot2Mem _lot2Mem*/)
        {
            // Implementatie hier
        }

    }
}
