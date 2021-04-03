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

    // Complete the jumpingOnClouds function below.
    static int JumpingOnTheClouds(int[] c)
    {
       var clouds=c;
       var emmasPosition = 0;
        var jumpCount = 0;
        while (true)
        {
            if (emmasPosition + 2 <= clouds.Length - 1 && clouds[emmasPosition + 2] == 0)
                emmasPosition = emmasPosition + 2;
            else
                emmasPosition++;

            jumpCount++;
            if (emmasPosition == clouds.Length - 1)
                break;
        }
        return jumpCount;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

        int result = JumpingOnTheClouds(c);

        /*  textWriter.WriteLine(result);

          textWriter.Flush();
          textWriter.Close();*/

      Console.WriteLine(result);
       Console.ReadLine();
   }
} 



