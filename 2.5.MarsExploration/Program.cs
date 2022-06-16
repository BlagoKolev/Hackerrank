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
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
        var numberOfMsg = s.Length / 3;
        var originalMsg = string.Empty;
        var misstakeCounter = 0;

        for (int i = 0; i < numberOfMsg; i++)
        {
            originalMsg += "SOS";
        }

        for (int i = 0; i < s.Length; i++)
        {
            var sendLetter = s[i].ToString();
            for (int j = i; j < originalMsg.Length; j++)
            {
                var originalLetter = originalMsg[j].ToString();
                if (sendLetter != originalLetter)
                {
                    misstakeCounter++;
                }
                break;
            }

        }
        return misstakeCounter;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
