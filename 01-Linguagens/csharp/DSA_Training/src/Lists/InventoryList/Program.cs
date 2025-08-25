using System;
public class Inventory
{
    static void Main(string[] args)
    {
        var inventario = new List<string>();

        inventario.Add("Espada");
        inventario.Add("Poção");
        inventario.Add("Escudo");

        foreach (var i in inventario)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
        }

        Thread.Sleep(1500);
        Console.Clear();

        if (inventario.Contains("Poção"))
        {
            Console.WriteLine($"tem Poções no invetário: {inventario.IndexOf("Poção")} Index");
            Thread.Sleep(500);
        }
        else
        {
            inventario.Insert(0, "Poção");
        }

        inventario.RemoveAt(0);// .Remove("NomeDoItem") enquanto o RemoveAt(index) precisa do índice
        if (!inventario.Contains("Espada"))
        {
            Console.WriteLine("Espada Removida do Inventario");
            Thread.Sleep(1500);
        }
        Thread.Sleep(500);
        Console.Clear();

        inventario.Sort();
        Console.WriteLine("Inventário Organizado");
        Thread.Sleep(1000);

        foreach (var i in inventario)
        {
            Console.WriteLine($"\n Itens no Inventário: {i} ");
        }


        //string? resp = Console.ReadLine() ? string.Empty : "Resposta Vazia!";
    }
}