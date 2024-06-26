﻿using MBPC_VeilingApp.Classes;
using System.Data.SqlClient;

namespace MBPC_VeilingApp
{
    public static class DAL
    {
        static string connectionString = "Data Source=.;Initial Catalog=MBPC;Integrated Security=True"; // Dit gebruik je om naar de database te verwijzen

        // De Read functies vullen de onderstaande lijsten.
        // Deze worden ook gebruikt om in de code bepaalde acties uit te voeren.
        // Je kunt deze zien als een soort database binnen de code.
        public static List<Booklet> booklets = new List<Booklet>();
        public static List<Member> members = new List<Member>();
        public static List<Lot> lots = new List<Lot>();
        public static List<Auction> auctions = new List<Auction>();
        public static List<Lot2Mem> lot2mems = new List<Lot2Mem>();

        // De RefreshDal functie stelt ons in staat om de InCodeDatabase te synchroniseren met de SQLDatabase.
        // Het is vaak handig om deze functie aan te roepen nadat je een CRUD-operatie op een van de tabellen hebt uitgevoerd.
        public static void RefreshDAL()
        {
            // hier alle reads
            ReadBooklets();
            ReadMembers();
            ReadAuctions();
            ReadLots();
            ReadLot2Mems();
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
        public static void CreateMember(Member _member)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "INSERT INTO MEMBER (firstName, lastName, address, city, zipCode, country, memberNumber, email, birthDate, memberDate, telephoneNumber) " +
                             "VALUES (@firstName, @lastName, @address, @city, @zipCode, @country, @memberNumber, @email, @birthDate, @memberDate, @telephoneNumber)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@firstName", _member.GetFirstName());
                    command.Parameters.AddWithValue("@lastName", _member.GetLastName());
                    command.Parameters.AddWithValue("@address", _member.GetAddress());
                    command.Parameters.AddWithValue("@city", _member.GetCity());
                    command.Parameters.AddWithValue("@zipCode", _member.GetZipCode());
                    command.Parameters.AddWithValue("@country", _member.GetCountry());
                    command.Parameters.AddWithValue("@memberNumber", _member.GetMemberNumber());
                    command.Parameters.AddWithValue("@email", _member.GetEmail());
                    command.Parameters.AddWithValue("@birthDate", _member.GetBirthDate());
                    command.Parameters.AddWithValue("@memberDate", _member.GetMemberDate());
                    command.Parameters.AddWithValue("@telephoneNumber", _member.GetTelephoneNumber());

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Haalt alle Member instanties uit de database en voegt ze toe aan de lijst van members.
        public static void ReadMembers()
        {
            members.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "SELECT id, firstName, lastName, address, city, zipCode, country, memberNumber, email, birthDate, memberDate, telephoneNumber FROM MEMBER";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member(
                                (int)reader["id"],
                                (string)reader["firstName"],
                                (string)reader["lastName"],
                                (string)reader["address"],
                                (string)reader["city"],
                                (string)reader["zipCode"],
                                (string)reader["country"],
                                (int)reader["memberNumber"],
                                reader["email"] == DBNull.Value ? string.Empty : (string)reader["email"],
                                reader["birthDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["birthDate"],
                                reader["memberDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["memberDate"],
                                reader["telephoneNumber"] == DBNull.Value ? string.Empty : (string)reader["telephoneNumber"]);

                            members.Add(member);
                        }
                    }
                }
                connection.Close();
            }
        }

        // Update een instantie Member in de database aan de hand van het Id.
        public static void UpdateMember(Member _member)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "UPDATE MEMBER SET firstName = @firstName, lastName = @lastName, address = @address, city = @city, zipCode = @zipCode, country = @country, memberNumber = @memberNumber, email = @email, birthDate = @birthDate, memberDate = @memberDate, telephoneNumber = @telephoneNumber WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _member.GetId());
                    command.Parameters.AddWithValue("@firstName", _member.GetFirstName());
                    command.Parameters.AddWithValue("@lastName", _member.GetLastName());
                    command.Parameters.AddWithValue("@address", _member.GetAddress());
                    command.Parameters.AddWithValue("@city", _member.GetCity());
                    command.Parameters.AddWithValue("@zipCode", _member.GetZipCode());
                    command.Parameters.AddWithValue("@country", _member.GetCountry());
                    command.Parameters.AddWithValue("@memberNumber", _member.GetMemberNumber());
                    command.Parameters.AddWithValue("@email", _member.GetEmail());
                    command.Parameters.AddWithValue("@birthDate", _member.GetBirthDate());
                    command.Parameters.AddWithValue("@memberDate", _member.GetMemberDate());
                    command.Parameters.AddWithValue("@telephoneNumber", _member.GetTelephoneNumber());

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Verwijdert een instantie Member uit de database aan de hand van het Id.
        public static void DeleteMember(Member _member)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "DELETE FROM MEMBER WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _member.GetId());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


        //CRUD Lot
        // Maakt een instantie Lot aan in de database.
        public static void CreateLot(Lot _lot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "INSERT INTO LOT(auctionId, vendorId, bookletId, lotNumber, description, perfType, perfCondition, verified, reservePrice, memberReference)" +
                             "VALUES (@auctionid, @vendorId, @bookletId, @lotNumber, @description, @perfType, @perfCondition, @verified, @reservePrice, @memberReference)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@auctionId", _lot.GetAuctionId().GetId());
                    command.Parameters.AddWithValue("@vendorId", _lot.GetVendorId().GetId());
                    command.Parameters.AddWithValue("@bookletId", _lot.GetBookletId().GetId());
                    command.Parameters.AddWithValue("@lotNumber", _lot.GetLotNumber());
                    command.Parameters.AddWithValue("@description", _lot.GetDescription());
                    command.Parameters.AddWithValue("@perfType", _lot.GetPerfType());
                    command.Parameters.AddWithValue("@perfCondition", _lot.GetPerfCondition());
                    command.Parameters.AddWithValue("@verified", _lot.GetVerified());
                    command.Parameters.AddWithValue("@reservePrice", _lot.GetReservePrice());
                    command.Parameters.AddWithValue("@memberReference", _lot.GetMemberReference());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Haalt alle Lot instanties uit de database en voegt ze toe aan de lijst van lots.
        public static List<Lot> ReadLots()
        {
            // Implementatie hier
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                lots.Clear();
                string qry = "SELECT id, auctionId, vendorId, bookletId, lotNumber, description, perfType, perfCondition, verified, reservePrice, memberReference FROM LOT";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lot lot = new Lot(
                                (int)reader["id"],
                                auctions.FirstOrDefault(a => a.GetId() == (int)reader["auctionId"]),
                                members.FirstOrDefault(m => m.GetId() == (int)reader["vendorId"]),
                                booklets.FirstOrDefault(b => b.GetId() == (int)reader["bookletId"]),
                                (int)reader["lotNumber"],
                                (string)reader["description"],
                                (string)reader["perfType"],
                                (string)reader["perfCondition"],
                                (int)reader["verified"],
                                (decimal)reader["reservePrice"],
                                reader["memberReference"] == DBNull.Value ? string.Empty : (string)reader["memberReference"]);

                            lots.Add(lot);
                        }
                    }
                }
                connection.Close();
            }
            return lots;
        }

        // Update een instantie Lot in de database aan de hand van het Id.
        public static void UpdateLot(Lot _lot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry =
                    "UPDATE LOT " +
                    "SET " +
                    "auctionId = @auctionId, " +
                    "vendorId = @vendorId, " +
                    "bookletId = @bookletId, " +
                    "lotNumber = @lotNumber, " +
                    "description = @description, " +
                    "perfType = @perfType, " +
                    "perfCondition = @perfCondition, " +
                    "verified = @verified, " +
                    "reservePrice = @reservePrice, " +
                    "memberReference = @memberReference " +
                    "WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _lot.GetId());
                    command.Parameters.AddWithValue("@auctionId", _lot.GetAuctionId().GetId());
                    command.Parameters.AddWithValue("@vendorId", _lot.GetVendorId().GetId());
                    command.Parameters.AddWithValue("@bookletId", _lot.GetBookletId().GetId());
                    command.Parameters.AddWithValue("@lotNumber", _lot.GetLotNumber());
                    command.Parameters.AddWithValue("@description", _lot.GetDescription());
                    command.Parameters.AddWithValue("@perfType", _lot.GetPerfType());
                    command.Parameters.AddWithValue("@perfCondition", _lot.GetPerfCondition());
                    command.Parameters.AddWithValue("@verified", _lot.GetVerified());
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
        public static void CreateAuction(Auction _auction)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "INSERT INTO AUCTION(name, auctioneerId ,description, startDate, endDate) VALUES(@name, @auctioneerId, @description, @startDate, @endDate)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    //command.Parameters.AddWithValue("@auctioneerID",_auction.GetId());
                    command.Parameters.AddWithValue("@name", _auction.GetName());
                    command.Parameters.AddWithValue("@auctioneerId", _auction.GetAuctioneerId().GetId());
                    command.Parameters.AddWithValue("@startDate", _auction.GetStartDate());
                    command.Parameters.AddWithValue("@endDate", _auction.GetEndDate());
                    command.Parameters.AddWithValue("@description", _auction.GetDescription());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Haalt alle Auction instanties uit de database en voegt ze toe aan de lijst van auctions.
        public static List<Auction> ReadAuctions()
        {
            auctions.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "SELECT id, auctioneerId, name, description, startDate, endDate FROM AUCTION";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Auction auction = new Auction(
                                (int)reader["id"],
                                members.FirstOrDefault(a => a.GetId() == (int)reader["auctioneerId"]),
                                (string)reader["name"],
                                (string)reader["description"],
                                (DateTime)reader["startDate"],
                                (DateTime)reader["endDate"]);

                            auctions.Add(auction);
                        }
                    }
                }
                connection.Close();
            }
            return auctions;
        }

        // Update een instantie Auction in de database aan de hand van het Id.
        public static void UpdateAuction(Auction _auction)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "UPDATE AUCTION SET name = @name, description = @description, startDate = @startDate, endDate = @endDate WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _auction.GetId());
                    command.Parameters.AddWithValue("@auctioneerId", _auction.GetAuctioneerId());
                    command.Parameters.AddWithValue("@name", _auction.GetName());
                    command.Parameters.AddWithValue("@startDate", _auction.GetStartDate());
                    command.Parameters.AddWithValue("@endDate", _auction.GetEndDate());
                    command.Parameters.AddWithValue("@description", _auction.GetDescription());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Verwijdert een instantie Auction uit de database aan de hand van het Id.
        public static void DeleteAuction(Auction _auction)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry = "DELETE FROM AUCTION WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@id", _auction.GetAuctioneerId());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

        }


        //CRUD Lot2Mem
        // Maakt een instantie Lot2Mem aan in de database.
        public static void CreateLot2Mem(Lot2Mem _lot2Mem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry =
                    "INSERT INTO LOT2MEM(buyerId, lotId ,timeStamp, price) " +
                    "VALUES(@buyerId, @lotId ,@timeStamp, @price)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    //command.Parameters.AddWithValue("@auctioneerID",_auction.GetId());
                    command.Parameters.AddWithValue("@buyerId", _lot2Mem.GetBuyerId().GetId());
                    command.Parameters.AddWithValue("@lotId", _lot2Mem.GetLotId().GetId());
                    command.Parameters.AddWithValue("@timeStamp", _lot2Mem.GetTimeStamp());
                    command.Parameters.AddWithValue("@price", _lot2Mem.GetPrice());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Haalt alle Lot2Mem instanties uit de database en voegt ze toe aan de lijst van lot2Mems.
        public static void ReadLot2Mems()
        {
            lot2mems.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry =
                    "SELECT buyerId, lotId ,timeStamp, price " +
                    "FROM LOT2MEM";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lot2Mem lot2mem = new Lot2Mem(
                                members.FirstOrDefault(m => m.GetId() == (int)reader["buyerId"]),
                                lots.FirstOrDefault(l => l.GetId() == (int)reader["lotId"]),
                                (DateTime)reader["timeStamp"],
                                (decimal)reader["price"]);

                            lot2mems.Add(lot2mem);
                        }
                    }
                }
                connection.Close();
            }
        }

        // Update een instantie Lot2Mem in de database aan de hand van het Id.
        public static void UpdateLot2Mem(Lot2Mem _lot2Mem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry =
                    "UPDATE LOT2MEM SET timeStamp = @timeStamp, price = @price " +
                    "WHERE buyerId = @buyerId AND lotId = @lotId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@buyerId", _lot2Mem.GetBuyerId().GetId());
                    command.Parameters.AddWithValue("@lotId", _lot2Mem.GetLotId().GetId());
                    command.Parameters.AddWithValue("@timeStamp", _lot2Mem.GetTimeStamp());
                    command.Parameters.AddWithValue("@price", _lot2Mem.GetPrice());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Verwijdert een instantie Lot2Mem uit de database aan de hand van het Id.
        public static void DeleteLot2Mem(Lot2Mem _lot2Mem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string qry =
                    "DELETE FROM LOT2MEM " +
                    "WHERE buyerId = @buyerId AND lotId = @lotId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@buyerId", _lot2Mem.GetBuyerId().GetId());
                    command.Parameters.AddWithValue("@lotId", _lot2Mem.GetLotId().GetId());
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

    }
}
