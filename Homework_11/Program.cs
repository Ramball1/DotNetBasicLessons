using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_11
{
    enum MenuItem
    {
        TaskCity = '!',
        TaskCountry = '$'
    }

    class City
    {
        public string nameCity;
        public string nameRegion;
        public string nameCountry;
        public double populationCity;
        public string postCodeCity;
        public string areaCode;
        public int areaCity;
        public string foundedCity;

        public City()
        {
            nameCity = "Kharkiv";
            nameRegion = "Kharkiv region";
            nameCountry = "Ukraine";
            populationCity = 1.419;
            postCodeCity = "61000 - 62499";
            areaCode = "57";
            areaCity = 310;
            foundedCity = "1654";
        }

        public void ShowInfo() => Console.WriteLine($"City Name: {nameCity} \nRegion Name: {nameRegion} \nCountry Name: {nameCountry} \nCity Population: {populationCity} million people \nCity PostCode: {postCodeCity} \nArea Code: {areaCode} \nCity Area {areaCity} km\u00B2 \nThe City was founded in {foundedCity}");
    }

    class Country
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

        public void ShowInfo() => Console.WriteLine($"Country Name: {nameCountry} \nContinent Name: {nameContinent} \nCountry Population: {populationCountry} million people \nCountry Code: {countryCode} \nCapital Name: {nameCapital} \nMain Language in Ukraine: {mainLanguageCountry} \nSecond Language in Ukraine: {secondLanguageCountry} \nThird Language in Ukraine: {thirdlanguageCountry}");

        internal class Cities
        {
            public string nameCity1 = string.Empty;
            public string nameCity2 = string.Empty;
            public string nameCity3 = string.Empty;
            public string nameCity4 = string.Empty;
            public string nameCity5 = string.Empty;
            public string nameCity6 = string.Empty;
            public string nameCity7 = string.Empty;
            public string nameCity8 = string.Empty;
            public string nameCity9 = string.Empty;
            public string nameCity10 = string.Empty;
            public string nameCity11 = string.Empty;
            public string nameCity12 = string.Empty;
            public string nameCity13 = string.Empty;
            public string nameCity14 = string.Empty;
            public string nameCity15 = string.Empty;
            public string nameCity16 = string.Empty;
            public string nameCity17 = string.Empty;
            public string nameCity18 = string.Empty;
            public string nameCity19 = string.Empty;
            public string nameCity20 = string.Empty;
            public string nameCity21 = string.Empty;
            public string nameCity22 = string.Empty;
            public string nameCity23 = string.Empty;
            public string nameCity24 = string.Empty;
            public string nameCity25 = string.Empty;
            public string nameCity26 = string.Empty;
            public string nameCity27 = string.Empty;
            public string nameCity28 = string.Empty;
            public string nameCity29 = string.Empty;
            public string nameCity30 = string.Empty;
            public string nameCity31 = string.Empty;
            public string nameCity32 = string.Empty;
            public string nameCity33 = string.Empty;
            public string nameCity34 = string.Empty;
            public string nameCity35 = string.Empty;
            public string nameCity36 = string.Empty;
            public string nameCity37 = string.Empty;
            public string nameCity38 = string.Empty;
            public string nameCity39 = string.Empty;
            public string nameCity40 = string.Empty;
            public string nameCity41 = string.Empty;
            public string nameCity42 = string.Empty;
            public string nameCity43 = string.Empty;
            public string nameCity44 = string.Empty;
            public string nameCity45 = string.Empty;
            public string nameCity46 = string.Empty;
            public string nameCity47 = string.Empty;
            public string nameCity48 = string.Empty;
            public string nameCity49 = string.Empty;
            public string nameCity50 = string.Empty;

            public Cities(string nameCity1, string nameCity2, string nameCity3, string nameCity4, string nameCity5, string nameCity6, string nameCity7, string nameCity8, string nameCity9, string nameCity10, string nameCity11, string nameCity12, string nameCity13, string nameCity14, string nameCity15, string nameCity16, string nameCity17, string nameCity18, string nameCity19, string nameCity20, string nameCity21, string nameCity22, string nameCity23, string nameCity24, string nameCity25, string nameCity26, string nameCity27, string nameCity28, string nameCity29, string nameCity30, string nameCity31, string nameCity32, string nameCity33, string nameCity34, string nameCity35, string nameCity36, string nameCity37, string nameCity38, string nameCity39, string nameCity40, string nameCity41, string nameCity42, string nameCity43, string nameCity44, string nameCity45, string nameCity46, string nameCity47, string nameCity48, string nameCity49, string nameCity50)
            {
                this.nameCity1 = nameCity1;
                this.nameCity2 = nameCity2;
                this.nameCity3 = nameCity3;
                this.nameCity4 = nameCity4;
                this.nameCity5 = nameCity5;
                this.nameCity6 = nameCity6;
                this.nameCity7 = nameCity7;
                this.nameCity8 = nameCity8;
                this.nameCity9 = nameCity9;
                this.nameCity10 = nameCity10;
                this.nameCity11 = nameCity11;
                this.nameCity12 = nameCity12;
                this.nameCity13 = nameCity13;
                this.nameCity14 = nameCity14;
                this.nameCity15 = nameCity15;
                this.nameCity16 = nameCity16;
                this.nameCity17 = nameCity17;
                this.nameCity18 = nameCity18;
                this.nameCity19 = nameCity19;
                this.nameCity20 = nameCity20;
                this.nameCity21 = nameCity21;
                this.nameCity22 = nameCity22;
                this.nameCity23 = nameCity23;
                this.nameCity24 = nameCity24;
                this.nameCity25 = nameCity25;
                this.nameCity26 = nameCity26;
                this.nameCity27 = nameCity27;
                this.nameCity28 = nameCity28;
                this.nameCity29 = nameCity29;
                this.nameCity30 = nameCity30;
                this.nameCity31 = nameCity31;
                this.nameCity32 = nameCity32;
                this.nameCity33 = nameCity33;
                this.nameCity34 = nameCity34;
                this.nameCity35 = nameCity35;
                this.nameCity36 = nameCity36;
                this.nameCity37 = nameCity37;
                this.nameCity38 = nameCity38;
                this.nameCity39 = nameCity39;
                this.nameCity40 = nameCity40;
                this.nameCity41 = nameCity41;
                this.nameCity42 = nameCity42;
                this.nameCity43 = nameCity43;
                this.nameCity44 = nameCity44;
                this.nameCity45 = nameCity45;
                this.nameCity46 = nameCity46;
                this.nameCity47 = nameCity47;
                this.nameCity48 = nameCity48;
                this.nameCity49 = nameCity49;
                this.nameCity50 = nameCity50;
            }

            public void ShowCitiesInfo()
            {
                Console.WriteLine("\nList of the fifty largest cities in Ukraine: " +
                    $"\n\nFirst City: {nameCity1}" +
                    $"\nSecond City: {nameCity2}" +
                    $"\nThird City: {nameCity3}" +
                    $"\nFourth City: {nameCity4}" +
                    $"\nFifth City: {nameCity5}" +
                    $"\nSixth City: {nameCity6}" +
                    $"\nSeventh City: {nameCity7}" +
                    $"\nEighth City: {nameCity8}" +
                    $"\nNinth City: {nameCity9}" +
                    $"\nTenth City: {nameCity10}" +
                    $"\nEleventh City: {nameCity11}" +
                    $"\nTwelfth City: {nameCity12}" +
                    $"\nThirteenth City: {nameCity13}" +
                    $"\nFourteenth City: {nameCity14}" +
                    $"\nFifteenth City: {nameCity15}" +
                    $"\nSixteenth City: {nameCity16}" +
                    $"\nSeventeenth City: {nameCity17}" +
                    $"\nEighteenth City: {nameCity18}" +
                    $"\nNineteenth City: {nameCity19}" +
                    $"\nTwentieth City: {nameCity20}" +
                    $"\nTwenty-first City: {nameCity21}" +
                    $"\nTwenty-second City: {nameCity22}" +
                    $"\nTwenty-third City: {nameCity23}" +
                    $"\nTwenty-fourth City: {nameCity24}" +
                    $"\nTwenty-fifth: {nameCity25}" +
                    $"\nTwenty-sixth City: {nameCity26}" +
                    $"\nTwenty-seventh City: {nameCity27}" +
                    $"\nTwenty-eighth City: {nameCity28}" +
                    $"\nTwenty-ninth City: {nameCity29}" +
                    $"\nThirtieth City: {nameCity30}" +
                    $"\nThirty-first City: {nameCity31}" +
                    $"\nThirty-second City: {nameCity32}" +
                    $"\nThirty-third City: {nameCity33}" +
                    $"\nThirty-fourth City: {nameCity34}" +
                    $"\nThirty-fifth City: {nameCity35}" +
                    $"\nThirty-sixth City: {nameCity36}" +
                    $"\nThirty-seventh City: {nameCity37}" +
                    $"\nThirty-eighth City: {nameCity38}" +
                    $"\nThirty-ninth City: {nameCity39}" +
                    $"\nFortieth City: {nameCity40}" +
                    $"\nForty-first City: {nameCity41}" +
                    $"\nForty-second City: {nameCity42}" +
                    $"\nForty-third City: {nameCity43}" +
                    $"\nForty-fourth City: {nameCity44}" +
                    $"\nForty-fifth: {nameCity45}" +
                    $"\nForty-sixth City: {nameCity46}" +
                    $"\nForty-seventh City: {nameCity47}" +
                    $"\nForty-eighth City: {nameCity48}" +
                    $"\nForty-ninth City: {nameCity49}" +
                    $"\nFiftieth City: {nameCity50}");
            }
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
                                var city = new City();
                                city.ShowInfo();

                                break;
                            }
                        case MenuItem.TaskCountry:
                            {
                                var country = new Country();
                                country.ShowInfo();
                                var cities = new Country.Cities("Kyiv", "Kharkiv", "Odesa", "Dnipro", "Zaporizhzhia", "Lviv", "Kryvyi Rih", "Mykolaiv", "Mariupol", "Vinnytsia", "Kherson", "Poltava", "Chernihiv", "Cherkasy", "Sumy", "Zhytomyr", "Khmelnytskyi", "Chernivtsi", "Rivne", "Kropyvnytskyi", "Ivano-Frankivsk", "Ternopil", "Lutsk", "Bila Tserkva", "Kramatorsk", "Melitopol", "Uzhhorod", "Berdiansk", "Nikopol", "Sloviansk", "Brovary", "Sievierodonetsk", "Pavlohrad", "Kamianets-Podilskyi", "Lysychansk", "Konotop", "Drohobych", "Kovel", "Shostka", "Oleksandriia", "Mukachevo", "Korosten", "Stryi", "Izmail", "Yevpatoria", "Bakhmut", "Fastiv", "Alchevsk", "Boyarka", "Chervonohrad");
                                cities.ShowCitiesInfo();

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