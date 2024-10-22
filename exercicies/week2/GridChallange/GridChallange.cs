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

class GridChallangeResult
{

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        for (int i = 0; i < grid.Count(); i++)
        {
            char[] characters = grid[i].ToArray();
            Array.Sort(characters);
            grid[i] = new string(characters);
        }

        bool alphaOrder = true;
        if (grid.Count > 1)
        {
            for (int i = 0; i < grid.Count() - 1; i++)
            {
                for (int j = 0; j < grid[0].Count(); j++)
                {
                    if (String.Compare(grid[i].Substring(j, 1), grid[i + 1].Substring(j, 1)) > 0)
                    {

                        alphaOrder = false;
                    }
                }
            }
        }

        return alphaOrder ? "YES" : "NO";

    }

}

class GridChallangeSolution
{
    public static void GridChallangeMain(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = GridChallangeResult.gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
