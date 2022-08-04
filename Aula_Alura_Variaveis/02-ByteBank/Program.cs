using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class program
    {
        static void Main(string[] args)
        {

            int questao = 3;

            if (questao == 0)
            {
                ContaCorrente conta = new ContaCorrente();

                conta.titular = "gabriela";

                Console.WriteLine(conta.titular);
                Console.WriteLine(conta.saldo);
            }

            if (questao == 1)
            {
                // comparação entre Referencias

                ContaCorrente contaDaGabriela = new ContaCorrente();
                contaDaGabriela.titular = "gabriela";
                contaDaGabriela.agencia = 863;
                contaDaGabriela.numero = 863452;

                ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
                contaDaGabrielaCosta.titular = "gabriela";
                contaDaGabrielaCosta.agencia = 863;
                contaDaGabrielaCosta.numero = 863452;

                Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela); // isso não é igual apesar dos dados iguais
                //devido ao endereço de memoria em que são salvos "contaDaGabriela" e "contaDaGabrielaCosta" são dif
                //então eles não são iguais.

            }

            if (questao == 2)
            {
                //utiliza uma função criada no codigo "contaCorrente" para fazer a função sacar. 

                ContaCorrente contaDoBruno = new ContaCorrente();
                contaDoBruno.titular = "Bruno";
                contaDoBruno.agencia = 863;
                contaDoBruno.numero = 863452;
                contaDoBruno.saldo = 10;

                ContaCorrente contaDaGabriela = new ContaCorrente();
                contaDaGabriela.titular = "gabriela";
                contaDaGabriela.agencia = 863;
                contaDaGabriela.numero = 863452;

                Console.WriteLine("Saldo Em Conta: " + contaDoBruno.saldo);
                bool ResultadoDoSaque = contaDoBruno.Sacar(50); //Como sacar é uma função ele precisa de parenteses

                Console.WriteLine("resultado do saque: " + ResultadoDoSaque);
                Console.WriteLine("Novo Saldo Em Conta: " + contaDoBruno.saldo);

                contaDoBruno.Depositar(500);
                Console.WriteLine(contaDoBruno.saldo);

                bool ResultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
                if (ResultadoTransferencia == true)
                {

                    string Transferencia = "Bem Sucedida";
                    Console.WriteLine("A Operação Foi: " + Transferencia);
                    Console.WriteLine("Saldo Do Bruno: " + contaDoBruno.saldo);
                    Console.WriteLine("saldo da Gabriela: " + contaDaGabriela.saldo);

                }

                if (ResultadoTransferencia == true)
                {

                    string Transferencia = "Bem Sucedida";
                    ResultadoTransferencia = contaDaGabriela.Transferir(100, contaDoBruno);
                    Console.WriteLine("A NOVA Operação Foi: " + Transferencia);
                    Console.WriteLine("O NOVO Saldo Do Bruno: " + contaDoBruno.saldo);
                    Console.WriteLine("O NOVO saldo da Gabriela: " + contaDaGabriela.saldo);

                }
            }

            if (questao == 3)
            {

                Cliente gabriela = new Cliente(); // chamou a classe "Cliente" criou um objeto chamado gabriela

                gabriela.nome = "Gabriela"; // definiu o nome daquele objeto
                gabriela.profissao = "desenvolvedora"; // definiu a profissão daquele objeto
                gabriela.cpf = "123.456.789-02"; // definiu o cpf daquele objeto

                ContaCorrente conta = new ContaCorrente(); // chamou a classe "ContaCorrente" e criou um objeto chamado conta

                conta.titular = gabriela; //definiu o titular daquele objeto "conta" como "gabriela" assim aponta o cliente gabriela a uma conta.
                conta.saldo = 500;
                conta.agencia = 563;
                conta.numero = 5634527;

                Console.WriteLine(gabriela.nome);
                Console.WriteLine(conta.titular.nome);

                Console.ReadLine();
            }
        }
    }
}