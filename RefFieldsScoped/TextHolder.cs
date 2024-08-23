using System.Buffers;

namespace RefFieldScoped;
ref struct TexTHolder
{
    private readonly Span<char> _chars;
    private int _pos;

    public TexTHolder(int size)
    {
        _chars = ArrayPool<char>.Shared.Rent(size);
        _pos = 0;
    }

    public void Append(scoped ReadOnlySpan<char> value)
    {
        if (value.TryCopyTo(_chars.Slice(_pos)))
        {
            _pos += value.Length;
        }
    }

    public override string ToString() => new(Text);

    private ReadOnlySpan<char> Text => _chars[.._pos];

}