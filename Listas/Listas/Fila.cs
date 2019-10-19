using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Fila
    {
        private Node inicio, fim;

        public Fila()
        {
            inicio = null;
            fim = null;
        }

        public void isEmpty()
        {
            if (inicio == null)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        public void push(int valor)
        {
            if (inicio == null)
            {
                inicio = new Node(valor);
                fim = inicio;
            }
            else
            {
                fim.Prox = new Node(valor);
                fim = fim.Prox;
            }
        }

        public void pop()
        {
            if (inicio == null)
            {
                Console.WriteLine("vazio");
            }
            else
            {
                Node n = inicio;
                Console.WriteLine(n.Valor);
                if (n.Prox == inicio)
                {
                    inicio = null;
                }
                else
                {
                    inicio = n.Prox;
                }
            }
        }

    }
}
