// int temp = 10;
// string message;

// Console.WriteLine((temp >= 15)? "its warm outside" : "its cold outside");
string name;
Console.WriteLine("enter your name: ");
string name = Console.ReadLine();

int age ;
Console.WriteLine("enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if(string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("invalid name");
}