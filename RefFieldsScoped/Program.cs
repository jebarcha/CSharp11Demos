using RefFieldScoped;

Example();

void Example()
{
    var textHolder = new TexTHolder(16);
    Span<char> values = stackalloc char[4] { 'J', 'o', 'h', 'n' };
    textHolder.Append(values);

    Console.WriteLine(textHolder.ToString());
}

Span<int> CreateSpan(scoped ref int parameter)
{
    return Span<int>.Empty;
}

Span<int> CreateSpan2()
{
    scoped Span<int> span = stackalloc int[420];
    return Span<int>.Empty;
}