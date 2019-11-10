using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            int[] AlexMMS = { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
            Console.WriteLine(string.Join(" ", AlexMMS.Select(k => k.ToString()).ToArray()));
            int K = 5;
            var query = AlexMMS.Where(n => AlexMMS.ElementAt(K) != n);
            Console.WriteLine(string.Join(" ", query.Select(k => k.ToString()).ToArray()));
            Console.ReadKey();
        }
    }
}


