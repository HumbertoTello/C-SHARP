namespace _6___Construtores_e_membros_estáticos
{
  public class ContaCorrente
  {
    public Cliente Titular { get; set; } // Encurtamento de referência a get e set simples
    public static int TotalDeContasCriadas { get; private set; } // Propriedade pertencente a classe, todos os objetos compartilham dessa informação // Private não permite setar indevidamente

    public int agencia;
    public int Agencia 
    { 
      get
      {
        return agencia;
      } 
      set
      {
        if(value <= 0)
        {
          return;
        }

        agencia = value;
      } 
    }
    public int numero;
    public int Numero { get; set; }
    private double _saldo = 100; //Como é private, não pode ser acessado em Program. Ele está encapsulado. Para não confundir com Saldo, usa-se _ antes

    public double Saldo
    {
      get
      {
        return _saldo;
      }
      set
      {
        if (value < 0)
        {
          return;
        }

        _saldo = value; // value é palavra reservada e representa o this
      }
    }

    // public void SetSaldo(double _saldo)
    // {
    //   if (_saldo < 0)
    //   {
    //     return; // Para de executar imediatamente o método
    //   }

    //   this._saldo = _saldo; // this acessa o campo do objeto e não o argumento
    // }

    // public double GetSaldo()
    // {
    //   return _saldo;
    // }

    public ContaCorrente(int agencia, int numero) // construtor
    {
      Agencia = agencia;
      Numero = numero;

      TotalDeContasCriadas++;
    }

    public bool Sacar(double valor) // Utilizar nome da função com letra maiúscula e usando verbos infinitivos. É função pois retorna algo
    {
      if (_saldo < valor) // this acessa a instância da classe
      {
        return false;
      }

      _saldo -= valor;
      return true;
    }

    public void Depositar(double valor) // Método, pois não retorna nada
    {
      _saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
      if (_saldo < valor)
      {
        return false;
      }

      _saldo -= valor;
      contaDestino.Depositar(_saldo);
      return true;
    }
  }
}