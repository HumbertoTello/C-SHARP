using System;

namespace _4___Variáveis_de_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a'; //Character exige aspas simples
            Console.WriteLine(primeiraLetra);
            
            primeiraLetra = (char)65; //Ascii table
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2020;
            string cursosProgramacao = @" - .NET
 - Java
 - Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            string vazia = "";
            Console.WriteLine(vazia);
            Console.WriteLine("Atribuição de variáveis");

            int idade = 32;
            int idadeGustavo = idade;
            idade = 20;
            
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo); // Variáveis guardam valores e não referências
        }
    }
}
