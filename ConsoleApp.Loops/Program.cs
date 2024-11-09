// Simple For Loop Demo
// Print Hello World 10 times

// 0 1 2 3 4 5 6 7 8 9
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop Completed!");

// Ask User how many times they wish to print hello world and print accordingly
Console.Write("How many times should we print \"Hello World\"?: ");
int userCount = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userCount; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}