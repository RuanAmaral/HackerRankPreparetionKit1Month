using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class PlusMinusResult
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int negative = 0, zeros = 0, positive = 0;

        foreach (int i in arr)
        {
            if (i > 0)
            {
                positive++;
            }
            else if (i < 0)
            {
                negative++;
            }
            else if (i == 0)
            {
                zeros++;
            }
        }
        //myCode
        Console.WriteLine("{0:0.000000}", ((float)positive / (float)arr.Count));
        Console.WriteLine("{0:0.000000}", ((float)negative / (float)arr.Count));
        Console.WriteLine("{0:0.000000}", ((float)zeros / (float)arr.Count));

        // code by disscussion hackerRank (better)
        Console.WriteLine($"{(positive / arr.Count):F6}");
        Console.WriteLine($"{(negative / arr.Count):F6}");
        Console.WriteLine($"{(zeros / arr.Count):F6}");

    }

}

class PlusMinusSolution
{
    public static void PlusMinusMain()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        PlusMinusResult.plusMinus(arr);
    }
}
