
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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int CountingValleys(int steps, string path)
    {

        int seviye = 0;
        int[] dizi = new int[steps];

        for (int i = 0; i < steps; i++)
        {
            // int seviye = 0;
            

            if (path[i] == 'D')
            {
                seviye--;
            }
            else if (path[i] == 'U')
            {
                seviye++;
            }
            dizi[i] = seviye;
        }
        int donus = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i]==0 && dizi[(i-1)]<0)
            {
                donus++;
            }
        }
        //int donus = dizi.Min();
        return System.Math.Abs(donus);
    }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Result.CountingValleys(steps, path);

        Console.WriteLine(result);
        Console.ReadLine();

           // textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            int steps;
            string path;

            steps= Convert.ToInt32(Console.ReadLine());
            path = Console.ReadLine();

            int valleys=Hesaplama(steps, path);

            Console.WriteLine(valleys);
            Console.ReadLine();
        }
        static int Hesaplama(int steps,string path)
        {
            int seviye = 0;
            for (int i = 0; i < steps; i++)
            {
               // int seviye = 0;

                if (path[i]=='D')
                {
                    seviye--;
                }
                else if(path[i]=='U')
                {
                    seviye++; 
                }
            }
            return seviye;
        }
    }*/


