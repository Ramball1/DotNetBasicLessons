using System.Text;

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



            Console.WriteLine("\nHello, Nikita");
        }
    }
}