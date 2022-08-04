using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
//implementar Idisposable -> é uma interface , basta fazer uma "herança" em LeitorDeArquivo para receber isso
 //Dispose é o responsavel por fechar o arquivo.

                leitor.LerProximaLinha();
            }




         //// ------------------------------------------------------
         //   LeitorDeArquivo leitor = null;
         //   try
         //   {
         //      leitor = new LeitorDeArquivo("contas.txt");

         //       leitor.LerProximaLinha();
         //       leitor.LerProximaLinha();

         //       Console.ReadLine();
         //   }
         //   catch (IOException)
         //   {
         //       Console.WriteLine("Exceção do tipo IOException capturada e tratada!");

         //       Console.ReadLine();
         //   }
         //   finally
         //   {
         //       if(leitor != null)
         //       {
         //           leitor.fechar();
         //       }
                
            

        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(465, 456478);

                conta.Depositar(500); //há 50 reais na conta
                Console.WriteLine("Saldo Atual na conta é de R$" + conta.Saldo); //Saldo atual 150 reais
                conta.Sacar(500); // Tentativa de sacar 500 reais da conta (saldo insuficiente)
                conta.Transferir(1000, conta2);
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("informação da inner exception(exceção interna): ");

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }
    }
}