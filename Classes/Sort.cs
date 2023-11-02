using MBPC_VeilingApp;
using System.Text.RegularExpressions;

namespace MBPC_VeilingApp.Classes
{
    internal class Sort
    {
        private class CustomComparer : IComparer<List<object>>
        {
            public int Compare(List<object> x, List<object> y)
            {
                for (int i = 0; i < Math.Min(x.Count, y.Count); i++)
                {
                    if (x[i] is int && y[i] is int)
                    {
                        int numX = (int)x[i];
                        int numY = (int)y[i];

                        int result = numX.CompareTo(numY);

                        if (result != 0)
                        {
                            return result;
                        }
                    }
                    else
                    {
                        string strX = x[i].ToString();
                        string strY = y[i].ToString();

                        int result = strX.CompareTo(strY);

                        if (result != 0)
                        {
                            return result;
                        }
                    }
                }

                return x.Count.CompareTo(y.Count);
            }
        }

        public List<Lot> SortLotsByAuctionIdAndBookletName(List<Lot> lots)
        {
            List<Lot> sortedLotsByName = lots;
            List<Lot> sorted = sortedLotsByName.OrderBy(lot =>
            {
                string bookletName = lot.GetBookletId().GetName();
                List<string> parts = Regex.Split(bookletName, @"(?<=[0-9])(?=[A-Za-z])").ToList();
                List<object> parsedParts = new List<object>();

                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int number))
                    {
                        parsedParts.Add(number);
                    }
                    else
                    {
                        parsedParts.Add(part);
                    }
                }

                return parsedParts;
            }, new CustomComparer()).ToList();

            return sortedLotsByName;
        }
    }
}



