using System;

public class Calculadora
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n[Calculadora]\n");

        int quantidadeNumeros = PerguntarQuantidadeNumeros();

        if (quantidadeNumeros < 2 || quantidadeNumeros > 4)
        {
            Console.WriteLine("\nQuantidade inválida. Encerrando...");
            return;
        }

        int[] numeros = LerNumeros(quantidadeNumeros);

        string operacao = EscolherOperacao();

        int resultado = CalcularResultado(numeros, operacao);

        Console.WriteLine($"\nResultado da {operacao}: {resultado}");
    }

    static int PerguntarQuantidadeNumeros()
    {
        Console.WriteLine("\nDeseja calcular quantos números?");
        Console.WriteLine("- Dois [1]");
        Console.WriteLine("- Três [2]");
        Console.WriteLine("- Quatro [3]");
        Console.Write("\nDigite o número correspondente: ");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            return opcao + 1; // 1 = dois números, então +1
        }

        return -1;
    }

    static int[] LerNumeros(int quantidade)
    {
        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            while (true)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    numeros[i] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
            }
        }

        return numeros;
    }

    static string EscolherOperacao()
    {
        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("[+] Soma");
        Console.WriteLine("[-] Subtração");
        Console.WriteLine("[*] Multiplicação");
        Console.WriteLine("[/] Divisão");

        while (true)
        {
            Console.Write("Digite a operação (+, -, *, /): ");
            string? op = Console.ReadLine();

            if (op == "+" || op == "-" || op == "*" || op == "/")
                return op;

            Console.WriteLine("Operação inválida.");
        }
    }

    static int CalcularResultado(int[] numeros, string operacao)
    {
        int resultado = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            switch (operacao)
            {
                case "+":
                    resultado += numeros[i];
                    break;
                case "-":
                    resultado -= numeros[i];
                    break;
                case "*":
                    resultado *= numeros[i];
                    break;
                case "/":
                    if (numeros[i] == 0)
                    {
                        Console.WriteLine("\nErro: divisão por zero!");
                        Environment.Exit(0);
                    }
                    resultado /= numeros[i];
                    break;
            }
        }

        return resultado;
    }
}