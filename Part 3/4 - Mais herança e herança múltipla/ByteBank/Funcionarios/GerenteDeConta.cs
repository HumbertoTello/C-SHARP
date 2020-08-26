using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
  public class GerenteDeConta : Autenticavel
  {  
    // a classe herdada precisa pegar a base cpf do pai; possível colocar valores padrões
    public GerenteDeConta(string cpf) : base(4000, cpf) 
    {
    } 

    public override void AumentarSalario()
    {
      Salario *= 1.05;
    } 
    public override double GetBonificacao() // override significa que esse método sobrescreve o original
    {
      return Salario*0.25; // base. chama o método da classe pai
    }
  }
}