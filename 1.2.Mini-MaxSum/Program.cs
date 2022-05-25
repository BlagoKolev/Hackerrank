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
using System.Numerics;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {

        var resultArr = new List<BigInteger>();

        for (int i = 0; i < arr.Count; i++)
        {
            BigInteger sum = (arr[0] + arr[1] + arr[2] + arr[3] + arr[4]) - arr[i];
            resultArr.Add(sum);
        }
        Console.WriteLine($"{resultArr.Min()} {resultArr.Max()}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
