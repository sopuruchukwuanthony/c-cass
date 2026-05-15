Console.WriteLine("enter your name");
string name = Console.ReadLine();
Console.WriteLine($"you are welcome: {name}");

Console.WriteLine("enter your age");
int age = 0;
int.TryParse(Console.ReadLine(), out age);
Console.WriteLine($"your age is: {age}");
 
Console.WriteLine("enter your height in meters");
float height = 0;
float.TryParse(Console.ReadLine(), out height);
Console.WriteLine($"your height is:{height} meters");

Console.WriteLine("enter your occupation");
string occupation = Console.ReadLine();
Console.WriteLine($"your occupation is: {occupation}");
Console.WriteLine("enter your password");
string password = Console.ReadLine();
Console.WriteLine($"your password is {password}");