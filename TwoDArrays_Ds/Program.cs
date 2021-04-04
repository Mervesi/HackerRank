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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        int maxHourglass = getHourglass(arr, 1, 1);
        for (int y = 1; y < 5; y++)
        {
            for (int x = 1; x < 5; x++)
            {
                int hour = getHourglass(arr, x, y);
                if (hour>maxHourglass)
                {
                    maxHourglass = hour;
                }
            }
        }
        return maxHourglass;

    }
    static int getHourglass(int[][] arr,int x, int y)
    {                
        int sumHourglass = arr[y - 1][x - 1] + arr[y - 1][x] + arr[y - 1][x + 1]
                                             + arr[y][x] +
                           arr[y + 1][x - 1] + arr[y + 1][x] + arr[y + 1][x + 1];            
            return sumHourglass;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
