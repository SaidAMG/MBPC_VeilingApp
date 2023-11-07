namespace MBPC_VeilingApp.Classes
{
    internal class Sort
    {
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

                while (indexX < x.Length && indexY < y.Length)
                {
                    char charX = x[indexX];
                    char charY = y[indexY];

                    if (charX == charY)
                    {
                        indexX++;
                        indexY++;
                    }
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
                    else
                    {
                        return charX.CompareTo(charY);
                    }
                }

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









