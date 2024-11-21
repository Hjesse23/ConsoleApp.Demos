Console.WriteLine(" --- Arrays --- ");

// Declare Fixed Size Array
int[] grades = new int[5];
// 5 space addresses/indexes - 0, 1, 2, 3, 4
// If n is the size of the array, then your array has addresses between 0 to n-1

// Add values to Fixed Size Array
// grades[0] = 45;
// grades[1] = 25;
// grades[2] = 38;
// grades[3] = 45;
// grades[4] = 54;

// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write("Enter Grade: ");
//     grades[i] = Convert.ToInt32(Console.ReadLine());
// }

// // Print values in Fixed Size Array
// Console.WriteLine("The Grades you have entered are: ");
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.WriteLine(grades[i]);
// }

// Declare Variable Sized Array
string[] studentNames = { "Newton", "Joshua", "etc..." };

// Add values to Variable Size Array
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter Student Name: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in Variable Size Array
Console.WriteLine("The student names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}