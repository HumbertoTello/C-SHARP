using System;

namespace _5___Controle_de_fluxo_com_if
{
  class Program
  {
    static void Main(string[] args)
    {
      /* AULA 1 */
      // Console.WriteLine("Aula 5 - Controle de fluxo com IF");

      // int idadeJoao = 16;
      // int quantidadePessoas = 2;

      // if (idadeJoao >= 18)
      // {
      //   Console.WriteLine("João possui mais de 18 anos, pode entrar");
      // }
      // else
      // {
      //   if (quantidadePessoas >= 2)
      //   {
      //     Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado, pode entrar");
      //   }
      //   else
      //   {
      //     Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
      //   }
      // }

      /* Variável booleana */
      // Console.WriteLine("Aula 5 - Controle de fluxo com IF");

      // int idadeJoao = 16;
      // // int quantidadePessoas = 2;
      // // bool acompanhado = quantidadePessoas >= 2;
      // bool acompanhado = true;

      // if (idadeJoao >= 18 && acompanhado == true)
      // {
      //   Console.WriteLine("João pode entrar");
      // }
      // else
      // {
      //   Console.WriteLine("João não pode entrar");
      // }

      /* Escopo */
      Console.WriteLine("Aula 5 - Controle de fluxo com IF");

      int idadeJoao = 18;
      bool acompanhado = false;
      string mensagemAdicional;

      // Somete dentro daquele bloco de código existe uma determinada variáveldd

      if (acompanhado == true)
      {
        mensagemAdicional = "João está acompanhado!";
      }
      else
      {
        mensagemAdicional = "João não está acompanhado";
      }

      if (idadeJoao >= 18 && acompanhado == true)
      {
        Console.WriteLine("João pode entrar");
        Console.WriteLine(mensagemAdicional);
      }
      else
      {
        Console.WriteLine("João não pode entrar");
        Console.WriteLine(mensagemAdicional);
      }

      /* Switch */
      int mes = 10;

      switch (mes)
      {
        case 1:
          Console.WriteLine("O mês é Janeiro");
          break;
        case 2:
          Console.WriteLine("O mês é Fevereiro");
          break;
        case 3:
          Console.WriteLine("O mês é Março");
          break;
        case 4:
          Console.WriteLine("O mês é Abril");
          break;
        case 5:
          Console.WriteLine("O mês é Maio");
          break;
        case 6:
          Console.WriteLine("O mês é Junho");
          break;
        case 7:
          Console.WriteLine("O mês é Julho");
          break;
        case 8:
          Console.WriteLine("O mês é Agosto");
          break;
        case 9:
          Console.WriteLine("O mês é Setembro");
          break;
        case 10:
          Console.WriteLine("O mês é Outubro");
          break;
        case 11:
          Console.WriteLine("O mês é Novembro");
          break;
        case 12:
          Console.WriteLine("O mês é Dezembro");
          break;
        default:
          Console.WriteLine("Mês inválido");
          break;
      }
    }


  }
}
