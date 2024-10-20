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

class SalesByMatchResult
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int SalesByMatchsockMerchant(int n, List<int> ar)
    {

        //Best answer
        //          
        //return ar.GroupBy(i => i).Select(g => g.Count() / 2).Sum();


        int pairs = 0;
        ar.Sort();

        for (int i = 0; i < n - 1; i++)
        {
            if (ar[i] == ar[i + 1])
            {
                pairs++;
                i++;
            }
        }

        return pairs;

    }

}

class Solution
{
    public static void SalesByMatchMain(string[] args)
    {
      //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = SalesByMatchResult.SalesByMatchsockMerchant(n, ar);

        Console.WriteLine(result);

       // textWriter.WriteLine(result);

       // textWriter.Flush();
        //textWriter.Close();
    }
}
