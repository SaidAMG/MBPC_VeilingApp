using iTextSharp.text;
using iTextSharp.text.pdf;
using MBPC_VeilingApp;
using MBPC_VeilingApp.Classes;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PDFGenerator
{
    public static void GeneratePDF()
    {
        // Maak een nieuw PDF-document
        Document document = new Document();
        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("Veilinglijst.pdf", FileMode.Create));

        document.Open();

        // Definieer een aangepast lettertype voor de titels
        BaseFont titleFontBase = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        Font titleFont = new Font(titleFontBase, 12f);

        // Haal de gegevens op uit de database met behulp van DAL
        DAL.RefreshDAL(); // Zorg ervoor dat de gegevens in de DAL zijn bijgewerkt

        // Sorteer de lots op BookletID
        List<Lot> lots = DAL.lots.OrderBy(l => l.GetBookletId().GetId()).ToList();

        int currentBookletId = -1; // Een sentinelwaarde om te controleren wanneer de booklet verandert

        foreach (Lot lot in lots)
        {
            int bookletId = lot.GetBookletId().GetId();

            // Controleer of de huidige booklet verschilt van de vorige
            if (bookletId != currentBookletId)
            {
                if (currentBookletId != -1) // Voeg geen lege regel toe voor de eerste titel
                {
                    // Voeg een lege regel toe om enige ruimte te creëren tussen de vorige tabel en de nieuwe titel
                    document.Add(Chunk.NEWLINE);
                }

                PdfPTable table = new PdfPTable(new float[] { 1, 1, 2, 1, 1 }); // Dynamische kolombreedtes
                table.WidthPercentage = 100; // Tabel neemt volledige paginabreedte in

                // Voeg de titel "BOOKLET (name)" en de beschrijving als de eerste rij van de tabel in
                Booklet booklet = DAL.booklets.FirstOrDefault(b => b.GetId() == bookletId);
                PdfPCell titleCell = new PdfPCell(new Phrase(booklet.GetName() + booklet.GetDescription() + booklet.GetPane(), titleFont));
                titleCell.Colspan = 5; // De titelcel beslaat alle 5 kolommen
                titleCell.HorizontalAlignment = Element.ALIGN_LEFT; // Links uitgelijnde titel
                titleCell.Border = Rectangle.NO_BORDER; // Verwijder tabelranden voor titelcellen
                titleCell.BorderWidthBottom = 0; // Verwijder onderstreping van titel
                table.AddCell(titleCell);

                // Voeg koppen toe aan de nieuwe tabel
                table.AddCell("Lot number");
                table.AddCell("Perf type");
                table.AddCell("Description");
                table.AddCell("Cond");
                table.AddCell("Price");

                document.Add(table);

                currentBookletId = bookletId;
            }

            // Voeg de gegevens van het huidige lot toe aan de tabel
            PdfPTable dataTable = new PdfPTable(new float[] { 1, 1, 2, 1, 1 }); // Dynamische kolombreedtes
            dataTable.WidthPercentage = 100; // Tabel neemt volledige paginabreedte in
            dataTable.AddCell(lot.GetId().ToString());
            dataTable.AddCell(lot.GetPerfType());
            dataTable.AddCell(lot.GetDescription());
            dataTable.AddCell(lot.GetPerfCondition());
            dataTable.AddCell(lot.GetReservePrice().ToString());

            document.Add(dataTable);
        }

        document.Close();
    }
}
