Console.WriteLine("Enter the temperature: (c)");
double temp = Convert.ToDouble(Console.ReadLine());

if(temp >= 10 && temp <= 25)
{
    Console.WriteLine("Itys warm out side");
}
else if(temp <= -50 || temp >= 50)
{
    Console.WriteLine("Do not go out please");
}