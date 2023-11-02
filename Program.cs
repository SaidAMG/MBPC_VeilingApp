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

DAL.RefreshDAL();

//// implementatie komt hier 
//Lot lot = new Lot(0, DAL.auctions.First(), DAL.members.First(), DAL.booklets.First(), 0, "", "", "", 0, 0, "");

//try
//{
//    lot = new Lot(3679, DAL.auctions.First(), DAL.members.First(), DAL.booklets.First(), 1, "the queen", "AP", "Good", 11, 50, "test");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Er is een uitzondering opgetreden: " + ex.Message);
//}

//lot.CreateLot();

//Console.WriteLine(Lot.ReadLot);
// Eerst de lots ophalen uit je DAL of ergens anders

List<Lot> lots = Lot.ReadLot().Where(l => l.GetAuctionId().GetId() == 1).ToList(); // Verondersteld dat je de ReadLot-methode hebt toegevoegd in de klasse

// De LotSorter-klasse gebruiken om de lots te sorteren op auctionId en daarna op naam (name)
Sort lotSorter = new Sort();
List<Lot> sortedLots = lotSorter.SortLotsByAuctionIdAndBookletName(lots);

foreach (Lot l in sortedLots)
{
    Console.WriteLine($"LotId:{l.GetId()} Name: {l.GetBookletId().GetName()}");
}
//Nu heb je de gesorteerde lots in de 'sortedLots'-lijst, gesorteerd op auctionId en vervolgens op naam.
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

// implementatie komt hier 

//----------------------------------------------------------------------------------------------------> Test Lot2Mem

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

