using MBPC_VeilingApp;
using MBPC_VeilingApp.Classes;
using System.Data.SqlClient;

//----------------------------------------------------------------------------------------------------> Voorbeeld van Saïd
//try
//{
//    Booklet booklet = new Booklet(284, "test2", "roodkapje1", "STILL THE GOAT");
//}
//catch (ArgumentException ex)
//{
//    // Bij een fout laat die ziet wat er fout is gegaan zonder dat het programma crashed.
//    Console.WriteLine("Er is een uitzondering opgetreden: " + ex.Message);
//}


//DAL.CreateBooklet(booklet);
//DAL.UpdateBooklet(booklet);
//DAL.DeleteBooklet(booklet);
//DAL.ReadBooklets();

//List<Booklet> booklets = DAL.booklets;

//foreach(Booklet b in booklets)
//{
//    Console.WriteLine($"{b.GetId()},{b.GetName()},{b.GetPane()},{b.GetDescription()}");
//}
//----------------------------------------------------------------------------------------------------> Voorbeeld van Saïd


//----------------------------------------------------------------------------------------------------> Voorbeeld van Dennis
//Member member = new Member(82, "Dennis", "Bückers", "Nieuw Eyckholt", "Heerlen", "6419DJ", "Holland", 1401, "2105449buckers@zuyd.nl", DateTime.Parse("1998-07-19"), DateTime.Parse("2023-10-24"), "0625076277");

//DAL.CreateMember(member);
//DAL.ReadMembers();
//DAL.UpdateMember(member);
//DAL.DeleteMember(member);


//List<Member> members = DAL.members;

//foreach (Member m in members)
//{
//    Console.WriteLine($"{m.GetId()},{m.GetFirstName()},{m.GetLastName()},{m.GetAddress()},{m.GetZipCode()},{m.GetCountry()},{m.GetMemberNumber()},{m.GetEmail()},{m.GetBirthDate()},{m.GetMemberNumber()},{m.GetTelephoneNumber()} ");
//}
//----------------------------------------------------------------------------------------------------> Voorbeeld van Dennis

//----------------------------------------------------------------------------------------------------> Voorbeeld van Jeroen

// implementatie komt hier 
//Lot lot = new Lot(0, 0, 0, 0, 0, "", "", "", 0, 0, "");

//try
//{
//    lot = new Lot(3679, 1, 42, 1, 1, "the queen", "AP", "Good", 11, 50, "test");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Er is een uitzondering opgetreden: " + ex.Message);
//}


//DAL.CreateLot(lot);
//DAL.UpdateLot(lot);
//DAL.DeleteLot(lot);
//DAL.ReadLots();

//List<Lot> lots = DAL.lots;

//foreach (Lot l in lots)
//{
//    Console.WriteLine($"{l.GetId()},{l.GetAuctionId()},{l.GetVendorId()},{l.GetBookletId()},{l.GetLotNumber()},{l.GetDescription()},{l.GetPerfType()},{l.GetPerfCondition()},{l.GetVerified()},{l.GetReservePrice()},{l.GetMemberReference()}");
//}
//----------------------------------------------------------------------------------------------------> Voorbeeld van Jeroen

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane
//Auction auction = new Auction(3, 1, "A215", "2022 Fall Auction", DateTime.Now, DateTime.Now);

//DAL.CreateAuction(auction);
//DAL.UpdateAuction(auction);
//DAL.DeleteAuction(auction);
//DAL.ReadAuctions();

//List<Auction> auctions = DAL.auctions;

//foreach (Auction b in auctions)
//{
//    Console.WriteLine($"{b.GetId()},{b.GetName()},{b.GetStartDate()},{b.GetDescription()} {b.GetEndDate()}");
//}

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane


//----------------------------------------------------------------------------------------------------> Test Lot2Mem

//DAL.RefreshDAL();
////  Maak een bieding op een lot. pakt de 1e member en lot uit het DAL.
//Lot2Mem lot2Mem = new Lot2Mem(DAL.members.FirstOrDefault(), DAL.lots.FirstOrDefault(), DateTime.Now, 2.60M);
////DAL.CreateLot2Mem(lot2Mem);
////DAL.UpdateLot2Mem(lot2Mem);
////DAL.DeleteLot2Mem(lot2Mem);

//Console.WriteLine("|Buyer's First Name".PadRight(20) + "|Lot Description".PadRight(101) + "|Time Stamp".PadRight(25) + "|Bid Price".PadRight(20)+ "|");
//Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
//foreach (Lot2Mem l in DAL.lot2mems)
//{
//    string buyerFirstName = "|" + l.GetBuyerId().GetFirstName();
//    string lotDescription = "|" + l.GetLotId().GetDescription();
//    string timeStamp = "|" + l.GetTimeStamp().ToString(); // Converteer naar een string als dat nodig is
//    string price = "|" + l.GetPrice().ToString(); // Converteer naar een string als dat nodig is

//    // Afdrukken met kolommen
//    Console.WriteLine(buyerFirstName.PadRight(20) + lotDescription.PadRight(40) + timeStamp.PadRight(25) + price.PadRight(20) + "|");
//}

//----------------------------------------------------------------------------------------------------> Test Lot2Mem

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

