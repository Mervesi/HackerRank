using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if(N % 2 != 0)
                Console.WriteLine("Weird");
            else if (N % 2 == 0)
            {
                if (2<=N && N<5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (6<=N && N<=20)
                {
                    Console.WriteLine("Weird");
                }
                else if (N>20)
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}
