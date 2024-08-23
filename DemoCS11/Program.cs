#region Raw string Literals
//Before C#11
using DemoCS11;
using System.Numerics;
using System.Text;

var stringMultipleLines =
                                @"Hello,
    
                            my name is ""Jose"".
                                This line is idented.";
//Console.WriteLine("--Before C# 11--");
//Console.WriteLine(stringMultipleLines);  //shows up the content out of the expected position.

//With C#11
//Example 1
string name = "Jose";

var stringMultipleLinesCS11 = $$""""
                                    Hello,

                                    My name is "{{{name}}}"
                                        This """line""" is idented. C# 11
                                    """";
//Console.WriteLine("--C# 11--");
//Console.WriteLine(stringMultipleLinesCS11);
//Console.WriteLine("---useful for json");
//string interpolation 
var json2 = $$""" 
                { 
                    "name": "{{name}}" 
                }
                """;
//Console.WriteLine(json2);

//Example 2
var temperature = 27; // 24;
string message = $"Human temperature sensation when {temperature} is {temperature switch
{
    > 45 => "TOO WARM - NOT GOOD",
    > 35 => "WARM",
    > 25 => "NICE",
    > -10 => "COLD",
    <= -10 => "TOO COLD - NOT GOOD"
}}";
//Console.WriteLine("\nExample 2");
//Console.WriteLine(message);


//Example 3: Strings literal utf-8
var utf8BeforeCS11 = Encoding.UTF8.GetBytes("Hello");
var utf8EnCS11 = "Hello"u8.ToArray();

//Console.WriteLine(utf8EnCS11);
#endregion


#region List Patterns
// List Patterns = Pattern Matching
//Console.WriteLine("List Patterns");

int[] numbers = { 1, 2, 3 };
//Console.WriteLine(numbers is [1, 2]); // False
//Console.WriteLine(numbers is [1, 2, 3]); // True
//Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // True
//Console.WriteLine(numbers is [1, 2, _]);  // True
//Console.WriteLine();

//if (numbers is [var first, _, _])
//{
//    Console.WriteLine(first);
//}

// the rest of the array in a variable 
//if (numbers is [var first, .. var rest])
//{
//    Console.WriteLine(first);
//    Console.WriteLine(string.Join(", ", rest.ToArray()));
//}
#endregion

#region Required Members
//var person1 = new Person();  // not allowed
var person2 = new Person("Jose");  // needs [SetsRequiredMembers] in the constructor
var person3 = new Person()
{
    Name = "Jose",
};

// Example 6:
//var utils = new PersonUtils(); // has no access this way
//var value = person2.GetValue();
//Console.WriteLine(value);
#endregion

#region structs-auto initialization of members
var namePerson2 = nameof(person2);
//Console.WriteLine(namePerson2);
#endregion

#region Generic Math
int[] intNums = { 1, 2, 3 };
Complex[] complexNums = { new Complex(2, 3), new Complex(4, 1) };

var resultIntNums = GenericMath.Sum<int, int>(intNums);
Console.WriteLine("Sum of 1, 2 and 3 is " + resultIntNums);

var resultComplexNums = GenericMath.Sum<Complex, Complex>(complexNums);
Console.WriteLine("Sum of 2+3i + 4+1i is " + resultComplexNums);
#endregion