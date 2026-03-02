// using System;

// class Geeks
// {
//     int a = 10;

//     public void display()
//     {
//         Console.WriteLine(a);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Geeks g = new Geeks(); // create object
//         g.display();          // call method
//     }
// }
// C# program to illustrate the
// Class Level Scope of variables
using System;
// Declaring a Class
class Geeks { // From here, class level scope starts
    // This is a class level variable
    // having class level scope
    int a = 10;
    // Declaring a method
    public void display()
    {
        // Accessing class level variable
        Console.WriteLine(a);
    } // Here method ends
    static void Main()
    {
        Geeks g = new Geeks(); // create object
        g.display();          // call method
    }
  
} // Here class level scope ends
