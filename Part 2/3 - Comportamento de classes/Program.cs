using System;

namespace _3___Comportamento_de_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(50); // a variável e a função precisam ser do mesmo tipo
            Console.WriteLine(contaDoBruno.saldo);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGarbiela = new ContaCorrente();
            contaDaGarbiela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGarbiela.saldo);

            bool resultadoDaTransferencia = contaDoBruno.Transferir(200, contaDaGarbiela);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGarbiela.saldo);

            Console.WriteLine("Resultado da transferência: " + resultadoDaTransferencia);
        }
    }
}
