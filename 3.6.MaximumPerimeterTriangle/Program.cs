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
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */

    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        var triangles = sticks.OrderByDescending(x => x).ToList();

        for (int i = 0; i < triangles.Count - 2; i++)
        {
            var firstSide = triangles[i];
            var secondSide = triangles[i + 1];
            var thirdSide = triangles[i + 2];

            if (firstSide < secondSide + thirdSide
                && secondSide < firstSide + thirdSide
                && thirdSide < firstSide + secondSide)
            {
                return new List<int>() { thirdSide, secondSide, firstSide };
            }
        }

        return new List<int>() { -1 };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

        List<int> result = Result.maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
