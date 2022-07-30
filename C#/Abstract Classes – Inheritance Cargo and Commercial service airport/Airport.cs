using System;

abstract class Airport
{
    private string _iataAirportCode;
    private string _name;
    private string _city;
	private int _noOfFlights;
    public Airport(string _iataAirportCode,string _name,string _city,int _noOfFlights){
        this._iataAirportCode=_iataAirportCode;
        this._name=_name;
        this._city=_city;
        this._noOfFlights=_noOfFlights;
    }
    public int NoOfFlights{
        get{ return _noOfFlights;}
        set{_noOfFlights=value;}
    }
    abstract public int  calculate();
    
}