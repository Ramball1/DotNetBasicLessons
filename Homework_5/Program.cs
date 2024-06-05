using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

namespace Homework_5
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                Console.Write("Enter First number: ");
                var n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second number: ");
                var n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 == n2)
                {
                    throw new Exception("\nНе вводите два одинаковых числа или два нуля в n1 и n2!");
                }

                // Пометка: нужную часть задания раскомментируйте, остальные закомментируйте (по умолчанию работает все части 2-го задания).

                // First Task Part 1 (все числа диапозона): 

                //while (n1 < n2)
                //{
                //    Console.WriteLine($"\n{n1}");
                //    n1++;
                //}

                // наоборот, если первое число больше второго: 

                //while (n1 > n2)
                //{
                //    Console.WriteLine($"\n{n2}");
                //    n2++;
                //}

                // First Task Part 2 (все числа диапозона в нисходящем порядке):

                //while (n1 < n2)
                //{
                //    Console.WriteLine($"\n{n2}");
                //    n2--;
                //}

                // наоборот, если первое число больше второго:

                //while (n1 > n2)
                //{
                //    Console.WriteLine($"\n{n1}");
                //    n1--;
                //}

                // First Task Part 3 (все числа, кратные 7):

                //while (n1 < n2)
                //{
                //    if (n1 % 7 == 0)
                //    {
                //        Console.WriteLine($"\n{n1}");
                //    }
                //    n1++;
                //}

                // наоборот, если первое число больше второго:

                //while (n1 > n2)
                //{
                //    if (n2 % 7 == 0)
                //    {
                //        Console.WriteLine($"\n{n2}");
                //    }
                //    n2++;
                //}

                // First Task Part 4 (количестов чисел, кратных 5):

                //while (n1 < n2)
                //{
                //    while (n1 < n2)
                //    {
                //        if (n1 % 5 == 0)
                //        {
                //            counter++;
                //        }
                //        n1++;
                //    }
                //    Console.WriteLine($"\nThe number of numbers that are multiply of 5: {counter}");
                //}

                // наоборот, если первое число больше второго:

                //while (n1 > n2)
                //{
                //    while (n1 > n2)
                //    {
                //        if (n2 % 5 == 0)
                //        {
                //            counter++;
                //        }
                //        n2++;
                //    }
                //    Console.WriteLine($"\nThe number of numbers that are multiply of 5: {counter}");
                //}

                // Second Task (All Parts):

                if (n1 > n2)
                {
                    throw new Exception("\nНе вводите число n1 больше чем n2!");
                }

                // когда пользователь вводит два четных или два нечетных числа:

                if (n1 % 2 == 0 && n2 % 2 == 0 || n1 % 2 > 0 && n2 % 2 > 0)
                {
                    int counterEvennumbers = 0;
                    int counterOddnumbers = 0;
                    decimal counterMultiplyOf9 = 0;
                    int sum = 0;

                    for (int i = n1; i <= n2; i++)
                    {
                        if (i % 9 == 0)
                        {
                            sum += i;
                            counterMultiplyOf9++;
                        }
                    }

                    while (n1 < n2)
                    {
                        if (n1 % 2 == 0)
                        {
                            counterEvennumbers++;
                        }
                        if (n1 % 2 > 0)
                        {
                            counterOddnumbers++;
                        }
                        n1++;
                    }

                    var evennumbers = (n1 - (counterEvennumbers * 2) + n2) / 2 * (counterEvennumbers + 1);
                    var oddnumbers = (n1 - (counterOddnumbers * 2) + n2) / 2 * counterOddnumbers;
                    var multiplyOf9 = sum;

                    Console.WriteLine($"\n\tEvennumbers Sum: {evennumbers} \n\n\tOddnumbers Sum: {oddnumbers} \n\n\tMultiply of 9 Sum: {multiplyOf9} \n\n\tAritmetical mean Evennumbers: {evennumbers / (counterEvennumbers + 1)} \n\n\tAritmetical mean Oddnumbers: {oddnumbers / counterOddnumbers} \n\n\tAritmetical mean Multiply of 9: {multiplyOf9 / counterMultiplyOf9}");
                }

                // когда пользователь вводит первое четное, а второе нечетное:

                if (n1 % 2 == 0 && n2 % 2 > 0)
                {
                    int counterEvennumbers = 0;
                    int counterOddnumbers = 0;
                    decimal counterMultiplyOf9 = 0;
                    int sum = 0;

                    for (int i = n1; i <= n2; i++)
                    {
                        if (i % 9 == 0)
                        {
                            sum += i;
                            counterMultiplyOf9++;
                        }
                    }

                    while (n1 < n2)
                    {
                        if (n1 % 2 == 0)
                        {
                            counterEvennumbers++;
                        }
                        if (n1 % 2 > 0)
                        {
                            counterOddnumbers++;
                        }
                        n1++;
                    }

                    var evennumbers = (n1 - (counterEvennumbers * 2) + n2) / 2 * counterEvennumbers;
                    var oddnumbers = (n1 - (counterOddnumbers * 2) + n2) / 2 * (counterOddnumbers + 1);
                    var multiplyOf9 = sum;

                    Console.WriteLine($"\n\tEvennumbers Sum: {evennumbers} \n\n\tOddnumbers Sum: {oddnumbers} \n\n\tMultiply of 9 Sum: {multiplyOf9} \n\n\tAritmetical mean Evennumbers: {evennumbers / counterEvennumbers} \n\n\tAritmetical mean Oddnumbers: {oddnumbers / (counterOddnumbers + 1)} \n\n\tAritmetical mean Multiply of 9: {multiplyOf9 / counterMultiplyOf9}");
                }

                // когда пользователь вводит первое нечетное, а второе четное:

                if (n1 % 2 > 0 && n2 % 2 == 0)
                {
                    int counterEvennumbers = 0;
                    int counterOddnumbers = 0;
                    decimal counterMultiplyOf9 = 0;
                    int sum = 0;

                    for (int i = n1; i <= n2; i++)
                    {
                        if (i % 9 == 0)
                        {
                            sum += i;
                            counterMultiplyOf9++;
                        }
                    }

                    while (n1 < n2)
                    {
                        if (n1 % 2 == 0)
                        {
                            counterEvennumbers++;
                        }
                        if (n1 % 2 > 0)
                        {
                            counterOddnumbers++;
                        }
                        n1++;
                    }

                    var evennumbers = (n1 - (counterEvennumbers * 2) + n2) / 2 * (counterEvennumbers + 1);
                    var oddnumbers = (n1 - (counterOddnumbers * 2) + n2) / 2 * counterOddnumbers;
                    var multiplyOf9 = sum;

                    Console.WriteLine($"\n\tEvennumbers Sum: {evennumbers} \n\n\tOddnumbers Sum: {oddnumbers} \n\n\tMultiply of 9 Sum: {multiplyOf9} \n\n\tAritmetical mean Evennumbers: {evennumbers / (counterEvennumbers + 1)} \n\n\tAritmetical mean Oddnumbers: {oddnumbers / counterOddnumbers} \n\n\tAritmetical mean Multiply of 9: {multiplyOf9 / counterMultiplyOf9}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nНе вводите символы только цифры!");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("\nСлишком длинное положительное или отрицательное число!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // Пометка для себя:

            // когда пользователь вводит два нечетных числа:

            //if (n1 % 2 > 0 && n2 % 2 > 0)
            //{
            //    int counterEvennumbers = 0;
            //    int counterOddnumbers = 0;
            //    decimal counterMultiplyOf9 = 0;
            //    int sum = 0;

            //    for (int i = n1; i <= n2; i++)
            //    {
            //        if (i % 9 == 0)
            //        {
            //            sum += i;
            //            counterMultiplyOf9++;
            //        }
            //    }

            //    while (n1 < n2)
            //    {
            //        if (n1 % 2 == 0)
            //        {
            //            counterEvennumbers++;
            //        }
            //        if (n1 % 2 > 0)
            //        {
            //            counterOddnumbers++;
            //        }
            //        n1++;
            //    }

            //    var evennumbers = (n1 - (counterEvennumbers * 2) + n2) / 2 * (counterEvennumbers + 1);
            //    var oddnumbers = (n1 - (counterOddnumbers * 2) + n2) / 2 * counterOddnumbers;
            //    var multiplyOf9 = sum;

            //    Console.WriteLine($"\n\tEvennumbers Sum: {evennumbers} \n\n\tOddnumbers Sum: {oddnumbers} \n\n\tMultiply of 9 Sum: {multiplyOf9} \n\n\tAritmetical mean Evennumbers: {evennumbers / (counterEvennumbers + 1)} \n\n\tAritmetical mean Oddnumbers: {oddnumbers / counterOddnumbers} \n\n\tAritmetical mean Multiply of 9: {multiplyOf9 / counterMultiplyOf9}");
            //}


            //// формула суммы всех четных чисел где n1 четное n2 четное):

            //while (n1 < n2)
            //{
            //    if (n1 % 2 == 0)
            //    {
            //        counter++;
            //    }
            //    n1++;
            //}
            //Console.WriteLine($"\n{(n1 - (counter * 2) + n2) / 2 * (counter + 1)}");

            //// формула суммы всех нечетных чисел где n1 четное и n2 четное):

            //while (n1 < n2)
            //{
            //    if (n1 % 2 > 0)
            //    {
            //        counter++;
            //    }
            //    n1++;
            //}
            //Console.WriteLine($"\n{(n1 - (counter * 2) + n2) / 2 * (counter)}");

            //// формула суммы всех четных чисел где n1 или нечетное и n2 нечетное):

            //while (n1 < n2)
            //{
            //    if (n1 % 2 == 0)
            //    {
            //        counter++;
            //    }
            //    n1++;
            //}
            //Console.WriteLine($"\n{(n1 - (counter * 2) + n2) / 2 * (counter)}");

            //// формула суммы всех нечетных чисел где n1 нечетное и n2 нечетное):

            //while (n1 < n2)
            //{
            //    if (n1 % 2 > 0)
            //    {
            //        counter++;
            //    }
            //    n1++;
            //}
            //Console.WriteLine($"\n{(n1 - (counter * 2) + n2) / 2 * (counter + 1)}");
        }
    }
}