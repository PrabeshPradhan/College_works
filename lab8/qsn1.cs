using System;
using System.Linq;

class Test
{
    static void Main()
    {
        int[] n = { 3, 6, 7, 9, 10, 12, 15 };

        var result = from x in n
                     where x % 2 != 0 && x % 3 == 0
                     select x;

        foreach (var x in result)
            Console.WriteLine(x);
    }
}
