Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
    Math Operations and Operators
*/

// Add numbers
int sum = num1 + num2;

// Multiply
int product = num1 * num2;

//Division
int quotient = num1 / num2;

//Subtraction
int difference = num1 - num2;

// Modulus 
int mod = num1 % num2;

Console.WriteLine("**************** Math Results ****************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("**************** End Math Results ****************");

/*
    Logic Operations and Operators
*/

var isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqual = num1 >= num2;
bool isLessThanOrEqual = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("**************** Logic Results ****************");
Console.WriteLine();
Console.WriteLine($"Is greater than: {isGreaterThan}");
Console.WriteLine($"Is less than: {isLessThan}");
Console.WriteLine($"Is equal to: {isEqualTo}");
Console.WriteLine($"Is greater than or equal: {isGreaterThanOrEqual}");
Console.WriteLine($"Is less than or equal: {isLessThanOrEqual}");
Console.WriteLine($"Is not equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("**************** End Logic Results ****************");

/*
    Assignment Operations and Operators
*/
Console.WriteLine("**************** Assignment Results ****************");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("**************** End Assignment Results ****************");

