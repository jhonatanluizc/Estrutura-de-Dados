using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados.fila
{
    class Fila
    {
        private Node inicio, fim;

        public Fila()
        {
            inicio = null;
            fim = null;
        }

        public bool isEmpty()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        public void push(int x)
        {
            if (inicio == null)
            {
                inicio = new Node(x);
                fim = inicio;
            }
            else
            {
                fim.setBefore(new Node(x));
                fim = fim.getBefore();
            }
        }

        public void pop()
        {
            if (inicio == null)
            {
                Console.WriteLine("isEmpty");
            }
            else
            {
                Node n = inicio;
                Console.WriteLine(n.getV());             
                if (n.getBefore() == inicio)
                {
                    inicio = null;
                }
                else
                {
                    inicio = n.getBefore();
                }
            }
        }





    }
}
