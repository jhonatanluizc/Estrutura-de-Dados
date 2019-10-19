using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Pilha
    {
        private Node topo;

        public Pilha()
        {
            topo = null;
        }


        public void isEmpty()
        {
            if (topo == null)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        public void push(int valor)
        {
            if (topo == null)
            {
                topo = new Node(valor);
            }
            else
            {
                Node n = new Node(valor);
                n.Prox = topo;
                topo = n;
            }
        }

        public void pop()
        {
            if (topo == null)
            {
                Console.WriteLine("vazio");
            }
            else
            {
                Console.WriteLine(topo.Valor);
                topo = topo.Prox;
            }


        }
    }
}
