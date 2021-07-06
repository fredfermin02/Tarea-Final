using System;
using System.Collections.Generic;
namespace IntList
{
  class Program
    {
      class ListNode
      {
        public int datos;
        public ListNode next;

        public ListNode (int x)
        {
          datos = x;
          next = null;
        }
      }

      class LinkedList
      {
        int Cantidad;
        ListNode primerValor;

        public LinkedList()
        {
          primerValor = null;
          Cantidad = 0;
        }

        public void agregar(int x)
        {
          ListNode node = new  ListNode(x);
          node.next = primerValor;
          primerValor = node;
          Cantidad++;
        }
      }
      public static void Main(string[] args)
      {
        LinkedList lista = new LinkedList();
        lista.agregar(4);
        lista.agregar(3);
        lista.agregar(5);
        lista.agregar(1);
      }
    }
}
