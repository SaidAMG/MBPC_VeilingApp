using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPC_VeilingApp.Classes
{
    public class Auction
    {
        private int id;
        private int auctioneerId;
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

        public Auction(int _id, int _auctioneerId, string _name, string _description, DateTime _startDate, DateTime _endDate)
        {
            // Controlle om de kijken of de opgegeven argumenten voldoen aan de database regels
            if (_name.Length > 10) { throw new ArgumentException("Name should be at most 10 characters long."); }
            if (_description.Length > 50) { throw new ArgumentException("Description should be at most 50 characters long."); }

            id = _id;
            auctioneerId = _auctioneerId;
            name = _name;
            description = _description;
            startDate = _startDate;
            endDate = _endDate;
        }

        //Getters
        public int GetId()
        {
            return id;
        }
        public int GetAuctioneerId()
        {
            return auctioneerId;
        }
        public string GetDescription()
        {
            return description;
        }
        public string GetName()
        {
            return name;
        }
        public DateTime GetStartDate()
        {
            return startDate;
        }

        public DateTime GetEndDate()
        {
            return endDate;
        }


        //Setters
        public void SetDescription(string _description)
        {
            description = _description;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetStartDate(DateTime _startDate)
        {
            startDate = _startDate;
        }

        public void SetEndDate(DateTime _endDate)
        {
            endDate = _endDate;
        }

        //DAL functies
        public void CreateAuctionDAL()
        {
            DAL.CreateAuction(this);
        }
        public void UpdateAuctionDAL(int _auctioneerId, string _name, string _description, DateTime _startDate, DateTime _endDate)
        {
            DAL.UpdateAuction(new Auction(id, _auctioneerId, _name, _description, _startDate, _endDate));

        }
        public void DeleteAuctionDAL()
        {
            DAL.DeleteAuction(this);
        }

    }
}

      