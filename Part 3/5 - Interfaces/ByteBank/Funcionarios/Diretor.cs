using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
  public class Diretor : FuncionarioAutenticavel
  {
    // a classe herdada precisa pegar a base cpf do pai; possível colocar valores padrões
    public Diretor(string cpf) : base(5000, cpf)
    {
      Console.WriteLine("Criando DIRETOR");
    }
    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }
    public override double GetBonificacao() // override significa que esse método sobrescreve o original
    {
      return Salario * 0.5; // base. chama o método da classe pai
    }
  }
}