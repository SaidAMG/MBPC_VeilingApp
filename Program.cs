using MBPC_VeilingApp;
using MBPC_VeilingApp.Classes;
using System;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Security.Cryptography;
//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken



List<Lot> lots = Lot.ReadLot().Where(l => l.GetAuctionId().GetId() == 1).ToList(); // Verondersteld dat je de ReadLot-methode hebt toegevoegd in de klasse
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
//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken