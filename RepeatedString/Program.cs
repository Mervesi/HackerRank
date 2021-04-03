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

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        int aCount = 0;
        foreach (var item in s)
        {
            if (item=='a') { aCount++; }
        }
        var repeatCount = n / s.Length;
        var aMod = n % s.Length;
        var aPlusCount = aCount * repeatCount;
        for (int i = 0; i < aMod; i++)
        {
            if (s[i]=='a')
            {
                aPlusCount++;
            }
        }
        return aPlusCount;
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        Console.WriteLine(result);
        Console.ReadLine();

       
    }
}
