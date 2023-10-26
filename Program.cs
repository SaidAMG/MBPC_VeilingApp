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
Lot lot = new Lot(0, 0, 0, 0, 0, "", "", "", 0, 0, "");

try
{
    lot = new Lot(3679, 1, 42, 1, 1, "the queen", "AP", "Good", 11, 50, "test");
}
catch(ArgumentException ex)
{
    Console.WriteLine("Er is een uitzondering opgetreden: " + ex.Message);
}


DAL.CreateLot(lot);
DAL.UpdateLot(lot);
DAL.DeleteLot(lot);
DAL.ReadLots();

List<Lot> lots = DAL.lots;

foreach(Lot l in lots)
{
    Console.WriteLine($"{l.GetId()},{l.GetAuctionId()},{l.GetVendorId()},{l.GetBookletId()},{l.GetLotId()},{l.GetDescription()},{l.GetPerfType()},{l.GetPerfCondition()},{l.GetVerified()},{l.GetReservePrice()},{l.GetMemberReference()}");
}
//----------------------------------------------------------------------------------------------------> Voorbeeld van Jeroen

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane



//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken