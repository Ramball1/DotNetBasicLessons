using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework_7
{
    enum MenuItem
    {
        Task1 = '!',
        Task2 = '$',
        Task3 = '?',
        Task4 = '#',
        Task5 = '%'
    }

    public class Program
    {
        public static double Exponentiation(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }

        public static int TheSumOfTheNumbersInTheRange(int num1, int num2)
        {
            int sum = 0;
            int counter = 0;

            for (int i = num1; i <= num2; i++)
            {
                sum += i;
                counter++;
            }

            return sum;
        }

        public static int IsPerfect(int num1, int num2)
        {
            int totalPerfectNumber = 0;

            while (num1 <= num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    int variableValue = 1;
                    int sumDivide = 0;

                    while (variableValue < i)
                    {
                        if (i % variableValue == 0 && i != variableValue)
                        {
                            sumDivide += variableValue;
                        }
                        variableValue++;
                    }

                    if (sumDivide == num1)
                    {
                        Console.WriteLine($"Congratulations, Your number: {num1} is perfect because Sum Divide: {sumDivide} /////////////////////////////////////////////////// \n- большое количество слэшей чтобы если введете большой диапазон было проще найти идеальные(ое) числа(о) при скролле :)");
                        totalPerfectNumber++;

                    }

                    if (sumDivide != num1)
                    {
                        Console.WriteLine($"Sorry, Your number: {num1} isn't perfect beacuse Sum Divide: {sumDivide}");
                    }

                    num1++;

                    Console.WriteLine();
                }
            }

            return totalPerfectNumber;
        }

        public static string Card(int Numbercard, int Suit)
        {
            const string Six = "6 ";
            const string Seven = "7 ";
            const string Eight = "8 ";
            const string Nine = "9 ";
            const string Ten = "10 ";
            const string Jack = "Jack ";
            const string Queen = "Queen ";
            const string King = "King ";
            const string Ace = "Ace ";

            const string Clubs = "Clubs ";
            const string Diamonds = "Diamonds ";
            const string Hearts = "Hearts ";
            const string Spades = "Spades ";

            string[] Numberscard = { Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace };
            string[] Suits = { Clubs, Diamonds, Hearts, Spades };

            string cardNumber = Numberscard[Numbercard - 1];
            string suit = Suits[Suit - 1];

            string yourCard = cardNumber + suit;

            return yourCard;
        }

        public static void LuckyOrUnluckyNumber()
        {
            const int MinDigit = 1;
            const int MaxDigit = 9;
            const int ArrSize = 6;
            var arr = new int[ArrSize];
            var rnd = new Random();

            for (int i = 0; i < ArrSize; i++)
            {
                arr[i] = rnd.Next(MinDigit, MaxDigit);
            }

            Console.Write("Your 6-digit number: ");

            foreach (var digit in arr)
            {
                Console.Write($"{digit}");
            }

            var num6FirstDigit = arr[0];
            var num6SecondDigit = arr[1];
            var num6ThirdDigit = arr[2];
            var num6FourthDigit = arr[3];
            var num6FifthDigit = arr[4];
            var num6SixthDigit = arr[5];

            var nums6FirstThreeDigitSum = num6FirstDigit + num6SecondDigit + num6ThirdDigit;
            var nums6LastThreeDigits = num6FourthDigit + num6FifthDigit + num6SixthDigit;

            if (nums6FirstThreeDigitSum != nums6LastThreeDigits)
            {
                Console.WriteLine($"\n\nИзвините, у вас НЕ Счастливое Число потому что: Сумма Трех Первых Чисел - {nums6FirstThreeDigitSum} не равна Сумме Трех Последних Чисел - {nums6LastThreeDigits}");
            }
            if (nums6FirstThreeDigitSum == nums6LastThreeDigits)
            {
                Console.WriteLine($"\n\nПоздравляем, у вас Счастливое Число потому что: Сумма Трех Первых Чисел - {nums6FirstThreeDigitSum} равна Сумме Трех Последних Чисел - {nums6LastThreeDigits}");
            }
        }

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine($"First Task Launch: Press: {(char)MenuItem.Task1} \nSecond Task Launch: Press: {(char)MenuItem.Task2} \nThird Task Launch: Press {(char)MenuItem.Task3} \nFourth Task Launch: Press {(char)MenuItem.Task4} \nFifth Task Launch: Press {(char)MenuItem.Task5}");
                var menuSelect = (char)Console.Read();
                var currentSelect = (MenuItem)menuSelect;

                if (menuSelect != ((char)MenuItem.Task1) && menuSelect != ((char)MenuItem.Task2) && menuSelect != ((char)MenuItem.Task3) && menuSelect != ((char)MenuItem.Task4) && menuSelect != ((char)MenuItem.Task5))
                {
                    throw new Exception("Ошибка! Введен не правильный символ!");
                }

                switch (currentSelect)
                {
                    case MenuItem.Task1:
                        Console.ReadLine();
                        Console.Write("Enter the Base number: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Exponent: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());

                        var result = Exponentiation(num1, num2);

                        Console.WriteLine($"\n\tYour number: {result}");
                        break;

                }
                switch (currentSelect)
                {
                    case MenuItem.Task2:
                        Console.ReadLine();
                        Console.Write("Enter First number: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second number: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());

                        var sum = TheSumOfTheNumbersInTheRange(num1, num2);

                        Console.WriteLine($"\n\tYour Sum: {sum}");
                        break;
                }
                switch (currentSelect)
                {
                    case MenuItem.Task3:
                        Console.ReadLine();
                        Console.Write("Enter the starting number of the range: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the ending number of the range: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (num1 == 0 || num2 == 0)
                        {
                            throw new Exception("Ошибка! Не вводите нули!");
                        }

                        var totalPerfectNumber = IsPerfect(num1, num2);
                        Console.WriteLine($"\n\tThe number of perfect numbers in your range: {totalPerfectNumber}");
                        break;
                }
                switch (currentSelect)
                {
                    case MenuItem.Task4:
                        Console.WriteLine("Важно! Индексы достоинства карт: 0, 1, 2, 3, 4, 5, 6, 7, 8. Индексы мастей: 0, 1, 2, 3.");
                        Console.WriteLine("Пример Вы ввели порядковый номер достоинтсва карты 9 то прочитает оно что запизано в индексе 8 и т.д");
                        Console.ReadLine();
                        Console.Write("\nEnter the ordinal number of the card's rank: ");
                        var Numbercard = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the ordinal number of the card's suit: ");
                        var Suit = Convert.ToInt32(Console.ReadLine());

                        var yourCard = Card(Numbercard, Suit);
                        Console.WriteLine($"\nYour Card: {yourCard}");
                        break;
                }
                switch (currentSelect)
                {
                    case MenuItem.Task5:

                        LuckyOrUnluckyNumber();
                        break;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка! Индекс вышел за пределы массива!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Не вводите символы только цифры!");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Слишком длинное положительное или отрицательное число!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}