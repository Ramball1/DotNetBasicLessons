using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework_доп
{
    enum MenuItem
    {
        TaskAirport = '!',
        AircraftAdd = '%',
        AircraftAddStop = '&',
        TaskPC = '$',
    }

    enum MenuAircraft
    {
        PriceCurrency = '$',
    }

    public class Airport
    {
        public List<Aircraft> aircrafts = new List<Aircraft>();

        public Airport(List<Aircraft> aircrafts)
        {
            this.aircrafts = aircrafts;
        }
        public void ShowAircrafts()
        {
            foreach (Aircraft aircraft in aircrafts)
            {
                aircraft.ShowAircraftInfo();
                Console.WriteLine();
            }
        }

        public void AddAircraft(Aircraft aircraft)
        {
            aircrafts.Add(aircraft);
        }
    }

    public class Aircraft
    {
        public string _modelName = string.Empty;
        public string _role = string.Empty;
        public string _manufacturer = string.Empty;
        public decimal _price = 0m;
        public string _engineModel = string.Empty;
        public string _maxSpeed = string.Empty;
        public string _maxAltitude = string.Empty;

        public Aircraft(string modelName, string role, string manufacturer, decimal price, string engineModel, string maxSpeed, string maxAltitude)
        {
            _modelName = modelName;
            _role = role;
            _manufacturer = manufacturer;
            _price = price;
            _engineModel = engineModel;
            _maxSpeed = maxSpeed;
            _maxAltitude = maxAltitude;
        }

        public void ShowAircraftInfo()
        {
            Console.WriteLine($"Aircraft Model Name: {_modelName}" +
                $"\nAircraft Role: {_role}" +
                $"\nAircraft Manufacturer: {_manufacturer}" +
                $"\nAircraft Price: {_price}{(char)MenuAircraft.PriceCurrency}" +
                $"\nAircraft Engine Model: {_engineModel}" +
                $"\nAircraft Max Speed: {_maxSpeed}" +
                $"\nAircraft Max Altitude: {_maxAltitude}");
        }
    }

    public class Programm
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                try
                {
                    Console.WriteLine($"If You want to launch Task Airport: Press: {(char)MenuItem.TaskAirport} \nIf You want to launch PC Task: Press: {(char)MenuItem.TaskPC}");
                    var menuSelect = (char)Console.Read();
                    Console.ReadLine();
                    var currentSelect = (MenuItem)menuSelect;

                    if (menuSelect != ((char)MenuItem.TaskAirport) && menuSelect != ((char)MenuItem.TaskPC))
                    {
                        throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                    }

                    switch (currentSelect)
                    {
                        case MenuItem.TaskAirport:
                            {
                                var aircrafts = new List<Aircraft>
                                {
                                   new Aircraft("Boeing 737-800", "Narrow-body airliner", "Boeing Commercial Airplanes", 89000000, "CFM56-7B", "916km/h", "12500m"),
                                   new Aircraft("Airbus", "Wide-body airline", "Airbus", 455000000, "The Rolls-Royse Trent 900", "1098km/h", "13100m"),
                                   new Aircraft("Northrop B-2 Spirit", "Stealth strategic heavy bomber", "Northrop Corporation", 2000000000, "Four General Electric F118-GE-100 turbofans", "1010km/h", "15152m"),
                                };

                                var airport = new Airport(aircrafts);
                                airport.ShowAircrafts();

                                int aircraftMinCount = 3;
                                int aircraftMaxCount = 5;

                                while (aircraftMinCount <= aircraftMaxCount)
                                {
                                    try
                                    {
                                        Console.WriteLine($"If You want to Add Aircraft: Press: {(char)MenuItem.AircraftAdd} \nIf You want to Stop Adding Aircrafts: Press: {(char)MenuItem.AircraftAddStop}");
                                        var menuSelectAction = (char)Console.Read();
                                        Console.ReadLine();
                                        var currentSelectAction = (MenuItem)menuSelectAction;

                                        if (menuSelectAction != ((char)MenuItem.AircraftAdd) && menuSelectAction != ((char)MenuItem.AircraftAddStop))
                                        {
                                            throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                                        }

                                        if (menuSelectAction == ((char)MenuItem.AircraftAddStop))
                                        {
                                            Console.WriteLine("The Final List of your Aircrafts at the airport today: ");
                                            Console.WriteLine();
                                            airport.ShowAircrafts();
                                            break;
                                        }

                                        aircraftMinCount++;

                                        if (aircraftMinCount != aircraftMaxCount)
                                        {
                                            airport.AddAircraft(new Aircraft("Nasa X-43", "Experimental hypersonic UAV", "Micro Craft (airframe), GASL (engine)", 230000000, "scramjet", "10870km/h", "33357m"));
                                            airport.ShowAircrafts();
                                        }

                                        if (aircraftMinCount == aircraftMaxCount)
                                        {
                                            airport.AddAircraft(new Aircraft("An-225 Mriya", "Outsize cargo freight aircraft", "Antonov Serial, Production Plant", 502000000, "D-18T", "850km/h", "10150m"));
                                            airport.ShowAircrafts();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                    if (aircraftMinCount == aircraftMaxCount)
                                    {
                                        Console.WriteLine("Five aircrafts: maximum capacity at the airport today!");
                                        break;
                                    }
                                }
                                break;
                            }
                        case MenuItem.TaskPC:
                            {

                                break;
                            }
                    }
                    if (menuSelect == ((char)MenuItem.TaskAirport) || menuSelect == ((char)MenuItem.TaskPC))
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}