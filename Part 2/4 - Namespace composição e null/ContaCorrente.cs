// using _4___Namespace_composição_e_null;

namespace _4___Namespace_composição_e_null
{
  public class ContaCorrente
  {
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor) // Utilizar nome da função com letra maiúscula e usando verbos infinitivos. É função pois retorna algo
    {
      if (this.saldo < valor) // this acessa a instância da classe
      {
        return false;
      }

      this.saldo -= valor;
      return true;
    }

    public void Depositar(double valor) // Método, pois não retorna nada
    {
      this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
      if(this.saldo < valor)
      {
        return false;
      }

      this.saldo -= valor;
      contaDestino.Depositar(this.saldo);
      return true;
    }
  }
}