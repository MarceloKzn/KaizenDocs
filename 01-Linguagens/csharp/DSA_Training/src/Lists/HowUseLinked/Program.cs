using System;
public class vanillaLinkedList
{
    static void Main(string[] args)
    {
        var listaEncadeada = new LinkedList<int>();
        var head = new LinkedListNode<int>(3);

        listaEncadeada.AddLast(65); // [65]
        listaEncadeada.AddLast(22); // [65, 22]
        listaEncadeada.AddLast(17); // [65, 22, 17]
        listaEncadeada.AddFirst(head); // [3, 65, 22, 17]

        foreach (var n in listaEncadeada)
        {
            Console.Write($"[{n}] ");
        }

        Thread.Sleep(2500);
        Console.Clear();

        listaEncadeada.Remove(65);

        LinkedListNode<int>? no = listaEncadeada.Find(22) ?? listaEncadeada.Find(3);
        no ??= head;
        if (no != null)
        {
            listaEncadeada.AddAfter(no, 46); // [3, 22, 46, 17]
            listaEncadeada.AddBefore(no, 284); // [3, 284, 22 , 46, 17]
        }

        foreach (var n in listaEncadeada)
        {
            Console.Write($"[{n}] ");
        }
        Thread.Sleep(500);
        Console.Clear();

        listaEncadeada.RemoveLast(); // [3, 284, 22, 46]
        listaEncadeada.Remove(22);


        Console.ReadLine();
    }
}