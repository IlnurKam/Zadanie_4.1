using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, e = 1;
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if (e <= n * 2)
                {
                    s += e;
                    Console.WriteLine(s.ToString());
                    e += 2;
                }
            Console.ReadKey();
        }
    }
}