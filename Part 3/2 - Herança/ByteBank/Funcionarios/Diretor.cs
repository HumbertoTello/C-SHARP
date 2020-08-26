using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
  public class Diretor : Funcionario
  {    
    public override double GetBonificacao() // override significa que esse método sobrescreve o original
    {
      return Salario + base.GetBonificacao(); // base. chama o método da classe pai
    }
  }
}