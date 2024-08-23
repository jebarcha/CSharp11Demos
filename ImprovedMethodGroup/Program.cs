static readonly List<int> Ages = Enumerable.Range(0, 100).ToList();

int Sum()
{
    return Ages.Where(a => Filter(a)).Sum();
}

int SumMethodGroup()
{
    return Ages.Where(Filter).Sum();
}

static bool Filter(int age)
{
    return age > 50;
}