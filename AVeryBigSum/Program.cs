using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {/ Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar)
        {
            ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = 0;

            foreach (var item in ar)
            {
                result += item;
            }
            return result;

        }

        static void Main(string[] args)
        {


            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = new long[arCount];



            Console.WriteLine(aVeryBigSum(ar));
        }
    }
}
