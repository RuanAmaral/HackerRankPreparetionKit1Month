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

class CaesarCipherResult
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        char[] encrypted = s.ToCharArray();
        char[] lowerAlpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] upperAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        
        for (int letter = 0; letter < encrypted.Length; letter++){
            if (lowerAlpha.Contains(encrypted[letter]))
                encrypted[letter] = 
                    lowerAlpha[ ((Array.IndexOf(lowerAlpha, encrypted[letter]) + k) % 26)];
            else if (upperAlpha.Contains(encrypted[letter]))
                encrypted[letter] = 
                   upperAlpha[ (( Array.IndexOf(upperAlpha, encrypted[letter]) + k) % 26)];
        }
        
        string final = "";
        foreach (char i in encrypted){
            final += i;
        }
        return final;
       
       
    }

}

class CaesarCipherSolution
{
    public static void CaesarCipherMain(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = CaesarCipherResult.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
