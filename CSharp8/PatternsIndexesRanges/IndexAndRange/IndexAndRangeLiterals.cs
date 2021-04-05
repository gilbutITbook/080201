using System;
using System.ComponentModel;

namespace Chapter15
{
    [Description("Listing 15.14")]
    class IndexAndRangeLiterals
    {
        static void Main()
        {
            Index start = 2;
            Index end = ^2;
            Range all = ..;
            Range startOnly = start..;
            Range endOnly = ..end;
            Range startAndEnd = start..end;
            Range implicitIndexes = 1..5;
        }
    }
}
