using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados.fila
{
    class Node
    {
        //variavel para armazenar o valor
        public int v;
        //armazena o endereco anterior
        private Node before;

        //salva o valor e o endereco anterior
        public Node(int x)
        {
            v = x;
            before = null;
        }


        public void setBefore(Node n)
        {
            before = n;
        }

        public Node getBefore()
        {
            return before;
        }

        public int getV()
        {
            return v;
        }
    }
}
