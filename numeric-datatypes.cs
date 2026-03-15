using System.Globalization;

// double price = 1500.5;
// Console.WriteLine(price.ToString("f2"));
// Console.WriteLine($"{price:f2}");
// Console.WriteLine("{0:f2}" , price);
// decimal a = 0.1m;
// decimal b = 0.2m;
// Console.WriteLine(a + b);
// sbyte smallNumber = -100;
// Console.WriteLine(smallNumber);
// byte positiveSmallNumber = 200;
// Console.WriteLine(positiveSmallNumber);

//numeric formatting
/*numeric formatting is how yo u can control 
the way numbers are displayed as strings. You can use format specifiers
 to specify the format of the number when converting it to a string. 
 For example, you can specify the number of decimal
  places, whether to use scientific notation, or how to display currency values.*/
//   double num = 123456789.234
//   Console.WriteLine(num.ToString("f2"));
//   Console.WriteLine($"{num:f2}");
//   Console.WriteLine("{0:f2}", num);
//number formatting
//N add thousands operators and decimal places
// double num = 123456789.234;
// Console.WriteLine(num.ToString("N2"));
// Console.WriteLine($"{num:N2}");
// decimal amount = 1500.0m;
// Console.WriteLine(amount.ToString("c", new CultureInfo("en-NG")));
//percantage formatting
// double score = 0.85;
// Console.WriteLine(score.ToString("p"));
double num = 1234567.89;
Console.WriteLine(num.ToString("c" , new CultureInfo("en-GB")));
Console.WriteLine(num.ToString("D5"));
Console.WriteLine(num.ToString("x"));

Console.WriteLine();

Console.WriteLine("custom formatting");
Console.WriteLine(num.ToString("0.00"));
Console.WriteLine(num.ToString("#.##0.00"));
Console.WriteLine(num.ToString("00000"));
Console.WriteLine(num.ToString("0.00 'NG'"));