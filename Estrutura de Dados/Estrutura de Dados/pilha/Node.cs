using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados.pilha
{
    class Node
    {
        //variavel para armazenar o valor
        public int v;
        //armazena o endereco anterior
        private Node below;

        //salva o valor e o endereco anterior
        public Node(int x)
        {
            v = x;
            below = null;
        }


        public void setBelow(Node n)
        {
            below = n;
        }

        public Node getBelow()
        {
            return below;
        }

        public int getV()
        {
            return v;
        }
    }
}
