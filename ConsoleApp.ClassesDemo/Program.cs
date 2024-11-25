using ConsoleApp.ClassesDemo;

Console.WriteLine(" ---- Classes and Objects ---- ");

// Define an object of type Person.
Person person; // this will be null by default

Person baby = new Person();
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateofBirth = new DateOnly(2023, 10, 29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine(taxNumber);

var person1 = new Person("Developer", "One", new DateOnly(2000, 10, 31));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "741852963");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();
var person2IdNumber = person2.GetIdNumber();
Console.WriteLine(person2IdNumber);

var teacher = new Teacher();
teacher.LastName = "Thompson";
teacher.FirstName = "Theresa";
teacher.DateofBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teacherTaxNumber);
teacher.GenerateTeacherIdNumber();

var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);

Student student = new();
student.LastName = "Thompson";
student.FirstName = "Theresa";
student.DateofBirth = new DateOnly(2023, 10, 29);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
student.GenerateStudentIdNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);


// Polygon polygon = new Polygon(); // compiler error
Rectangle rectangle = new(10, 20);
var rectangleArea = rectangle.Area();
Console.WriteLine($"Rectangle area is: {rectangleArea}");

Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Square area is: {squareArea}");


