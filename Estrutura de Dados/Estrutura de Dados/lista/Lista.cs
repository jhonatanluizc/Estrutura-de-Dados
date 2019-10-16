using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Dados.lista
{
    class Lista
    {
        // head = cabeça
        // tail = cauda
        private Node head, tail;

        //metodo construtor
        public Lista()
        {
            head = null;
            tail = null;
        }

        //adiciona um int a lista
        public void add(int x)
        {
            //se nao existir nenhum valor salvo
            if (head == null)
            {
                //cria uma variavel do tipo node e adiciona o valor x
                head = new Node(x);
                //adiciona ao tail op primeiro elemento como se fosse o ultimo
                tail = head;
            }
            else
            {
                //adiciona ao tail um novo endereco e com ele tambem a envia o valor x
                tail.setNext(new Node(x));
                //adiciona ao tail o proximo endereco
                tail = tail.getNext();
            }
        }

        //metodo para printar valores da lista
        public void print()
        {
            //cria uma variavel do tipo Node e adiciona a ela o endereco do primeiro elemento
            Node n = head;
            while (n != null)
                {
                Console.WriteLine(n.getV());
                //pega o endereco do proximo elemento
                n = n.getNext();
            }
        }

        public int Tam
        {
            get
            {
                int t = 0;
                Node n = head;
                while (n != null)
                {
                    if (n != null)
                        t++;
                    n = n.getNext();
                }
                return t;
            }
        }

        public int Soma
        {
            get
            {
                int t = 0;
                Node n = head;
                while (n != null)
                {
                    if (n != null)
                        t+= n.getV();
                    n = n.getNext();
                }
                return t;
            }
        }

        public int valor(int index)
        {
            int cont = -1;
            int v = 0;
            Node n = head;
            while (n != null && cont < index)
            {
                v = n.getV();
                n = n.getNext();
                cont++;
            }
            return v;

        }

        public bool compare(Lista x)
        {
            if (x.Tam != this.Tam)
            {
                return false;
            }
            for (int i = 0; i < this.Tam; i++)
            {
                if (x.valor(i) != this.valor(i))
                    return false;            
            }
            return true;
        }

        public void reverse()
        {
            Lista t = new Lista();
            for (int i = 0; i < this.Tam; i++)
            {
                t.add(this.valor( (this.Tam-1)-i) );
            }

            t.print();

        }


    }
}
