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

class RecursiveDigitSumResult
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        long digitSum(string str)
        {
            long sum = 0;
            foreach (char c in str)
            {
                sum += c - '0';
            }
            return sum;
        }

        long initialSum = digitSum(n) * k;

        while (initialSum >= 10)
        {
            initialSum = digitSum(initialSum.ToString());
        }

        return Convert.ToInt32(initialSum);

    }
    // if (n.Count() == 1) return Convert.ToInt32(n);

    // string fixedn = n;
    // long super = 0;

    // while (k > 1)
    // {
    //     n += fixedn;
    //     k--;
    // }

    // char[] c = n.ToCharArray();
    // for (int i = 0; i < c.Count(); i++)
    // {
    //     super += Convert.ToInt64(c[i].ToString());
    // }

    // return superDigit(super.ToString(), k);


}



class RecursiveDigitSumSolution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = RecursiveDigitSumResult.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
