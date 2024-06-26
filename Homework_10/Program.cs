using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace Homewokr_10
{
    enum MenuItem
    {
        TaskHomeNumber = '!',
        TaskPhoneNumber = '$',
        TaskEmail = '?',
        TaskFullName = '%'
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
                    Console.WriteLine($"If You want to write Home Number Task: Press: {(char)MenuItem.TaskHomeNumber} \nIf You want to write Phone Number Task: Press: {(char)MenuItem.TaskPhoneNumber} \nIf You want to write Email Task: Press: {(char)MenuItem.TaskEmail} \nIf you want to write Full Name Task: Press: {(char)MenuItem.TaskFullName}");
                    var menuSelect = (char)Console.Read();
                    Console.ReadLine();
                    var currentSelect = (MenuItem)menuSelect;

                    if (menuSelect != ((char)MenuItem.TaskHomeNumber) && menuSelect != ((char)MenuItem.TaskPhoneNumber) && menuSelect != ((char)MenuItem.TaskEmail) && menuSelect != ((char)MenuItem.TaskFullName))
                    {
                        throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                    }

                    switch (currentSelect)
                    {
                        case MenuItem.TaskHomeNumber:
                            while (true)
                            {
                                Console.WriteLine("Please be aware enter only digits and length of the Home Number should be 7 digits!");
                                Console.WriteLine("\nEnter your Home Number: ");
                                string HomeNumber = Console.ReadLine() ?? string.Empty;
                                string HomeNumber_Validator = "^[0-9]{7}$";

                                if (Regex.Match(HomeNumber.Trim(), HomeNumber_Validator).Success)
                                {
                                    Console.WriteLine($"Thank You! Your Home Number: {HomeNumber.Trim()} was accepted");
                                    break;
                                }

                                else 
                                {
                                    Console.WriteLine($"Sorry, Your Home Number: {HomeNumber.Trim()} was not accepted: Try entering it again: ");
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case MenuItem.TaskPhoneNumber:
                            while (true)
                            {
                                Console.WriteLine("Please be aware enter only digits ((+) is possible in the beginning of the number) and length of the Phone Number should be 10 to 15 digits!");
                                Console.WriteLine("\nEnter your Phone Number: ");
                                string PhoneNumber = Console.ReadLine() ?? string.Empty;
                                string PhoneNumber_Validator = "^[+]?[0-9]{10,15}$";

                                if (Regex.Match(PhoneNumber.Trim(), PhoneNumber_Validator).Success)
                                {
                                    Console.WriteLine($"Thank You! Your Phone Number: {PhoneNumber.Trim()} was accepted");
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine($"Sorry, Your Phone Number: {PhoneNumber.Trim()} was not accepted: Try entering it again: ");
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case MenuItem.TaskEmail:
                            while (true)
                            {
                                Console.WriteLine("Please be aware min length is 5 symbols max length is 20 symbols (you can use (._) after first letter) you should use symbol (@), domen (gmail.com or yahoo.com or icloud.com");
                                Console.WriteLine("\nEnter your Email: ");
                                string email = Console.ReadLine() ?? string.Empty;
                                string email_Validator = "^[a-zA-Z](?:[._]?[a-zA-Z0-9]{4,19}|[a-zA-Z0-9]{4,19})[@](([g][m][a][i][l])?([i][c][l][o][u][d])?([y][a][h][o][o])?)+[.][c][o][m]$";

                                if (Regex.Match(email.Trim(), email_Validator).Success)
                                {
                                    Console.WriteLine($"Thank You! Your Email: {email.Trim()} was accepted");
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine($"Sorry, Your Email: {email.Trim()} was not accepted: Try entering it again: ");
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case MenuItem.TaskFullName:
                            while (true)
                            {
                                Console.WriteLine("Please be aware first letter should be Uppercase enter only letters min length of the word is 2 symbols max length of the word is 20 symbols!");
                                Console.Write("\nEnter your First Name: ");
                                string firstName = Console.ReadLine() ?? string.Empty;
                                string firstName_Validator = "^[A-Z][a-z]{2,20}";
                                Console.Write("Enter your Last Name: ");
                                string lastName = Console.ReadLine() ?? string.Empty;
                                string lastName_Validator = "^[A-Z][a-z]{2,20}";
                                Console.Write("Enter your Patronymic: ");
                                string patronymic = Console.ReadLine() ?? string.Empty;
                                string patronymic_Validator = "^[A-Z][a-z]{2,20}";

                                if (Regex.Match(firstName.Trim(), firstName_Validator).Success)
                                {
                                    if (Regex.Match(lastName.Trim(), lastName_Validator).Success)
                                    {
                                        if (Regex.Match(patronymic.Trim(), patronymic_Validator).Success)
                                        {
                                            Console.WriteLine($"\nThank You! Your Full Name: {firstName.Trim()} {lastName.Trim()} {patronymic.Trim()} was accepted");
                                            break;
                                        }
                                        Console.WriteLine($"\nSorry, Your Patronymic: {patronymic.Trim()} is incorrect: Try entering Full Name again: ");
                                        Console.WriteLine();
                                        continue;
                                    }
                                }

                                if (Regex.Match(firstName.Trim(), firstName_Validator).Success)
                                {
                                    if (Regex.IsMatch(lastName.Trim(), lastName_Validator) == false)
                                    {
                                        if (Regex.Match(patronymic.Trim(), patronymic_Validator).Success)
                                        {
                                            Console.WriteLine($"\nSorry, Your Last Name: {lastName.Trim()} is incorrect: Try entering Full Name again: ");
                                            Console.WriteLine();
                                            continue;
                                        }
                                        Console.WriteLine($"\nSorry, Your Last Name: {lastName.Trim()} and Your Patronymic: {patronymic.Trim()} is incorrect: Try entering Full Name again: ");
                                        Console.WriteLine();
                                        continue;
                                    }
                                }

                                if (Regex.IsMatch(firstName.Trim(), firstName_Validator) == false)
                                {
                                    if (Regex.Match(lastName.Trim(), lastName_Validator).Success)
                                    {
                                        if (Regex.Match(patronymic.Trim(), patronymic_Validator).Success)
                                        {
                                            Console.WriteLine($"\nSorry, Your First Name: {firstName.Trim()} is incorrect: Try entering Full Name again: ");
                                            Console.WriteLine();
                                            continue;
                                        }
                                        Console.WriteLine($"\nSorry, Your First Name: {firstName.Trim()} and Your Patronymic: {patronymic.Trim()} is incorrect: Try entering Full Name again: ");
                                        Console.WriteLine();
                                        continue;
                                    }
                                }

                                if (Regex.IsMatch(firstName.Trim(), firstName_Validator) == false)
                                {
                                    if (Regex.IsMatch(lastName.Trim(), lastName_Validator) == false)
                                    {
                                        if (Regex.Match(patronymic.Trim(), patronymic_Validator).Success)
                                        {
                                            Console.WriteLine($"\nSorry, Your First Name: {firstName.Trim()} and Your Last Name: {lastName.Trim()} is incorrect: Try entering Full Name again: ");
                                            Console.WriteLine();
                                            continue;
                                        }
                                        Console.WriteLine($"\nSorry, Your First Name: {firstName.Trim()}, Your Last Name: {lastName.Trim()} and Your Patronymic: {patronymic.Trim()} is incorrect: Try entering Full Name again: ");
                                        Console.WriteLine();
                                        continue;
                                    }
                                }
                            }
                            break;
                    }
                    if (menuSelect == ((char)MenuItem.TaskHomeNumber) || menuSelect == ((char)MenuItem.TaskPhoneNumber) || menuSelect == ((char)MenuItem.TaskEmail) || menuSelect == ((char)MenuItem.TaskFullName))
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