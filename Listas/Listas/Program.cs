using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Pilha pilha = new Pilha();
            Fila fila = new Fila();

            fila.isEmpty();
            fila.push(1);
            fila.push(2);
            fila.isEmpty();
            fila.push(3);
            fila.pop();
            fila.pop();
            fila.pop();
            fila.isEmpty();

            Console.ReadKey();


        }
    }
}
