using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", ex2(12,0));
            Console.ReadKey();
        }

        static int ex1(int x, int n)
        {
            if (n == 0)
                return 1;
            return x * ex1(x, n-1);
        }

        static int ex2(int x, int y)
        {
            if (y == 0)
                return x;
            return ex2(++x, --y);
        }



    }
}
