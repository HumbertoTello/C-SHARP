using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

// Interface não tem implementação, apenas informa que haverá uma determinada função dentro da classe.

namespace ByteBank
{
  public class ParceiroComercial : IAutenticavel
  {  
    public string Senha { get; set; }
    public bool Autenticar(string senha)
    {
      return Senha == senha;
    }
  }
}