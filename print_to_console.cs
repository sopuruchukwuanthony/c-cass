using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

double x;
double y;
double result;

try{
Console.WriteLine("Eneter number 1");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Eneter number 2");
y = Convert.ToDouble(Console.ReadLine());

result = x / y;
Console.WriteLine($"Result: {result}");
}
catch(FormatException e)
{
    Console.WriteLine("OOPS! Please enter a number");
}