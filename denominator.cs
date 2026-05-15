// Out parameters
// allow a method to return more than one value


// int Add(int a, int b)
// {
//     return a + b;
// }

// void Calculate(int a, int b, out int sum, out int product)
// {
//     sum = a + b;
//     product = a * b;
// }

// Calculate(5,3, out int sum, out int product);
// Console.WriteLine(sum);
// Console.WriteLine(product);

// string input = "Twenty Five";

// bool success = int.TryParse(input, out int age);

// if (success)
// {
//     Console.WriteLine($"Age is {age}");
// }
// else
// {
//     Console.WriteLine("Invalid age");
// }

// bool TryDivide(int numerator, int denominator, out double result)
// {
//     if (denominator == 0)
//     {
//         result = 0;
//         return false;
//     }

//     result = (double)numerator / denominator;
//     return true;
// }

// bool success = TryDivide(10, 0, out double answer);
// if (success)
// {
//     Console.WriteLine($"Answer: {answer}");
// }
// else
// {
//     Console.WriteLine("Cannot divide by zero");
// }

