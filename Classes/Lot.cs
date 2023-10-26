namespace MBPC_VeilingApp.Classes;
using System;
using System.Numerics;
using System.Xml.Linq;

public class Lot
{ 
	private int id;
	private int auctionId;
	private int vendorId;
	private int bookletId;
	private int lotId;
	private string description;
	private string perfType;
	private string perfCondition;
	private int verified;
	private decimal reservePrice;
    private string memberReference;

    public Lot(int _id, int _auctionId, int _vendorId, int _bookletId, int _lotId, string _description, string _perfType, string _perfCondition, int _verified, decimal _reservePrice, string _memberReference)
	{
		// Controle om de kijken of de opgegeven argumenten voldoen aan de database regels
		if (_memberReference.Length > 10) { throw new ArgumentException("MemberReference should be at most 10 characters long."); }
        if (_description.Length > 100) { throw new ArgumentException("Description should be at most 100 characters long."); }
        if (_perfType.Length > 10) { throw new ArgumentException("PerfType should be at most 10 characters long."); }
        if (_perfCondition.Length > 10) { throw new ArgumentException("PerfCondition should be at most 10 characters long."); }
        string formattedValue = reservePrice.ToString("0.##########"); // Formaat met maximaal 10 decimalen

        if (formattedValue.Length > 12) // 2 extra tekens voor mogelijke decimalen en min-teken
        {
            throw new ArgumentException("reservePrice should be at most 10 characters long.");
        }

        id = _id;
		auctionId = _auctionId;
		vendorId = _vendorId;
		bookletId = _bookletId;
		lotId = _lotId;
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

	public int GetAuctionId()
	{
		return auctionId;
	}

	public int GetVendorId()
	{
		return vendorId;
	}

	public int GetBookletId()
	{
		return bookletId;
	}

	public int GetLotId()
	{
		return lotId;
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

	public void SetAuctionId(int _auctionId)
	{
		auctionId = _auctionId;
	}

	public void SetVendorId(int _vendorId)
	{
		vendorId = _vendorId;
	}

	public void SetLotId(int _lotId)
	{
		lotId = _lotId;
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

	public void UpdateLot(int _auctionId, int _vendroId, int _bookletId, int _lotId, string _memberReference, string _description, string _perftype, string _perfCondition, int _verified, decimal _reservePrice)
	{
		DAL.UpdateLot(new Lot(id, _auctionId, _vendroId, _bookletId, _lotId, _description, _perftype, _perfCondition, _verified, _reservePrice, _memberReference));
	}

	public void DeleteLot()
	{
		DAL.DeleteLot(this);
	}










}

