using System;

namespace _2___Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Valores padrões 
          ContaCorrente conta = new ContaCorrente();
          conta.titular = "Gabriela";

          Console.WriteLine(conta.titular);
          Console.WriteLine(conta.saldo);
          */

          ContaCorrente contaDaGabriela = new ContaCorrente(); // Passagem por referência (endereço) 
          contaDaGabriela.titular = "Gabriela";
          contaDaGabriela.agencia = 863;
          contaDaGabriela.numero = 863452;

          ContaCorrente contaDaGabrielaCosta = new ContaCorrente(); // Passagem por referência (endereço)
          contaDaGabrielaCosta.titular = "Gabriela";
          contaDaGabrielaCosta.agencia = 863;
          contaDaGabrielaCosta.numero = 863452;

          Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // False
          contaDaGabrielaCosta = contaDaGabriela;
          Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // True
          contaDaGabriela.saldo = 300;
          Console.WriteLine(contaDaGabriela.saldo);
          Console.WriteLine(contaDaGabrielaCosta.saldo);

          int idade = 27; // Passagem por valor
          int idade2 = 27; // Passagem por valor
          Console.WriteLine(idade == idade2); // True
        }
    }
}
