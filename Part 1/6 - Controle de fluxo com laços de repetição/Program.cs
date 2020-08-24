using System;

namespace _6___Controle_de_fluxo_com_laços_de_repetição
{
  class Program
  {
    static void Main(string[] args)
    {
      /* While */
      // Console.WriteLine("Aula 6 - Controle de fluxo com laços de repetição");

      // double valorInvestido = 1000;
      // int contadorMes = 1;

      // while (contadorMes <= 12) {
      //   valorInvestido = valorInvestido + valorInvestido * 0.0036;
      //   Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
      //   contadorMes++;
      // }

      /* Laço for */
      // double valorInvestido = 1000;
      // Console.WriteLine("Laço for");
      // for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
      // {
      //   valorInvestido *= 1.0036;
      //   Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
      // }

      /* Laço for encadeado */
      // Console.WriteLine("Encadeando laços for");
      // double valorInvestido = 1000;
      // double fatorRendimento = 1.0036;
      // for(int contadorAno = 1; contadorAno <= 5; contadorAno++){
      //   for(int contadorMes = 1; contadorMes <= 12; contadorMes++){
      //     valorInvestido *= fatorRendimento;
      //   }
      //   fatorRendimento += 0.0010;
      // }

      // Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);

      /* A palavra chave break */
      Console.WriteLine("Break");
      for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
      {
        for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
        {
          Console.Write("*");
          if (contadorColuna >= contadorLinha)
            break;
        }
        Console.WriteLine();
      }

      /* Outra forma */
      for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
      {
        for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

      int fatorial = 1;
      for (int n = 1; n <= 10; n++) {
        fatorial *= n;
        Console.WriteLine(fatorial);
      }
    }
  }
}
