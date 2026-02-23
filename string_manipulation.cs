Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter operator (+, -, *, /): ");
char op = Console.ReadLine()[0];  // Get first character

Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());

switch (op)
{
    case '+':
        Console.WriteLine($"Result: {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"Result: {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"Result: {num1 * num2}");
        break;
    case '/':
        if (num2 != 0)
            Console.WriteLine($"Result: {num1 / num2}");
        else
            Console.WriteLine("Cannot divide by zero!");
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}