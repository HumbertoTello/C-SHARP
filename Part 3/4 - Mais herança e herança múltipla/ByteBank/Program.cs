﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args) // para invocar um método, é preciso que ele seja static também; ou: Program programa = new Program(); programa.CalcularBonificacao();
        {
          UsarSistema();
        }

        public static void UsarSistema()
        {
          SistemaInterno sistemaInterno = new SistemaInterno();

          Diretor roberta = new Diretor("159.753.398-04");
          roberta.Nome = "Roberta";
          roberta.Senha = "123";

          sistemaInterno.Logar(roberta, "123");
          sistemaInterno.Logar(roberta, "1234");
        }
        public static void CalcularBonificacao()
        {
          GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

          Designer pedro = new Designer("833.222.048-39");
          pedro.Nome = "Pedro";

          Diretor roberta = new Diretor("159.753.398-04");
          roberta.Nome = "Roberta";

          Auxiliar igor = new Auxiliar("981.198.778-53");
          igor.Nome = "Igor";

          GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
          camila.Nome = "Camila";

          Desenvolvedor guilherme = new Desenvolvedor("230.329.231-94");
          guilherme.Nome = "Guilherme";

          gerenciadorBonificacao.Registrar(guilherme);
          gerenciadorBonificacao.Registrar(pedro);
          gerenciadorBonificacao.Registrar(roberta);
          gerenciadorBonificacao.Registrar(igor);
          gerenciadorBonificacao.Registrar(camila);

          Console.WriteLine("Total de bonificações no mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
