using MBPC_VeilingApp.Classes;

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken
void GenerateAuctionList()
{
    List<Auction> auctions = Auction.ReadAuction();

    Console.WriteLine("Selecteer een veiling waar je de lijst van wil:");
    Console.WriteLine();
    foreach (Auction a in auctions)
    {
        Console.WriteLine($"ID: {a.GetId()} \nNaam: {a.GetName()} \nBeschrijving: {a.GetDescription()}");
        Console.WriteLine();
    }

    Console.Write("Selecteer ID: ");

    int selectedAuction = 0;

    try
    {
        selectedAuction = Int32.Parse(Console.ReadLine());

        if (auctions.Any(a => a.GetId() == selectedAuction))
        {
            List<Lot> lots = Lot.ReadLot().Where(l => l.GetAuctionId().GetId() == selectedAuction).ToList(); // Verondersteld dat je de ReadLot-methode hebt toegevoegd in de klasse
            List<Lot> sortedLots = Sort.SortLotsByName(lots);

            for (int i = 0; i < sortedLots.Count; i++)
            {
                sortedLots[i].SetLotNumber(i + 1); // Stel een nieuw lotnummer in 
            }

            foreach (Lot l in sortedLots)
            {
                l.UpdateLot();
            }

            PDFGenerator.GeneratePDF(sortedLots);

            Console.WriteLine("PDF is aangemaakt, druk op een toets om af te sluiten...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Verkeerde invoer: Ingevoerde ID bestaat niet.");
            GenerateAuctionList();
        }
    }
    catch
    {
        Console.WriteLine("Verkeerde invoer: Het moet een getal zijn");
        GenerateAuctionList();
    }
}

GenerateAuctionList();
//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken