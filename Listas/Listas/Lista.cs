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

        public void Tam()
        {
            int c = 0;
            Node node = cabeca;
            while (node != null)
            {
                c++;
                node = node.Prox;
            }
            Console.WriteLine(c);
        }
  
        public void Soma()
        {
            int total = 0;
            Node node = cabeca;
            while (node != null)
            {
                total += node.Valor;
                node = node.Prox;
            }
            Console.WriteLine(total);
        }

        public Node Cabeca
        {
            get { return cabeca; }
        }

        public void Compare(Lista lista1, Lista lista2)
        {
            bool op = true;
            Node node1 = lista1.Cabeca;
            Node node2 = lista2.Cabeca;
            while (node1 != null)
            {
                if (node2 == null || node1.Valor != node2.Valor)
                {
                    op = false;
                    break;
                }
                node1 = node1.Prox;
                node2 = node2.Prox;
            }
            if (op)
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");
        }

        public int valor(int index)
        {
            int cont = -1;
            int v = 0;
            Node n = cabeca;
            while (n != null && cont < index)
            {
                v = n.Valor;
                n = n.Prox;
                cont++;
            }
            return v;
        }

        public void Reverse()
        {
            int tam = 0;
            Node node = cabeca;
            while (node != null)
            {
                tam++;
                node = node.Prox;
            }
            Lista t = new Lista();
            for (int i = 0; i < tam; i++)
            {
                t.Add(this.valor((tam - 1) - i));
            }
            t.Print();
        }
    }
}
