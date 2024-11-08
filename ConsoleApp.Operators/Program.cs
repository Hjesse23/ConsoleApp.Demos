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

// int randomValue = 5;
// int increaseValue = num1 + 5;

// num1 = num1 + 5;

Console.WriteLine("**************** Assignment Results ****************");
Console.WriteLine();
num1 += 5;
Console.WriteLine($"Num 1 increased by 5: {num1}");
num1 -= 3;
Console.WriteLine($"Num 1 decreased by 3: {num1}");
num1 /= 2;
Console.WriteLine($"Num 1 divided by 2: {num1}");
num1 %= 2;
Console.WriteLine($"Num 1 modulus 2: {num1}");
num1 *= 10;
Console.WriteLine($"Num 1 multiplied by 10: {num1}");
Console.WriteLine();
Console.WriteLine("**************** End Assignment Results ****************");

