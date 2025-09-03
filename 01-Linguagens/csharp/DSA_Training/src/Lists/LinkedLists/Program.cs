using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
internal class LinkedListTraining
{
    public class Node
    {
        public int data;
        public Node? next;

        public Node(int newdata, Node? newNode = null)
        {
            this.data = newdata;
            this.next = newNode;
        }
    }

    static void Main(string[] args)
    {
        Node no = new Node(2, null);

        var numeros = new LinkedList<int>(); // Lista Padrão do C#

        numeros.AddLast(10);// [10]
        numeros.AddLast(20);// [10, 20]
        numeros.AddFirst(5);// [5, 10, 20]


    }
    
    public class MySimpleLinkedList
    {
        private Node? head;

        public void AddFirst(int value)
        {
            Node novo = new Node(value, head);
            head = novo;
        }

        public void AddLast(int value)
        {
            Node novo = new Node(value);

            if (head == null)
            {
                head = novo;
                return;
            }

            Node atual = head;
            while (atual.next != null)
            {
                atual = atual.next;
            }
            atual.next = novo;
        }

        public void AddBefore(Node target, int value)
        {
            if (head == null || target == null) return;

            if (head == target)
            {
                AddFirst(value);
                return;
            }

            Node atual = head;
            while (atual.next != null && atual.next != target)
            {
                atual = atual.next;
            }

            if (atual.next == target)
            {
                Node novo = new Node(value, target);
                atual.next = novo;
            }
        }

        public void AddAfter(Node target, int value)
        {
            if (head == null || target == null) return;

            Node atual = head;
            while (atual.next != null && atual != target)
            {
                atual = atual.next;
            }

            if (atual == target)
            {
                Node novo = new Node(value, target.next);
                target.next = novo;
            }

        }

        public void Remove(int value)
        {
            if (head == null) return;

            if (head.data == value)
            {
                head = head.next;
                return;
            }

            Node atual = head;
            while (atual.next != null)
            {
                if (atual.next.data == value)
                {
                    atual.next = atual.next.next;
                    return;
                }
                atual = atual.next;
            }
        }

        public int Find(int target)
        {
            if (head == null) return -1;

            Node atual = head;
            while (atual.next != null && atual.data != target)
            {
                atual = atual.next;
            }

            return atual.data;
        }

        public void PrintAll()
        {
            Node? atual = head;
            while (atual != null)
            {
                Console.Write(atual.data + " -> ");
                atual = atual.next;
            }
            Console.WriteLine("null");
        }
    }
}