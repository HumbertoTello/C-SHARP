using System;

namespace _6___Construtores_e_membros_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            

        }
    }
}
