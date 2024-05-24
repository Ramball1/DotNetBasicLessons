Console.Write("English: ");
var num1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Mathematics: ");
var num2 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Physics: ");
var num3 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Chemistry: ");
var num4 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Deutsch: ");
var num5 = Convert.ToDecimal(Console.ReadLine());
var total = (num1 + num2 + num3 + num4 + num5) / 5;
Console.WriteLine($"\tMean Grade: {total}");

if (total >= 4 && total <= 5)
{
    Console.WriteLine("\tCongratulations, you are admitted to the exam");
}
else if (total >= 0 && total < 4)
{
    Console.WriteLine("\tYou are not allowed to the exam: BYE, BYE");
}
else
{
    Console.WriteLine("\tIncorrect");
}


Console.Write("\nEnter number: ");
var number = Convert.ToDecimal(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"\tYour number: {number * 3}");
}
else
{
    Console.WriteLine($"\tYour number: {number / 2}");
}

Console.Write("\nFirst number: ");
var n1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Second number: ");
var n2 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Aritmetic operation: ");
string? operation = Console.ReadLine();

if (operation == "+")
{
    Console.WriteLine($"\tYour number: {n1 + n2}");
}
else if (operation == "-")
{
    Console.WriteLine($"\tYour number: {n1 - n2}");
}
else if (operation == "*")
{
    Console.WriteLine($"\tYour number: {n1 * n2}");
}
else if (operation == "/")
{
    Console.WriteLine($"\tYour number: {n1 / n2}");
}
else if (operation == "%")
{
    Console.WriteLine($"\tYour number: {n1 % n2}");
}
else
{
    Console.WriteLine("\tIncorrect: Try Again");
}