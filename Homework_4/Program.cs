using System.Text;
using System.Transactions;

namespace Homework_4
{
    enum MathActions
    {
        Plus = '+',
        Minus = '-',
        Multiply = '*',
        Divide = '/',
        Modulo = '%',
        PercentageOfTwoNumbers = '#'
    }

    enum PizzaMenu
    {
        Margherita = 1111,
        Calzone = 1112,
        Napoletana = 1113,
        Fritta = 1114
    }

    enum PizzaMenuPrice
    {
        Margherita = 10,
        Calzone = 12,
        Napoletana = 15,
        Fritta = 17
    }

    enum DrinksMenu
    {
        Chinotto = 111,
        Cedrata = 112,
        Aranciata = 113
    }

    enum DrinksMenuPrice
    {
        Chinotto = 1,
        Cedrata = 2,
        Aranciata = 5
    }


    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                Console.WriteLine("Enter First number: ");
                var firstNumber = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Second number: ");
                var secondNumber = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter math action: (+ - * / % #) ");
                var mathAction = (MathActions)Convert.ToChar(Console.ReadLine() ?? string.Empty);
                switch (mathAction)
                {
                    case MathActions.Plus:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case MathActions.Minus:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case MathActions.Multiply:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case MathActions.Divide:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber / secondNumber}");
                        break;
                    case MathActions.Modulo:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber % secondNumber}");
                        break;
                    case MathActions.PercentageOfTwoNumbers:
                        Console.WriteLine($"{firstNumber} {(char)MathActions.Divide} {secondNumber} {(char)MathActions.Multiply} {100} = {firstNumber / secondNumber * 100}%");
                        break;
                    default:
                        Console.WriteLine("Incorrect math action!");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Не дели на ноль!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Не правильный тип данных!");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Слишком длинное положительное или отрицательное число!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ну ты тип, как ты сделал ошибку?");
                Console.WriteLine(ex.Message);
            }


            try
            {
                Console.WriteLine("\n\n\t\t\t\t\tBenvenuti nella nostra pizzeria");
                Console.WriteLine("Pizza Menu: ");
                Console.WriteLine($" 1.\t{PizzaMenu.Margherita} - {(int)PizzaMenu.Margherita} = {(int)PizzaMenuPrice.Margherita}$");
                Console.WriteLine($" 2.\t{PizzaMenu.Calzone} - {(int)PizzaMenu.Calzone} = {(int)PizzaMenuPrice.Calzone}$");
                Console.WriteLine($" 3.\t{PizzaMenu.Napoletana} - {(int)PizzaMenu.Napoletana} = {(int)PizzaMenuPrice.Napoletana}$");
                Console.WriteLine($" 4.\t{PizzaMenu.Fritta} - {(int)PizzaMenu.Fritta} = {(int)PizzaMenuPrice.Fritta}$");
                Console.WriteLine("\nDrinks Menu: ");
                Console.WriteLine($" 1.\t{DrinksMenu.Chinotto} - {(int)DrinksMenu.Chinotto} = {(int)DrinksMenuPrice.Chinotto}$");
                Console.WriteLine($" 2.\t{DrinksMenu.Cedrata} - {(int)DrinksMenu.Cedrata} = {(int)DrinksMenuPrice.Cedrata}$");
                Console.WriteLine($" 3.\t{DrinksMenu.Aranciata} - {(int)DrinksMenu.Aranciata} = {(int)DrinksMenuPrice.Aranciata}$");

                Console.WriteLine("\n\t\t\t\t\tВажно!");
                Console.WriteLine("\n\t\t\t\tВводите цены правильно(:");
                Console.WriteLine("\nПодсказка: если хотите заказать только напиток(ки) или только пиццу(ы) введите 0 в трех пунктах (код, цена, количество)");

                Console.Write("\nEnter the code of the Pizza Menu item: ");
                var codePizza = (PizzaMenu)Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the price of the Pizza Menu item: ");
                var pricePizza = (PizzaMenuPrice)Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the quantity of the Pizza Menu item: ");
                var quantityPizza = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the code of the Drinks Menu item: ");
                var codeDrinks = (DrinksMenu)Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the price of the Drinks Menu item: ");
                var priceDrinks = (DrinksMenuPrice)Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the quantity of the Drinks Menu item: ");
                var quantityDrinks = Convert.ToInt32(Console.ReadLine());
                var AranciataDrink = codeDrinks - 112;
                decimal drinkAranciataPrice = ((int)DrinksMenuPrice.Aranciata);
                decimal total = (((int)pricePizza) * quantityPizza) + (((int)priceDrinks) * quantityDrinks);

                if (codePizza == 0 && pricePizza == 0 && quantityPizza == 0 && codeDrinks == 0 && priceDrinks == 0 && quantityDrinks == 0)
                {
                    throw new Exception("\n\n\t\t\t\t\tScuza \nYou didn't order anything: Try Again (Не вводите ноль во все поля)");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total <= 50 && quantityPizza < 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {((int)pricePizza) * quantityPizza - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total > 50 && quantityPizza < 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5 - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total <= 50 && quantityPizza < 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((int)priceDrinks) * quantityDrinks) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total > 50 && quantityPizza < 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5 - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total <= 50 && quantityPizza < 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((int)pricePizza) * quantityPizza) + (((int)priceDrinks) * quantityDrinks) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total > 50 && quantityPizza < 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5 - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total <= 50 && quantityPizza >= 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {(((int)pricePizza) * quantityPizza) - ((int)pricePizza) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total > 50 && quantityPizza >= 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {(((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5) - ((decimal)pricePizza) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total <= 50 && quantityPizza >= 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((int)priceDrinks) * quantityDrinks)) - ((int)pricePizza) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total > 50 && quantityPizza >= 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5) - ((decimal)pricePizza) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total <= 50 && quantityPizza >= 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((int)pricePizza) * quantityPizza) + (((int)priceDrinks) * quantityDrinks)) - ((int)pricePizza) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total > 50 && quantityPizza >= 5 && AranciataDrink > 0 && quantityDrinks > 3)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5) - ((decimal)pricePizza) - (((decimal)drinkAranciataPrice * quantityDrinks) / 100 * 15)}$");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total <= 50 && quantityPizza < 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {((int)pricePizza) * quantityPizza}$");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total > 50 && quantityPizza < 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total <= 50 && quantityPizza < 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((int)priceDrinks) * quantityDrinks)}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total > 50 && quantityPizza < 5)
                {
                    Console.WriteLine($"\nYour Total order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total <= 50 && quantityPizza < 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((int)pricePizza) * quantityPizza) + (((int)priceDrinks) * quantityDrinks)}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total > 50 && quantityPizza < 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5}$");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total <= 50 && quantityPizza >= 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {(((int)pricePizza) * quantityPizza) - ((int)pricePizza)}$");
                }
                else if (codePizza > 0 && codeDrinks == 0 && total > 50 && quantityPizza >= 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \nTo Pay: {(((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5) - ((decimal)pricePizza)}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total <= 50 && quantityPizza >= 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((int)priceDrinks) * quantityDrinks)) - ((int)pricePizza)}$");
                }
                else if (codePizza == 0 && codeDrinks > 0 && total > 50 && quantityPizza >= 5)
                {
                    Console.WriteLine($"\nYour Total order: \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5) - ((decimal)pricePizza)}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total <= 50 && quantityPizza >= 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {((((int)pricePizza) * quantityPizza) + (((int)priceDrinks) * quantityDrinks)) - ((int)pricePizza)}$");
                }
                else if (codePizza > 0 && codeDrinks > 0 && total > 50 && quantityPizza >= 5)
                {
                    Console.WriteLine($"\nYour Total Order: \n\t\tPizza Name: {codePizza} \n\t\tQuantity Pizza: {quantityPizza} \n\t\tDrink Name: {codeDrinks} \n\t\tQuantity Drinks: {quantityDrinks} \nTo Pay: {(((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) - ((((decimal)pricePizza) * quantityPizza) + (((decimal)priceDrinks) * quantityDrinks)) / 5) - ((decimal)pricePizza)}$");
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
        }
    }
}