using System;
using System.Runtime.CompilerServices;
using System.Threading;

// sinceramente só fiz essa classe para testar algumas coisas
public class Commands
{

    public void Write(string word)
    {
        if (!string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine(word);
        }
    }
    public void Clear()
    {
        Wait(1);
        Console.Clear();
    }
    public void Wait(int t)
    {
        Thread.Sleep(t * 100);
    }
    public dynamic Input(dynamic Var)
    {
        /*string b;
        if (Var is string)
        {
            b = Var;
            if (!string.IsNullOrEmpty(b))
            {
                return 0;
            }
        }*/

        switch (Var)
        {
            case object i when i is int:
                Console.WriteLine($" {i} é um Número");
                // seu valor é retornado, agora pode ser usado em Cálculos
                // (Obvio que ReadLine também pode ser usado Diratamente na Main pra isso) Ex: Console.ReadLine();                
                return Var;
            case object i when i is string:
                if (!string.IsNullOrWhiteSpace(Var))
                {
                    return Var;
                }
                Console.WriteLine($" {i} é uma Palavra");
                break;
            case object i when i.GetType() == typeof(double):
                Console.WriteLine($" {i} é um Número Double");
                return Var;
            default:
                Console.WriteLine($" {Var} não Existe! ou não tem um tipo");
                return 0;
        }
        return Var;

        /*  is: Verifica a compatibilidade de tipo, ou seja,
            se a variável pode ser usada como um objeto do tipo especificado.
            Ele retorna true se a variável for do tipo
            especificado ou de um tipo derivado dele, e false caso contrário.

            GetType(): Retorna o tipo exato da variável em tempo de execução
        */


        /*
         if (!string.IsNullOrWhiteSpace(Var))
            {
                Console.Write((string)Var);
                string input = Console.ReadLine();
                int x;
                if (int.TryParse(input, out x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Entrada inválida para número inteiro.");
                    return Var;
                }
            }
        */
    }
}