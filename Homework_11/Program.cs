using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Homework_11
{
    enum MenuItem
    {
        TaskCity = '!',
        TaskCountry = '$'
    }

    public class City
    {
        public string nameCity;
        public string nameRegion;
        public string nameCountry;
        public double populationCity;
        public string postCodeCity;
        public string areaCode;
        public int areaCity;
        public string foundedCity;
        public string nameCityCountry { get; set; }
        public City(string namecityCountry)
        {
            nameCity = "Kharkiv";
            nameRegion = "Kharkiv region";
            nameCountry = "Ukraine";
            populationCity = 1.419;
            postCodeCity = "61000 - 62499";
            areaCode = "57";
            areaCity = 310;
            foundedCity = "1654";
            nameCityCountry = namecityCountry;
        }

        public void ShowCityInfo() => Console.WriteLine($"City Name: {nameCity} \nRegion Name: {nameRegion} \nCountry Name: {nameCountry} \nCity Population: {populationCity} million people \nCity PostCode: {postCodeCity} \nArea Code: {areaCode} \nCity Area {areaCity} km\u00B2 \nThe City was founded in {foundedCity}");
    }

    public class Country
    {
        public string nameCountry;
        public string nameContinent;
        public double populationCountry;
        public string countryCode;
        public string nameCapital;
        public string mainLanguageCountry;
        public string secondLanguageCountry;
        public string thirdlanguageCountry;

        public Country()
        {
            nameCountry = "Ukraine";
            nameContinent = "Eurasia";
            populationCountry = 41;
            countryCode = "+380";
            nameCapital = "Kiev";
            mainLanguageCountry = "Ukranian";
            secondLanguageCountry = "Russian";
            thirdlanguageCountry = "English";
        }

        public void ShowCountryInfo()
        {
            Console.WriteLine($"Country Name: {nameCountry} \nContinent Name: {nameContinent} \nCountry Population: {populationCountry} million people \nCountry Code: {countryCode} \nCapital Name: {nameCapital} \nMain Language in Ukraine: {mainLanguageCountry} \nSecond Language in Ukraine: {secondLanguageCountry} \nThird Language in Ukraine: {thirdlanguageCountry} \n\nList of the fifty largest cities in Ukraine: ");
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
                    Console.WriteLine($"If You want to launch City Task: Press: {(char)MenuItem.TaskCity} \nIf You want to launch Country Task: Press: {(char)MenuItem.TaskCountry}");
                    var menuSelect = (char)Console.Read();
                    Console.ReadLine();
                    var currentSelect = (MenuItem)menuSelect;

                    if (menuSelect != ((char)MenuItem.TaskCity) && menuSelect != ((char)MenuItem.TaskCountry))
                    {
                        throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                    }

                    switch (currentSelect)
                    {
                        case MenuItem.TaskCity:
                            {
                                var city = new City(string.Empty);
                                city.ShowCityInfo();
                                break;
                            }
                        case MenuItem.TaskCountry:
                            {
                                var country = new Country();
                                country.ShowCountryInfo();

                                var countryCities = new List<City>
                                {
                                    new City("\nKyiv"), new City("Kharkiv"), new City("Odesa"), new City("Dnipro"), new City("Zaporizhzhia"),
                                    new City("Lviv"), new City("Kryvyi Rih"), new City("Mykolaiv"), new City("Mariupol"), new City("Vinnytsia"),
                                    new City("Kherson"), new City("Poltava"), new City("Chernihiv"), new City("Cherkasy"), new City("Sumy"),
                                    new City("Zhytomyr"), new City("Khmelnytskyi"), new City("Chernivtsi"), new City("Rivne"), new City("Kropyvnytskyi"),
                                    new City("Ivano - Frankivsk"), new City("Ternopil"), new City("Lutsk"), new City("Bila Tserkva"), new City("Kramatorsk"),
                                    new City("Melitopol"), new City("Uzhhorod"), new City("Berdiansk"), new City("Nikopol"), new City("Sloviansk"),
                                    new City("Brovary"), new City("Sievierodonetsk"), new City("Pavlohrad"), new City("Kamianets - Podilskyi"), new City("Lysychansk"),
                                    new City("Konotop"), new City("Drohobych"), new City("Kovel"), new City("Shostka"), new City("Oleksandriia"),
                                    new City("Mukachevo"), new City("Korosten"), new City("Stryi"), new City("Izmail"), new City("Yevpatoria"),
                                    new City("Bakhmut"), new City("Fastiv"), new City("Alchevsk"), new City("Boyarka"), new City("Chervonohrad"),
                                };
                                foreach (City city in countryCities)
                                {
                                    Console.WriteLine(city.nameCityCountry);
                                }
                                break;
                            }
                    }
                    if (menuSelect == ((char)MenuItem.TaskCity) || menuSelect == ((char)MenuItem.TaskCountry))
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