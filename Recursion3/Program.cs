using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion3
{
    class Program
    {
        static int Factorial(int n)
        {
            int result = 1;

            for (int i = n; 0 < i; i--)
            {
                result =result*i;
             
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
