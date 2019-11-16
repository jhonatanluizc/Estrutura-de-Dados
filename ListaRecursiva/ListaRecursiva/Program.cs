using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                
                int x = int.Parse(Console.ReadLine());
              //  int y = int.Parse(Console.ReadLine());

           
                Console.WriteLine(Ex7(x));
                Console.ReadKey();
                Console.Clear();
            }
          


           

        }

        public static int Ex7(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + (Ex7(n - 1));
            }
        }

            public static int Ex6(int x, int y)
        {
            int z;
            if (y == 0)
                return x;
            else
                z = (x * y) / (Ex3(x, y));
            return (z);
        }
            public static int Ex5(int x, int y)
        {
            bool cond = y != 0 && x != 0;

            if (x == y && cond)
            {
                return 1;
            }
            else if (x > y && cond)
            {
                return 1 + Ex5(x - y, y);
            }
            else if (x < y && cond)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

            public static int Ex4(int x, int y)
          {
            bool cond = y != 0 && x != 0;

            if (x == y && cond)
            {
                return 0;
            }
            else if (x > y && cond)
            {
                return Ex4(x - y, x);
            }
            else if (x < y && cond)
            {
                return x;
            }
            else
            {
                return -1;
            }

        }



            public static int Ex3(int x, int y)
        {
            if (x == y)
            {
                return x;
            }
            else if (x > y)
            {
                return (Ex3(x - y, y));
            }          
            else
            {
                return (Ex3(y - x, x));
            }
          

            
        }


            public static int Ex2(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return Ex2(++x,--y);
            }
        }

        public static int Ex1(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return x * (Ex1(x, n-1));
            }        
        }
    }
}
