using calculator;

double a, b;
int choice;
Calculator calc = new Calculator();
Console.WriteLine("Welcome to Calculator\n" +
    "1: Add\n" +
    "2: Substract\n" +
    "3: Multiply\n" +
    "4: Power");
choice = int.Parse(Console.ReadLine());
Console.WriteLine(choice);

Console.WriteLine("Input First number followed by the second number");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
Console.WriteLine($"A = {a}\n" +
                  $"B = {b}");
switch (choice)
{
    case 1:
        Console.WriteLine($"Answer = {calc.Add(a,b)}");
        break;
    case 2:
        Console.WriteLine($"Answer = {calc.Substract(a, b)}");
        break;
    case 3:
        Console.WriteLine($"Answer = {calc.Multiply(a, b)}");
        break;
    case 4:
        Console.WriteLine($"Answer = {calc.Power(a, b)}");
        break;
    default:
        Console.WriteLine("ERROR");
        break;
}