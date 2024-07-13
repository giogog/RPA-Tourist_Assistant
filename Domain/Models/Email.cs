using System;
using System.Collections.Generic;

namespace Domain.Models;
public class Email
{
    private int _numberOfTourists = 1;
    private List<string> _name;
    private List<string> _surname;
    private List<string> _birthDate;
    private List<string> _gender;
    private List<string> _passportNum;
    private List<string> _passportCountry;
    private string _journeyType;
    private string _flightType;
    private string _departureAirport;
    private string? _arrivalAirport;
    private string _flightNum;
    private string _arrivalDate;
    private string _address;
    private string _phoneNumber;

    public int NumberOfTourists
    {
        get => _numberOfTourists;
        set
        {
            try
            {
                _numberOfTourists = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting NumberOfTourists: {ex.Message}");
                throw;
            }
        }
    }

    public List<string> Name
    {
        get => _name;
        set
        {
            try
            {
                _name = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting Name: {ex.Message}");
                throw;
            }
        }
    }

    public List<string> Surname
    {
        get => _surname;
        set
        {
            try
            {
                _surname = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting Surname: {ex.Message}");
                throw;
            }
        }
    }

    public List<string> BirthDate
    {
        get => _birthDate;
        set
        {
            try
            {
                _birthDate = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting BirthDate: {ex.Message}");
                throw;
            }
        }
    }

    public List<string> Gender
    {
        get => _gender;
        set
        {
            try
            {
                _gender = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting Gender: {ex.Message}");
                throw;
            }
        }
    }

    public List<string> PassportNum
    {
        get => _passportNum;
        set
        {
            try
            {
                _passportNum = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting PassportNum: {ex.Message}");
                throw;
            }
        }
    }

    public List<string> PassportCountry
    {
        get => _passportCountry;
        set
        {
            try
            {
                _passportCountry = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting PassportCountry: {ex.Message}");
                throw;
            }
        }
    }

    public string JourneyType
    {
        get => _journeyType;
        set
        {
            try
            {
                _journeyType = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting JourneyType: {ex.Message}");
                throw;
            }
        }
    }

    public string FlightType
    {
        get => _flightType;
        set
        {
            try
            {
                _flightType = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting FlightType: {ex.Message}");
                throw;
            }
        }
    }

    public string DepartureAirport
    {
        get => _departureAirport;
        set
        {
            try
            {
                _departureAirport = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting DepartureAirport: {ex.Message}");
                throw;
            }
        }
    }

    public string? ArrivalAirport
    {
        get => _arrivalAirport;
        set
        {
            try
            {
                _arrivalAirport = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting ArrivalAirport: {ex.Message}");
                
            }
        }
    }
    public string FlightNum
    {
        get => _flightNum;
        set
        {
            try
            {
                _flightNum = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting FlightNum: {ex.Message}");
                throw;
            }
        }
    }
    
    public string ArrivalDate
    {
        get => _arrivalDate;
        set
        {
            try
            {
                _arrivalDate = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting ArrivalDate: {ex.Message}");
                throw;
            }
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            try
            {
                _address = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting Address: {ex.Message}");
                throw;
            }
        }
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            try
            {
                _phoneNumber = value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting PhoneNumber: {ex.Message}");
                throw;
            }
        }
    }
}
