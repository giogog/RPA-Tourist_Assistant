using System;

namespace Tourist_Assistant.Domain.Models
{
    public class Client
    {
        private int _numberOfTourists = 1;
        private string _name;
        private string _surname;
        private string _birthDate;
        private string? _gender;
        private string _passportNum;
        private string _passportCountry;
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

        public string Name
        {
            get => _name;
            set
            {
                try
                {
                    _name = value.Trim();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error setting Name: {ex.Message}");
                    throw;
                }
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                try
                {
                    _surname = value.Trim();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error setting Surname: {ex.Message}");
                    throw;
                }
            }
        }

        public string BirthDate
        {
            get => _birthDate;
            set
            {
                try
                {
                    _birthDate = value.Trim();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error setting BirthDate: {ex.Message}");
                    throw;
                }
            }
        }

        public string? Gender
        {
            get => _gender;
            set
            {
                try
                {
                    _gender = value?.Trim();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error setting Gender: {ex.Message}");
                    throw;
                }
            }
        }

        public string PassportNum
        {
            get => _passportNum;
            set
            {
                try
                {
                    _passportNum = value.Trim();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error setting PassportNum: {ex.Message}");
                    throw;
                }
            }
        }

        public string PassportCountry
        {
            get => _passportCountry;
            set
            {
                try
                {
                    _passportCountry = value.Trim();
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
                    _journeyType = value.Trim();
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
                    _flightType = value.Trim();
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
                    _departureAirport = value.Trim();
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
                    _arrivalAirport = value?.Trim();
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
                    _flightNum = value.Trim();
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
                    _arrivalDate = value.Trim();
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
                    _address = value.Trim();
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
                    _phoneNumber = value.Trim();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error setting PhoneNumber: {ex.Message}");
                    throw;
                }
            }
        }
    }
}
