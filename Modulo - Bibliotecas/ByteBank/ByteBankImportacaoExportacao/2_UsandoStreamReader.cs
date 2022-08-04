//using ByteBankImportacaoExportacao;
//using ByteBank.Modelos;
//using System;
//using System.Collections.Generic;
//using System.IO; //input e output
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ByteBankImportacaoExportacao
//{
//    partial class program
//    {
//        static void UsarStreamReader()
//        {
//            var enderecoArquivo = "contas.txt";

//            using (var fluxoDeArquivo = new FileStream(enderecoArquivo, FileMode.Open))
//            using (var leitor = new StreamReader(fluxoDeArquivo))
//            {
//                while (!leitor.EndOfStream)
//                {
//                    var linha = leitor.ReadLine();
//                    var contaCorrente = ConverterStringParaContaCorrente(linha);

//                    Console.WriteLine($"{contaCorrente.Titular.Nome} : conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo: {contaCorrente.Saldo}");

//                }
//            }
//            Console.ReadLine();
//        }

//        static ContaCorrente ConverterStringParaContaCorrente(string linha)
//        {
//            string[] campos = linha.Split(','); // da um espaço quando encontrar o caractere representado

//            var agencia = campos[0];
//            var numero = campos[1];
//            var saldo = campos[2].Replace('.', ','); // troca os . por ,
//            var nomeTitular = campos[3];

//            var agenciaComoInt = int.Parse(agencia);
//            var numeroComoInt = int.Parse(numero);
//            var saldoComoDouble = double.Parse(saldo);

//            var titular = new Cliente();
//            titular.Nome = nomeTitular;

//            //var resultado = new ContaCorrente(agencia, numero);
//            //resultado.Depositar(saldoComoDouble);
//            //resultado.Titular = titular;

//            return (null); // feito pro codigo para de encher meu saco , isso está errado
//        }
//    }
//}
