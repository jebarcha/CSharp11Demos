//int[] numbers = { 1, 2, 3 };

//Console.WriteLine(numbers is [1, 2, 3]); // True
//Console.WriteLine(numbers is [1, 2, 4]); // False

//Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // True

//if (numbers is [var first, _, _])
//{
//    Console.WriteLine(first);
//}

//if (numbers is [var first1, .. var rest])
//{
//    Console.WriteLine(first1);
//    Console.WriteLine(string.Join(", ", rest));
//}


// Example 2:
var emptyName = Array.Empty<string>();
var myName = new[] { "Paul McCartney " };
var myNameBrokenDown = new[] { "Paul", "McCartney " };
var myNameBrokenDownFurther = new[] { "Paul", "James", "McCartney" };

//var text = emptyName switch
var text = myNameBrokenDownFurther switch
{
    [] => "Name is empty",
    [var fullName] => $"My full name is: {fullName}",
    [var firstName, var lastName] => $"My full name is: {firstName} {lastName}",
    [var firstName, var midName, var lastName] => $"My full name is: {firstName} {midName} {lastName}",
};

Console.WriteLine(text);