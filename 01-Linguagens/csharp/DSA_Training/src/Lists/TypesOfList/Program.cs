using System;
public class TiposDeListas
{
    struct Point // Estrutura gênerica
    {
        public int x, y;
    }
    static void Main(string[] args)
    {
        //var p = new Point { X = 10, Y = 20 };
        //Console.WriteLine($"Ponto: ({p.X}, {p.Y})");

        var cmd = new TiposDeListas();

        //var listaNomes = new List<string> { "Maria", "João", "Ana" }; // inicializa vazia => List<T>(){...};

        var fiveNames = new List<string>();

        var numb = 5;
        var pass = false;

        while (fiveNames.Count < 5 && pass != true)
        {
            cmd.Clear();

            cmd.Write($"\n Agora vamos fazer um Teste, Adicione {numb} nomes em uma Lista!");
            string newName = cmd.Read() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(newName))
            {
                fiveNames.Add(newName);
                numb--;
            }

            for (int i = 0; i < 5 && fiveNames.Count >= 5; i++)
            {
                pass = true;
                cmd.Write($"\n{fiveNames[i].ToString()} ({i + 1}) lugar na Lista");
                cmd.Wait(100);
            }

        }
        cmd.Wait(90);
        cmd.Write("saiu do loop");
        cmd.Wait(110); cmd.Clear();

        var rlist = new List<string>
        {
            fiveNames[0].ToString(),
            fiveNames[1].ToString(),
            fiveNames[2].ToString(),
            fiveNames[3].ToString(),
            fiveNames[4].ToString(),"Junior", "Annabet", "James", "Maicon"};
        var rnd = new Random();
        var random = rnd.Next(0, 8);
        if (random > 3)
        {
            cmd.Write($"z\n O nome: {rlist[random]} existe na Sua Lista?");
            var n = rlist[random].ToString();

            cmd.Wait(170);
            if (!fiveNames.Contains(n))
            {
                fiveNames.Insert(2, n);
                cmd.Clear();
                foreach (var b in fiveNames)
                {
                    cmd.Write(b);
                    cmd.Wait(70);
                }
            }
        }
        cmd.Wait(90);
        cmd.Clear();

        foreach (var n in fiveNames)
        {
            cmd.Write(n);
            cmd.Wait(60);
        }
        cmd.Write($"Escolha um Nome para Remover da Lista");
        string r = cmd.Read() ?? string.Empty;

        while (!fiveNames.Contains(r) || !string.IsNullOrWhiteSpace(r))
        {
            cmd.Clear();
            foreach (var n in fiveNames)
            {
                cmd.Write(n);
            }

            cmd.Write($"\nEscolha um Nome para Remover da Lista");

            r = cmd.Read() ?? string.Empty;

            if (fiveNames.Contains(r))
            {
                fiveNames.Remove(r);
                cmd.Write($"\n Removeu {r} da Lista (Dentro do While)");
                cmd.Wait(80);
                break;
            }
        }
        cmd.Wait(85);
        fiveNames.Remove(r);
        cmd.Write($"\n->{r} removido com Sucesso!");

        fiveNames.Sort();
        for (int i = 0; i < fiveNames.Count; i++)
        {
            cmd.Write($"{fiveNames[i]}");
            cmd.Wait(100);
        }
    
        Console.ReadLine();    

    }// final da Main()

    string Write(string word)
    {
        if (!string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine(word);
        }
        return word;
    }

    string? Read(string? resp = "") //(string? resp = null) too
    {
        if (string.IsNullOrWhiteSpace(resp))
        {
            resp = Console.ReadLine();
        }

        return resp ?? "Resposta Inválida!";
    }

    public void AddList(List<string>? lista, string? valor) // como representar qualquer tipo? 
    {
        if (lista is not null && valor is not null)
        {
            if (string.IsNullOrWhiteSpace(valor)) return;

            lista?.Add(valor);
        }
        //lista?.Add(valor); => "lista" may be null here      
    }

    void Stack(Stack<object> pilha)
    {
        pilha.Push(1); // Push
        pilha.Pop(); // Pop => return 1
    }

    void Queue()
    {
        var queue = new Queue<int>();
        queue.Enqueue(2); // Enqueue
        queue.Dequeue(); // Dequeue => return 2
    }
    void Wait(int t)
    {
        if(t >= 10)
        {
            Thread.Sleep(t * 10);
        }
    }
    void Clear()
    {
        Wait(15);
        Console.Clear();
    }
}