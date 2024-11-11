// Write a program that takes user's age as input and print it to the screen.
// Display an error message if an invalid input is received

try
{
    Console.WriteLine("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old.");
}
catch (Exception)
{
    Console.WriteLine("Your age value was incorrect. Please try again.");
    // throw;
}
finally
{
    Console.WriteLine("Thank you for using this program");
}