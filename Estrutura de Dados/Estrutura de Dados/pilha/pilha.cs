using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados.pilha
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
                n.setBelow(topo);
                topo = n;
            }
        }

        public void pop()
        {
            if (topo == null)
            {
                Console.WriteLine("isEmpty");
            }
            else
            {
                Console.WriteLine(topo.getV());
                topo = topo.getBelow();
            }
            

        }






    }
}
