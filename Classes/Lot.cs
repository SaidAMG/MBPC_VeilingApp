namespace MBPC_VeilingApp.Classes;
using System;

public class Lot
{
    private int id;
    private Auction auctionId;
    private Member vendorId;
    private Booklet bookletId;
    private int lotNumber;
    private string description;
    private string perfType;
    private string perfCondition;
    private int verified;
    private decimal reservePrice;
    private string memberReference;

    public Lot(int _id, Auction _auctionId, Member _vendorId, Booklet _bookletId, int _lotNumber, string _description, string _perfType, string _perfCondition, int _verified, decimal _reservePrice, string _memberReference)
    {
        // Controle om de kijken of de opgegeven argumenten voldoen aan de database regels
        if (_memberReference.Length > 10) { throw new ArgumentException("MemberReference should be at most 10 characters long."); }
        if (_description.Length > 100) { throw new ArgumentException("Description should be at most 100 characters long."); }
        if (_perfType.Length > 10) { throw new ArgumentException("PerfType should be at most 10 characters long."); }
        if (_perfCondition.Length > 10) { throw new ArgumentException("PerfCondition should be at most 10 characters long."); }
        string formattedValue = reservePrice.ToString("000000000.##"); // Formaat met maximaal 10 decimalen

        if (formattedValue.Length > 12) // 2 extra tekens voor mogelijke decimalen en min-teken
        {
            throw new ArgumentException("reservePrice should be at most 10 characters long.");
        }

        id = _id;
        auctionId = _auctionId;
        vendorId = _vendorId;
        bookletId = _bookletId;
        lotNumber = _lotNumber;
        description = _description;
        perfType = _perfType;
        perfCondition = _perfCondition;
        verified = _verified;
        reservePrice = _reservePrice;
        memberReference = _memberReference;
    }
    //getters
    public int GetId()
    {
        return id;
    }

    public Auction GetAuctionId()
    {
        return auctionId;
    }

    public Member GetVendorId()
    {
        return vendorId;
    }

    public Booklet GetBookletId()
    {
        return bookletId;
    }

    public int GetLotNumber()
    {
        return lotNumber;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetPerfType()
    {
        return perfType;
    }

    public string GetPerfCondition()
    {
        return perfCondition;
    }

    public int GetVerified()
    {
        return verified;
    }

    public decimal GetReservePrice()
    {
        return reservePrice;
    }

    public string GetMemberReference()
    {
        return memberReference;
    }
    //setters

    public void SetId(int _id)
    {
        id = _id;
    }

    public void SetAuctionId(Auction _auctionId)
    {
        auctionId = _auctionId;
    }

    public void SetVendorId(Member _vendorId)
    {
        vendorId = _vendorId;
    }

    public void SetLotNumber(int _lotNumber)
    {
        lotNumber = _lotNumber;
    }

    public void SetMemberReference(string _memberReference)
    {
        memberReference = _memberReference;
    }

    public void SetDescription(string _description)
    {
        description = _description;
    }

    public void SetPerfType(string _perfType)
    {
        perfType = _perfType;
    }

    public void SetPerfCondition(string _perfCondition)
    {
        perfCondition = _perfCondition;
    }

    public void SetVerified(int _verified)
    {
        verified = _verified;
    }

    public void SetReservePrice(decimal _reservePrice)
    {
        reservePrice = _reservePrice;
    }

    //DAL functies

    public void CreateLot()
    {
        DAL.CreateLot(this);
    }

    public static List<Lot> ReadLot()
    {
        return DAL.ReadLots();
    }

    public void UpdateLot(Auction _auctionId, Member _vendorId, Booklet _bookletId, int _lotNumber, string _memberReference, string _description, string _perftype, string _perfCondition, int _verified, decimal _reservePrice)
    {
        DAL.UpdateLot(new Lot(id, _auctionId, _vendorId, _bookletId, _lotNumber, _description, _perftype, _perfCondition, _verified, _reservePrice, _memberReference));
    }

    public void DeleteLot()
    {
        DAL.DeleteLot(this);
    }

}

