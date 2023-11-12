namespace MBPC_VeilingApp.Classes
{
    public class Sort
    {
        //functie om de gevonden gesorteerde getallen in een lijst te zetten. 
        public static List<Lot> SortLotsByName(List<Lot> lots)
        {
            List<Lot> sortedLots = lots.OrderBy(lot => lot.GetBookletId().GetName(), new AlphanumericComparer()).ToList();
            return sortedLots;
        }

        private class AlphanumericComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                int indexX = 0;
                int indexY = 0;
                //index van wanneer een afwijkende waarde tussen de twee strings word gevonden.

                while (indexX < x.Length && indexY < y.Length)
                {
                    char charX = x[indexX];
                    char charY = y[indexY];

                    //kijken of de waardes hetzelfde zijn, als dit zo is wordt er gekeken naar de volgende waarde door 1 toe te voegen aan indexX en indexY.
                    if (charX == charY)
                    {
                        indexX++;
                        indexY++;
                    }
                    //kijken of de waarde een int is en of deze tussen de 0 en de 9 zit voor beide waardes van X en Y.
                    //vervolgens door gebruik te maken van de GetNumber functie wordt er gekeken wat de cijfers zijn van beide strings, deze worden vervolgens omgezet van string naar int en vergeleken met de compareto functie.
                    //de CompareTo functie vergelijkt de getallen met elkaar en bepaald welke hoger is dan de andere en geeft een waarde hiervoor terug.
                    //wanneer intX hoger is dan intY wordt een 1 terug gegeven, wanneer intY groter is dan intX wordt een -1 teruggegeven, wanneer beide gelijk zijn wordt een 0 terug gegeven.
                    else if (charX >= '0' && charX <= '9' && charY >= '0' && charY <= '9')
                    {
                        string numX = GetNumber(x, ref indexX);
                        string numY = GetNumber(y, ref indexY);

                        int intX = int.Parse(numX);
                        int intY = int.Parse(numY);

                        int numComparison = intX.CompareTo(intY);
                        if (numComparison != 0)
                        {
                            return numComparison;
                        }
                    }
                    //wanneer er geen getallen aanwezig zijn of de getallen niet tussen de 0 en 9 liggen worden de strings direct met elkaar vergeleken
                    else
                    {
                        return charX.CompareTo(charY);
                    }
                }
                //wanneer de while loop voorbij is wordt er gekeken of de lengte van string gelijk is.
                if (indexX < x.Length)
                {
                    return 1;
                }
                if (indexY < y.Length)
                {
                    return -1;
                }

                return 0;
            }
            // functie om te kijken welke cijfers er aanwezig zijn in de gegeven string.
            // startindex is het beginpunt waarbij de strings die eerder zijn opegegeven van elkaar verschillen.
            // vanuit hier wordt gekeken naar hoelang het cijfer is, wanneer iets anders dan een cijfer wordt gevonden stopt de functie en wordt er een waarde terug gegeven die aangeeft hoe lang het getal is.
            private static string GetNumber(string str, ref int index)
            {
                int startIndex = index;
                while (index < str.Length && Char.IsDigit(str[index]))
                {
                    index++;
                }
                return str.Substring(startIndex, index - startIndex);
            }
        }
    }
}









