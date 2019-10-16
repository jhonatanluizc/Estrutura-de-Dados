using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estrutura_de_Dados
{
    class Program
    {
        static void Main(string[] args)

        {

            fila.Fila fila = new fila.Fila();
            Console.WriteLine(fila.isEmpty());

            fila.push(2);
            Console.WriteLine(fila.isEmpty());

            fila.push(3);
            fila.pop();
            Console.WriteLine(fila.isEmpty());
            fila.pop();
            Console.WriteLine(fila.isEmpty());
            fila.push(9);
            Console.WriteLine(fila.isEmpty());
            fila.pop();
            Console.WriteLine(fila.isEmpty());
            fila.pop();



            Console.ReadKey();           
            Console.ReadKey();
        }
    }
}
