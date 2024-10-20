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

class DynamicArrayResult
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> arr = new List<List<int>>(n);

        for (int i = 0; i < n; i++)
        {
            arr.Add(new List<int>());
        }

        List<int> answerArr = new List<int>();
        int lastAnswer = 0;
        int idx;

        foreach (List<int> query in queries)
        {
            idx = (query[1] ^ lastAnswer) % n;

            if (query[0] == 1)
            {
                arr[idx].Add(query[2]);
            }
            else if (query[2] == 0)
            {
                lastAnswer = arr[idx][0];
                answerArr.Add(lastAnswer);
            }

            else
            {
                lastAnswer = arr[idx][query[2] % (arr[idx].Count())];
                answerArr.Add(lastAnswer);
            }
        }

        return answerArr;


    }

}

class DynamicArraySolution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = DynamicArrayResult.dynamicArray(n, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
