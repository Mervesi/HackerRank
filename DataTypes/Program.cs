using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = Convert.ToInt32(Console.ReadLine());

            double doubleDeger = Convert.ToDouble(Console.ReadLine());

            string metin = Console.ReadLine();

            integer = 4 + integer;
            doubleDeger = 4.0 + doubleDeger;
            metin = "HackerRank " + metin;

            Console.WriteLine(integer);
            Console.WriteLine(doubleDeger.ToString("#.0"));//virgülden sonrasını yazmak ıçin
            Console.WriteLine(metin);



        }
    }
}
