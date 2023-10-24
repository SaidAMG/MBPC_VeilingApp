using MBPC_VeilingApp;
using MBPC_VeilingApp.Classes;

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

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Voorbeeld van Dennis

//----------------------------------------------------------------------------------------------------> Voorbeeld van Jeroen

// implementatie komt hier 

//----------------------------------------------------------------------------------------------------> Voorbeeld van Jeroen

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane
Auction auction = new Auction(3, 1, "A215", "2022 Fall Auction", DateTime.Now, DateTime.Now);

//DAL.CreateAuction(auction);
//DAL.UpdateAuction(auction);
//DAL.DeleteAuction(auction);
DAL.ReadAuctions();

List<Auction> auctions = DAL.auctions;

foreach (Auction b in auctions)
{
    Console.WriteLine($"{b.GetId()},{b.GetName()},{b.GetStartDate()},{b.GetDescription()} {b.GetEndDate()}");
}

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane



//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken