Console.WriteLine("String manipulation");

// Initialize with a string literal.
string s1 = "This is a literal string";
String s2 = "This is a literal string";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");

// Declare without initializing. (possible null exception)
string s3;
// Console.WriteLine($"{nameof(s3)}: {s3}"); // syntax error. s3 needs a value before it can be used

// Initialize to null. (possible null exception)
string? s4 = null;
Console.WriteLine($"{nameof(s4)}: {s4}");

// Initialize as an empty string.
string s5 = string.Empty;
string s6 = "";
Console.WriteLine($"{nameof(s5)}: {s5}");
Console.WriteLine($"{nameof(s6)}: {s6}");

// Escape sequences and characters
// She said, "I have your phone"
string sentence = "She said, \"I have your phone\" \r\n This is the next line";
Console.WriteLine($"{nameof(sentence)}: {sentence}");

// Vervatim string literal.
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\program files\programfolder\";
Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");

// Use a const string to prevent modification to a string
const string path = "C:\\program files\\programfolder\\";
Console.WriteLine($"{nameof(path)}: {path}");

// path = "new value"; Illegal operation against a constant
s1 = "A new string";
Console.WriteLine($"{nameof(s1)}: {s1}");

// Raw string literals
string rawLiteral = """She said, "I have your phone" """;
string rawLiteral1 = """
    She said, "I have your phone"
    This is the next line 
    And another one
    Path = "C:\program files\programfolder\"
    """;
Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)}: {rawLiteral1}");

// Review concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} Some random literal text";
string newString1 = s1 + s2 + " Some random literal text";
string newString2 = String.Format("Literal string {0} {1}", s1, s2);
Console.WriteLine($"{nameof(newString)}: {newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");

/* String manipulation methods */

// Substrings