using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var phoneBook = new Dictionary<string, int>();

            for (var i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(' ');
                var name = entry[0];
                var phone = int.Parse(entry[1]);
                phoneBook.Add(name, phone);
            }

            for (var i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                if (phoneBook.ContainsKey(name))
                {
                    var phone = phoneBook[name];
                    Console.WriteLine($"{name}={phone}");
                }
                else Console.WriteLine("Not found");
            }
        }
    }
}
