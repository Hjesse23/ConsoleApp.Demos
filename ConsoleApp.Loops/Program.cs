// Simple For Loop Demo
// Print Hello World 10 times

// 0 1 2 3 4 5 6 7 8 9
Console.WriteLine("**************** For Loop ****************");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("**************** For Loop Completed ****************");

// Ask User how many times they wish to print hello world and print accordingly
// Console.Write("How many times should we print \"Hello World\"?: ");
// int userCount = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= userCount; i++)
// {
//     Console.WriteLine($"Hello, World! - {i}");
// }

// int counter = 0;
// while (counter < 10)
// {
//      Console.WriteLine($"Hello, World! - {counter}");
//      counter += 2;
// }

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit.
int sum = 0;
int num = 0;

Console.WriteLine("**************** While Loop ****************");
while(num != -1)
{
    Console.Write("Please enter number to be summed. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());

    // nested if statement
    if(num != -1)
    {
        sum += num;
    }
    else
    {
        break;
    }
}

Console.WriteLine($"Your sum is: {sum}");
Console.WriteLine("**************** While Loop Completed ****************");

Console.WriteLine("**************** Do While Loop ****************");
sum = 0;
num = -1;
do
{
    Console.Write("Please enter number to be summed. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());

    // nested if statement
    if (num != -1)
    {
        sum += num;
    }
    else
    {
        break;
    }
} while (num != -1);
Console.WriteLine("**************** Do While Completed ****************");