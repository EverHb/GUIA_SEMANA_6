using System;
using System.Globalization;
using System.Linq;

class whereSample2
{
    static void Main() 
    {
        int[] scores = { 97, 92, 81, 60 };

        var queryLowNums = from num in scores where num > 80 select num;

        foreach (var s in queryLowNums)

        {
            Console.WriteLine(s.ToString() + " ");
        }

        Console.WriteLine();

    }



}