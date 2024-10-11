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

class lonelyintegerResult
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */



    //My time 07:42 minutes to resolve

    public static int lonelyinteger(List<int> a)
    {

        //MyCode

        int integer = 0;
        foreach (int i in a)
        {
            if ((a.Where(a => a == i).Count()) == 1)
            {
                integer = i;
            }
        }

        return integer;

        // With XOR Operator
        //The XOR of a number with itself is 0, and the XOR of any number with 0 is the number itself. //This allows you to find the unique element in linear time with constant space.
        //By XORing all elements, pairs of identical elements cancel out, leaving only the unique element. //This solution is efficient as it operates in O(n) time complexity and O(1)

        //  int result = 0;
        // 	foreach (var num in a)
        // 	{
        // 			result ^= num; // XOR operation
        // 	}
        // 	return result;
        // }


    }

}

class lonelyintegerSolution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = lonelyintegerResult.lonelyinteger(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
