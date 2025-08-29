using System;
public class vanillaLinkedList
{
    static void Main(string[] args)
    {
        var listaLincada = new LinkedList<int>();
        var head = new LinkedListNode<int>(3);

        listaLincada.AddLast(65); // [65]
        listaLincada.AddLast(22); // [65, 22]
        listaLincada.AddLast(17); // [65, 22, 17]
        listaLincada.AddFirst(head); // [3, 65, 22, 17]

        foreach (var n in listaLincada)
        {
            Console.Write($"[{n}] ");
        }

        Thread.Sleep(2500);
        Console.Clear();

        listaLincada.Remove(65);

        LinkedListNode<int> no = listaLincada.Find(22) ?? listaLincada.Find(3);
        no ??= head;
        if (no != null)
        {
            listaLincada.AddAfter(no, 46); // [3, 22, 46, 17]
            listaLincada.AddBefore(no, 284); // [3, 284, 22 , 46, 17]
        }

        foreach (var n in listaLincada)
        {
            Console.Write($"[{n}] ");
        }
        Thread.Sleep(500);
        Console.Clear();

        listaLincada.RemoveLast(); // [3, 284, 22, 46]
        listaLincada.Remove(22);


        Console.ReadLine();
    }
}