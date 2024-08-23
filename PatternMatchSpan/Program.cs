string name = "Paul";
if (name is "Paul")
{
    Console.WriteLine("Name is Paul");
}

ReadOnlySpan<char> text = "John Lennon";

if (text is "John Lennon")
{
    Console.WriteLine("Yes it is");
}

ReadOnlySpan<char> text2 = "John Lennon";
if (text2.SequenceEqual("John Lennon".AsSpan())) // Efficient comparison with ReadOnlySpan<char>
{
    Console.WriteLine("2 Yes it is");
}


if (text is ['J', ..])
{
    Console.WriteLine("Name starts with J");
}