using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<string> inputLines = new List<string>();
        string line;
        while ((line = Console.ReadLine()) != null && line != "")
        {
            inputLines.Add(line);
        }

        foreach (var input in inputLines)
        {
            var stringItem = input.Split(';').ToList();
            string result;

            if (stringItem[0] == "C")
            {
                result = Combine(stringItem[1], stringItem[2]);
                Console.WriteLine(result);
            }
            else if (stringItem[0] == "S")
            {
                result = Separate(stringItem[1], stringItem[2]);
                Console.WriteLine(result);
            }
        }


    }
    public static string Separate(string type, string text)
    {
        StringBuilder sb = new StringBuilder();
        var startIndex = 0;

        for (int i = 1; i < text.Length; i++)
        {
            if (Char.IsUpper(text[i]) || i == text.Length - 1)
            {
                string someWord;
                if (startIndex == 0)
                {
                    someWord = text.Substring(startIndex, i);
                }
                else
                {
                    someWord = text.Substring(startIndex, text.Length - startIndex);
                }

                var startLetter = someWord[0].ToString().ToLower();
                var wordToAppend = $"{startLetter}{someWord.Substring(1)}";
                sb.Append(wordToAppend + " ");
                startIndex = i;
            }
        }
        var resultString = sb.ToString().Replace("()", "").Trim();


        return resultString;
    }

    public static string Combine(string type, string text)
    {
        var words = text.Split(' ').ToList();
        StringBuilder sb = new StringBuilder();

        if (type == "V" || type == "M")
        {
            sb.Append(words[0]);
        }
        else
        {
            var startWord = words[0];
            var capitaLetter = startWord[0].ToString().ToUpper();
            var firstWord = $"{capitaLetter}{startWord.Substring(1)}";
            sb.Append(firstWord);
        }

        for (var i = 1; i < words.Count; i++)
        {
            var nextWord = words[i];
            var firstLetter = nextWord[0].ToString().ToUpper();
            var wordAppnd = $"{firstLetter}{nextWord.Substring(1)}";
            sb.Append(wordAppnd);
        }

        if (type == "M")
        {
            sb.Append("()");
        }
        return sb.ToString();
    }
}
