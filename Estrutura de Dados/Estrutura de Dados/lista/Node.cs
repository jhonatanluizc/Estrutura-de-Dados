using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados
{
    class Node
    {
        //variavel para armazenar o valor
        public int v;
        //armazena o proximo endereco
        private Node next;

        //salva o valor e o proximo endereco
        public Node(int x)
        {
            v = x;
            next = null;
        }


        public void setNext(Node n)
        {
            next = n;
        }

        public Node getNext()
        {
            return next;
        }

        public int getV()
        {
            return v;
        }
    }
}
