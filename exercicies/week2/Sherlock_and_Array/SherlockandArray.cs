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

class SherlockandArrayResult
{

    /*
     * Complete the 'balancedSums' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static string balancedSums(List<int> arr)
    {
         int[] intArray = arr.ToArray();
        if (arr.Count() == 1){
            return "YES";
        }
        int[] startEndSums = { 0 , intArray[..].Sum() };
        
        for (int i = 0; i < arr.Count(); i++){
            startEndSums[1] -= intArray[i];
            if (startEndSums[0] == startEndSums[1])
                return "YES";
            startEndSums[0] += intArray[i];
        }
        return "NO";

    }

}

class SherlockandArraySolution
{
    public static void SherlockandArrayMain(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = SherlockandArrayResult.balancedSums(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
