Console.WriteLine("String manipulation");

// Initialize with a string literal.
string s1 = "This is a literal string";
String s2 = "This is a literal string";
Console.WriteLine(s1);
Console.WriteLine(s2);

// Declare without initializing. (possible null exception)
string s3;

// Initialize to null. (possible null exception)
string? s4 = null;

// Initialize as an empty string.
string s5 = string.Empty;
string s6 = "";

// Escape sequences and characters
// She said, "I have your phone"
string sentence = "She said, \"I have your phone\" \r\n This is the next line";
Console.WriteLine(sentence);

// Vervatim string literal.
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\program files\programfolder\";
Console.WriteLine(oldPath);
Console.WriteLine(newPath);

// Use a const string to prevent modification to a string
const string path = "C:\\program files\\programfolder\\";
Console.WriteLine(path);

// path = "new value"; Illegal operation against a constant
s1 = "A new string";
Console.WriteLine(s1);

// Raw string literals
string rawLiteral = """She said, "I have your phone" """;
string rawLiteral1 = """
    She said, "I have your phone"
    This is the next line 
    And another one
    Path = "C:\program files\programfolder\"
    """;
Console.WriteLine(rawLiteral);
Console.WriteLine(rawLiteral1);

// Review concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} Some random literal text";
string newString1 = s1 + s2 + " Some random literal text";
string newString2 = String.Format("Literal string {0} {1}", s1, s2);
Console.WriteLine(newString);
Console.WriteLine(newString1);
Console.WriteLine(newString2);

/* String manipulation methods */

// Substrings