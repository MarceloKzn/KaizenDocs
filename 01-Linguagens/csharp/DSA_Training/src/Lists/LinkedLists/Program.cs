using System;
public class LinkedListTraining
{
    public class Node
    {
        public int data;
        public Node? next;

        public Node(int newdata, Node? newNode)
        {
            this.data = newdata;
            this.next = newNode;
        }
    }

    static void Main(string[] args)
    {
        Node n = new Node(2, null);
        
    }
}