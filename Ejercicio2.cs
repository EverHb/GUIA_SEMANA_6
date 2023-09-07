using System;
using System.Globalization;
using System.Linq;

class whereSample3 
{
    static void Main()
    {
        int[] scores = { 90, 71, 82, 93,75,82 };

        var queryLowNums = from num in scores where IsEven(num) select num;

        foreach (var s in queryLowNums)

        {
            Console.WriteLine(s.ToString() + " ");
        }

        
            static bool IsEven(int i)
            {
                return i % 2 == 0;
            }

        }

    }



