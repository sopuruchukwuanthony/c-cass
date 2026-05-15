using System.Reflection;

try
{
    Console.WriteLine("openning file....");
    string file = File.ReadAllText("students.txt");
    Console.WriteLine(file);
}
catch(Exception){
    Console.WriteLine("Something went wrong");
}