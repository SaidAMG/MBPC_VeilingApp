using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPC_VeilingApp.Classes
{
    public class Lot2Mem
    {
        private Member buyerId;
        private Lot lotId;
        private DateTime timeStamp;
        private decimal price;

        public Lot2Mem(Member _buyerId, Lot _lotId, DateTime _timeStamp, decimal _price)
        {
            buyerId = _buyerId;
            lotId = _lotId;
            timeStamp = _timeStamp;
            price = _price;
        }

        //Getters
        public Member GetBuyerId()
        {
            return buyerId;
        }

        public Lot GetLotId()
        {
            return lotId;
        }

        public DateTime GetTimeStamp()
        {
            return timeStamp;
        }

        public decimal GetPrice()
        {
            return price;
        }

        //Seters
        public void SetBuyerId(Member _buyerId)
        {
            buyerId = _buyerId;
        }

        public void SetLotId(Lot _lotId)
        {
            lotId = _lotId;
        }

        public void SetTimeStamp(DateTime _timeStamp)
        {
            timeStamp = _timeStamp;
        }

        public void SetPrice(decimal _price)
        {
            price = _price;
        }

        //DAL functies
        public void CreateLot2MemDAL()
        {
            DAL.CreateLot2Mem(this);
        }
        public void UpdateLot2MemDAL(DateTime _timeStamp, decimal _price)
        {
            DAL.UpdateLot2Mem(new Lot2Mem(buyerId, lotId, _timeStamp, _price));
        }
        public void DeleteLot2MemDAL()
        {
            DAL.DeleteLot2Mem(this);
        }
    }
}
