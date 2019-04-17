using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n>=2 && n<=20)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n+" x "+i+" = "+(n*i));
                }
            }
        }
    }
}
