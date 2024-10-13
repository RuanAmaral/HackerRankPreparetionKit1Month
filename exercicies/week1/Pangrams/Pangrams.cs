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

class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {

        List<string> alphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".Split().ToList();

        bool pangram = true;

        foreach (string i in alphabet)
        {
            if (!s.ToUpper().Contains(i))
            {
                pangram = false;
            }
        }

        return pangram ? "pangram" : "not pangram";

        // string result = "pangram";

        // if (!pangram)
        // {
        //     result = "not pangram";
        // }

        // return result;

    }

}

class pangramSolution
{
    public static void pangramMain()
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
