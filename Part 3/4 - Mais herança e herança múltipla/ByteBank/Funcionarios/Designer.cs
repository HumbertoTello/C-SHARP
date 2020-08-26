using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
  public class Designer : Funcionario
  {  
    // a classe herdada precisa pegar a base cpf do pai; possível colocar valores padrões
    public Designer(string cpf) : base(3000, cpf) 
    {
    } 

    public override void AumentarSalario()
    {
      Salario *= 1.11;
    } 
    public override double GetBonificacao() // override significa que esse método sobrescreve o original
    {
      return Salario*0.17; // base. chama o método da classe pai
    }
  }
}