using System.Text;

//string text = "John Lennon";

ReadOnlySpan<byte> text = "John Lennon"u8;

ReadOnlySpan<byte> u16A = Encoding.Unicode.GetBytes("A");
ReadOnlySpan<byte> u8A = "A"u8;


//----
var utf8BeforeCS11 = Encoding.UTF8.GetBytes("Hello");
var utf8EnCS11 = "Hello"u8.ToArray();
Console.WriteLine(utf8EnCS11);

Console.WriteLine();
