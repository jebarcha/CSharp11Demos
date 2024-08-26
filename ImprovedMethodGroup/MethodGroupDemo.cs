using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedMethodGroup;
public class MethodGroupDemo
{
    private static readonly List<int> Ages = Enumerable.Range(0, 100).ToList();

    static int Sum()
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
}
