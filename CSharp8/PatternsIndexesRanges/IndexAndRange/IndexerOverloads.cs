using System;
using System.ComponentModel;

namespace Chapter15
{
    [Description("Listing 13.15")]
    class IndexerOverloads
    {
        static void Main()
        {
            string text = "hello world";
            Console.WriteLine(text[2]);
            Console.WriteLine(text[^3]);
            Console.WriteLine(text[2..7]);

            Span<int> span = stackalloc int[] { 5, 2, 7, 8, 2, 4, 3 };
            Console.WriteLine(span[2]);
            Console.WriteLine(span[^3]);
            Span<int> slice = span[2..7];
            Console.WriteLine(string.Join(", ", slice.ToArray()));
        }
    }
}
