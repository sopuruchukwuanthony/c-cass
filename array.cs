// String[] name = { "Alice","Bob", "Charlie", "David", "Eve"};
// string[] slice = name [1..4]; // This will create a new array containing "Bob", "Charlie", and "David"
// Console.WriteLine(string.Join(", ", slice)); // Output: Bob, Charlie, David

// int [] numbers = {10, 20, 30, 40, 50, 60};
// Console.WriteLine(numbers.Max()); // Output: 60
int[] numbers = { 5, 10, 30, 70, 90 }; // sorted

int target = 70;
int left = 0;
int right = numbers.Length - 1;

while (left <= right)
{
    int mid = (left + right) / 2;

    if (numbers[mid] == target)
    {
        Console.WriteLine("Found at index " + mid);
        break;
    }
    else if (numbers[mid] < target)
    {
        left = mid + 1;
    }
    else
    {
        right = mid - 1;
    }
}