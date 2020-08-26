using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
  public abstract class Funcionario // abstract significa que ele não pode ser invocado como uma classe em program, pois é somente uma abstração
  {
    public static int TotalDeFuncionarios { get; private set; }
    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; } // acessível somente na classe e nas classes derivadas

    public Funcionario(double salario, string cpf) // funciona para as classes herdeiras; primeiro é executado o construtor da classe base e depois o da classe herdeira
    {
      Console.WriteLine("Criando funcionário");

      CPF = cpf;
      Salario = salario;

      TotalDeFuncionarios++;
    }

    public abstract void AumentarSalario(); // este método não pode ser invocado
    public abstract double GetBonificacao();
  }
}