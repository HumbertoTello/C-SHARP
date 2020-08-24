using System;

namespace _3___Variáveis_numéricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 2 - criando variáveis");
            Console.WriteLine("Inteiros");
            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10+5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            Console.Write("Não pula linha ");

            Console.WriteLine("Sua idade é " + idade);

            Console.WriteLine("");
            Console.WriteLine("Double");
            
            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            double bananas;
            bananas = 15/2;
            Console.WriteLine("15/2: " + bananas);

            bananas = 15.0/2;
            Console.WriteLine("15.0/2: " + bananas);

            Console.WriteLine("");
            Console.WriteLine("Conversões e outros tipos numéricos");

            double x;
            x = 1200.50;

            int xEmInteiro;
            xEmInteiro = (int)x; // Isto é um casting
            Console.WriteLine(xEmInteiro);

            long y; // long tem 64 bits
            y = 26; // Limite de numero maior do que o int (2 bilhões - 32 bits)
            Console.WriteLine(y);

            short quantidadeProdutos;
            quantidadeProdutos = 150; // Short admite até 16 bits
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f; // Menor precisão em casas depois da vírgula que o double
            Console.WriteLine(altura);
        }
    }
}
