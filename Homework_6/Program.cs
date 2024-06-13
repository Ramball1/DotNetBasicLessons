using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Homework_6
{
    enum Currency
    {
        Dollar = '$',
        Euro = '€'
    }

    enum MenuItem
    {
        Task1 = '!',
        Task2 = '$'
    }

    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine($"First Task Launch: Press: {(char)MenuItem.Task1} \nSecond Task Launch: Press: {(char)MenuItem.Task2}");
                var menuSelect = (char)Console.Read();
                var currentSelect = (MenuItem)menuSelect;

                if (currentSelect != MenuItem.Task1 && currentSelect != MenuItem.Task2)
                {
                    throw new Exception("\n\tНе вводите цифры или другие символы кроме предоставленных!");
                }

                switch (currentSelect)
                {
                    case MenuItem.Task1:
                        Console.ReadLine();
                        Console.Write($"Enter First Month Profit: {(char)Currency.Dollar}");
                        var m1 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write($"Enter Second Month Profit: {(char)Currency.Dollar}");
                        var m2 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write($"Enter Third Month Profit: {(char)Currency.Dollar}");
                        var m3 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write($"Enter Fourth Fourth Profit: {(char)Currency.Dollar}");
                        var m4 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write($"Enter Fifth Month Profit: {(char)Currency.Dollar}");
                        var m5 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write($"Enter Sixth Month Profit: {(char)Currency.Dollar}");
                        var m6 = Convert.ToDecimal(Console.ReadLine());

                        const int profitPG = 100;

                        if (m1 + m2 + m3 + m4 + m5 + m6 < profitPG)
                        {
                            throw new Exception("\n\tНе вводите заработок компании 'Procter & Gamble' меньше чем 100$");
                        }

                        decimal[] profitHalfYear = { m1, m2, m3, m4, m5, m6 };
                        decimal total = 0;

                        foreach (var profitOneMonth in profitHalfYear)
                        {
                            total += profitOneMonth;
                        }
                        Console.WriteLine($"\nTotal Profit of The Company 'Procter & Gamble' for Half Year: {(char)Currency.Dollar}{total}");
                        break;
                    case MenuItem.Task2:
                        const int profitMinCDPR = 100000;
                        const int profitMaxCDPR = 1000000;
                        const int ArrSize = 12;
                        var arr = new int[ArrSize];
                        var rnd = new Random();
                        var totalProfit = 0;
                        var profitMonthMin = 0;
                        var profitMonthMax = 0;

                        for (int i = 0; i < ArrSize; i++)
                        {
                            if (i == 0)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"First Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 1)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nSecond Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 2)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nThird Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 3)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nFourth Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 4)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nFifth Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 5)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nSixth Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 6)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nSeventh Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 7)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nEighth Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 8)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nNinth Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 9)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nTenth Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 10)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nEleventh Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                            if (i == 11)
                            {
                                arr[i] = rnd.Next(profitMinCDPR, profitMaxCDPR);
                                Console.Write($"\nTwelfth Month Profit: {(char)Currency.Euro}{arr[i]}");
                            }
                        }
                        foreach (var profitMonth in arr)
                        {
                            totalProfit += profitMonth;
                            profitMonthMin = arr.Min();
                            profitMonthMax = arr.Max();
                        }
                        Console.WriteLine($"\n\nTotal Profit of the Company 'CD Project RED' for One Year: {(char)Currency.Euro}{totalProfit} \n\nMinimal Profit of The Company 'CD Project RED' for One Month: {(char)Currency.Euro}{profitMonthMin} \n\nMaximum Profit of The Company 'CD Project RED' for One Month: {(char)Currency.Euro}{profitMonthMax}");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\n\tНе вводите символы только цифры!");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("\n\tСлишком длинное положительное или отрицательное число!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}