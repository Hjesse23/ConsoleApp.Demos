// Prompt for input
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If...Else...statement - Decide to print pass of fail based on input
Console.WriteLine("**************** Simple If Results ****************");
if (grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to student affairs office");
}
Console.WriteLine("**************** Simple If Results End ****************");
// Complex If...Else if...statement - Decide to print pass of fail based on input
Console.WriteLine("**************** Complex IF..ELSE IF Results ****************");

/*
    A: 86 - 100
    B: 75 - 84
    C: 65 - 74
    C-: 51 - 64
*/

if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade == 65)
{
    Console.WriteLine("C+");
}
else if (grade == 75)
{
    Console.WriteLine("B");
}
else if (grade == 85)
{
    Console.WriteLine("B+");
}
else
{
    Console.WriteLine("A - Good job");
}

Console.WriteLine("**************** Complex IF..ELSE IF Results End ****************");

// The rest of the application
Console.WriteLine("Thank you for using this program");