
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

// Roep de PDFGenerator aan om het PDF-document te genereren
PDFGenerator.GeneratePDF();

Console.WriteLine("PDF is aangemaakt, druk op een toets om af te sluiten...");
Console.ReadKey();

//----------------------------------------------------------------------------------------------------> Voorbeeld van Dennis

//----------------------------------------------------------------------------------------------------> Voorbeeld van Jeroen

//DAL.RefreshDAL();

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

//functie voor testen Sort class
// Eerst de lots ophalen uit je DAL of ergens anders

//List<Lot> lots = Lot.ReadLot().Where(l => l.GetAuctionId().GetId() == 1).ToList(); // Verondersteld dat je de ReadLot-methode hebt toegevoegd in de klasse
//lots = RandomizeList(lots);

//List < Lot > sortedLots = Sort.SortLotsByName(lots);

//// Functie om de lijst te randomizen
//static List<T> RandomizeList<T>(List<T> list)
//{
//    Random random = new Random();
//    List<T> randomizedList = new List<T>(list);

//    int n = randomizedList.Count;
//    while (n > 1)
//    {
//        n--;
//        int k = random.Next(n + 1);
//        T value = randomizedList[k];
//        randomizedList[k] = randomizedList[n];
//        randomizedList[n] = value;
//    }

//    return randomizedList;
//}

//foreach (Lot l in sortedLots)
//{
//    Console.WriteLine($"LotId:{l.GetId()} Name: {l.GetBookletId().GetName()}");
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

// implementatie komt hier 

//----------------------------------------------------------------------------------------------------> Test Lot2Mem

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

