using System;
using System.ComponentModel;

namespace Chapter15
{
    [Description("Listing 15.13")]
    class FirstDemo
    {
        static void Main()
        {
            string quotedText = "'This text was in quotes'";
            Console.WriteLine(quotedText);
            Console.WriteLine(quotedText.Substring(1..^1));
        }
    }
}
