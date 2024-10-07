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

class MiniMaxSum
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        //Discussion and Better Solution
        arr.Sort();

        // Sum of the smallest 4 elements
        long minSum = arr.Take(4).Sum();

        // Sum of the largest 4 elements
        long maxSum = arr.Skip(arr.Count - 4).Sum();

        // Print the result
        Console.WriteLine($"{minSum} {maxSum}");


        //My Solution
        long min = 0, max = 0, equalmin = 0, equalmax = 0;
        int bigger = arr.Max();
        int minor = arr.Min();


        foreach (int i in arr)
        {

            if (i > minor || equalmax > 0)
            {
                max += i;
            }
            if (i < bigger || equalmin > 0)
            {
                min += i;
            }
            if (minor == i)
            {
                equalmax++;
            }
            if (bigger == i)
            {
                equalmin++;
            }
        }

        Console.WriteLine(min + " " + max);

    }

}

class MiniMaxSumSolution
{
    public static void MiniMaxSumMain()
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        MiniMaxSum.miniMaxSum(arr);
    }
}
