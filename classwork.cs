Console.WriteLine("Enter item name:");
string itemName = Console.ReadLine();

Console.WriteLine("Enter unit price:");
float unitPrice = float.Parse(Console.ReadLine());

Console.WriteLine("Enter quantity:");
int quantity = int.Parse(Console.ReadLine());
float percentage = 0;
float extraPercentage = 0;

if(itemName == string.Empty)
{
    Console.WriteLine("Item name cannot be empty.");
    return;
}
else if(unitPrice <=0)
{
    Console.WriteLine("Unit price must be greater than zero.");
    return;
}
else if (quantity <=0)
{
    Console.WriteLine("quantity must be greater than zero.");
    return;
}

float total = unitPrice * quantity;
float discount = 0;

if(total >= 50000)
{
    percentage = 15;
    discount = total * 15 / 100;
}
else if(total >= 20000)
{
    percentage = 10;
    discount = total * 10 / 100;
}
else if(total >= 10000)
{
    percentage = 5;
    discount = total * 5 / 100;
}
else
{
    percentage = 0;
    discount = 0;
}
float extraDiscount =0;
if(quantity >= 10)
{
    extraPercentage = 2;
    extraDiscount = total * 2 / 100;
}
float grandTotal = total - discount + extraDiscount;

Console.WriteLine("==========STORE RECEIPT==========");

Console.WriteLine($"Item Name: {itemName}");    
Console.WriteLine($"Unit Price: {unitPrice:f2}");
Console.WriteLine($"Quantity: {quantity}");

Console.WriteLine($"--------------------------------");

Console.WriteLine($"Total: {total}");
Console.WriteLine($"Percentage: {percentage}%");
Console.WriteLine($"Discount: {discount:f2}");

Console.WriteLine("----------------------------------");
Console.WriteLine($"Grand Total: {grandTotal:f2}");

