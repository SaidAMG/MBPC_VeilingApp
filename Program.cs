using MBPC_VeilingApp;
using MBPC_VeilingApp.Classes;
using System;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Security.Cryptography;

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

//DAL.RefreshDAL()

// implementatie komt hier 
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
//----------------------------------------------------------------------------------------------------> Voorbeeld van Jeroen

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane
//List<Lot> sortedLots = Lot.ReadLot();

//for (int i = 0; i < sortedLots.Count; i++)
//{
//    sortedLots[i].SetLotId(i + 1); // Stel een nieuw lotnummer in 
//    Console.WriteLine(sortedLots[i].GetLotNumber());
//}

//foreach (Lot lot in sortedLots)
//{
//    DAL.UpdateLot(lot);
//}

//----------------------------------------------------------------------------------------------------> Voorbeeld van Kane


//----------------------------------------------------------------------------------------------------> Test Lot2Mem

// implementatie komt hier 

//----------------------------------------------------------------------------------------------------> Test Lot2Mem

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

// implementatie komt hier

//----------------------------------------------------------------------------------------------------> Implementatie veilinglijs aanmaken

