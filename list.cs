List<string> fruits = new List<string>{
    "Apple",
    "Banana",
    "Cherry"
};
Console.WriteLine("Fruits:");
//     foreach (string i in fruits)
//     {
//         Console.WriteLine(i);
// }
fruits.Add("mango");
fruits.Add("Orange");
fruits.Add("pea");
fruits.Remove("Cherry");
Console.WriteLine(fruits[0]);

foreach (string i in fruits)
    {
     Console.WriteLine(i);
   }

