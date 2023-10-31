using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPC_VeilingApp.Classes
{
    internal class Sort
    {

        public List<Lot> SortLotsByAuctionId(List<Lot> lots, int auctionId)
        {
            var sortedLots = lots
                .Where(lot => lot.AuctionId == auctionId) // Filter op het gewenste auctionId
                .OrderBy(lot => lot.AuctionId)
                .ThenBy(lot => lot.LotNumber) // Sorteer binnen de veiling op lotnummer (of andere eigenschap)
                .ToList();

            return sortedLots;
        }
    }
}
