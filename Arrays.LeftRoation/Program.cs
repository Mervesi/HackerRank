using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.LeftRoation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] result = rotLeft(a, d);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            Console.ReadLine();
        }
        static int[] rotLeft(int[] a, int d)
        {
            int[] b = new int[a.Length];
            int index;
            int place;

            for (int i = 0; i < a.Length; i++)
            {
                index = i - d;
                place = a.Length + index;
                if (index>=0)
                {
                    b[index] = a[i];
                }
                else
                {
                    b[place] = a[i];
                }
            }
            return b;
        }
    }
}
