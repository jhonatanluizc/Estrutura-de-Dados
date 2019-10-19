using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Node
    {
        private Node prox;
        private int valor;

        public Node(int valor)
        {
            prox = null;
            this.valor = valor;
        }

        public Node Prox
        {
            set { prox = value; }
            get { return prox; }
        }

        public int Valor
        {          
            get { return valor; }
        }
    }
}
