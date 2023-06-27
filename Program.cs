// Request the user to enter a value for X
Console.Write("Enter value for X: ");
// Read the user's input
var xInput = Console.ReadLine();
// Try to parse the input as an integer. If it fails, print an error and end the program.
if (!int.TryParse(xInput, out int X))
{
    Console.WriteLine("Invalid input");
    return;
}

// Request the user to enter a value for Y
Console.Write("Enter value for Y: ");
// Read the user's input
var yInput = Console.ReadLine();
// Try to parse the input as an integer. If it fails, print an error and end the program.
if (!int.TryParse(yInput, out int Y))
{
    Console.WriteLine("Invalid input");
    return;
}

// Initialize the sum
int sum = 0;

// If X and Y are equal, the sum is just X (or Y)
if (X == Y)
{
    sum = X;
}
else
{
    // Determine the minimum and maximum values of X and Y
    int min = Math.Min(X, Y);
    int max = Math.Max(X, Y);

    // Iterate over the range from min to max, inclusive, adding each number to the sum
    for (int i = min; i <= max; i++)
    {
        sum += i;
    }
}

// Print the sum to the console
Console.WriteLine($"Sum = {sum}");