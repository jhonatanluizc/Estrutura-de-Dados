using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Lista
    {
        private Node cabeca, calda;

        public Lista()
        {
            cabeca = null;
            calda = null;
        }

        public void Add(int valor)
        {
            if (cabeca == null)
            {
                cabeca = new Node(valor);
                calda = cabeca;
            }
            else
            {             
                calda.Prox = new Node(valor);
                calda = calda.Prox;              
            }
        }

        public void Print()
        {
            Node node = cabeca;
            while (node != null)
            {
                Console.WriteLine(node.Valor);
                node = node.Prox;
            }
        }

    }
}
