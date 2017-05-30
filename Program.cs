using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n*2; i++)
                Console.WriteLine("{0}{1}#{1}{0}", new string('.', n * 6 - 3 - 3 * i), new string ('#', 3*i));

            for (int i = 0; i < n-2; i++)
                Console.WriteLine("|{0}{1}{2}", new string ('.', 2+3*i), new string ('#', 12*n-5-1-2-3*i-3*(i+1)), new string('.', 3*(i+1)));
            
            for (int i = 0; i < n-1; i++)
                Console.WriteLine("|{0}{1}{2}", new string('.', 2 + 3 * (n - 2)), new string('#', 6 * n + 1), new string('.', 3 * (n - 1)));
            
            Console.WriteLine("@{0}{1}{2}", new string('.', 2+3*(n-2)), new string('#', 6*n+1), new string('.',  3 * (n - 1)));

            Console.WriteLine("GitHub Exercise");
        }
    }
}
