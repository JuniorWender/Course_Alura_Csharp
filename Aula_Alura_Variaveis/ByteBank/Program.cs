using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class program
    {
        static void Main(string[] args)
        {
            int questao = 3;

            if (questao == 0)
            {
                Cliente gabriela = new Cliente(); // chamou a classe "Cliente" criou uma referencia chamada gabriela de um objeto chamado cliente

                gabriela.Nome = "Gabriela"; // definiu o nome daquele objeto
                gabriela.Profissao = "desenvolvedora"; // definiu a profissão daquele objeto
                gabriela.CPF = "123.456.789-02"; // definiu o cpf daquele objeto

                ContaCorrente conta = new ContaCorrente(); // chamou a classe "ContaCorrente" e criou um objeto chamado conta

                conta.Titular = gabriela; // "Linkou" conta.titular ao cliente gabriela , então gabriela.nome e conta.titular agora são iguais
                //conta.saldo = 500;
                conta.Agencia = 563;
                conta.Numero = 5634527;

                conta.Titular.Nome = "Gabriela Costa";

                Console.WriteLine(gabriela.Nome);
                Console.WriteLine(conta.Titular.Nome);

                Console.ReadLine();
            }

            if (questao == 1)
            {

                ContaCorrente Conta = new ContaCorrente();

                Conta.Titular = new Cliente(); // amarra titular a classe cliente linkando ambas
                Conta.Titular.Nome = "Gabriela Costa";
                Conta.Titular.CPF = "123.456.789-02";
                Conta.Titular.Profissao = "desenvolvedora";

                //Conta.saldo = 500;
                Conta.Agencia = 563;
                Conta.Numero = 5634527;
            }

            if(questao == 2)
            {

                ContaCorrente Conta = new ContaCorrente();
                //--------------------------------------------------------------

                // não utilizaremos mais o get/set dessa maneira

                //Conta.SetSaldo(-10); 

                // Console.WriteLine(Conta.GetSaldo());

                //Conta.SetSaldo(10);

                // Console.WriteLine(Conta.GetSaldo());

                //---------------------------------------------------------------

                Conta.Saldo = -10;

                Console.WriteLine(Conta.Saldo);

                Console.ReadLine ();

            }

            if (questao == 3)
            {
                char resposta;
                string nome;

                ContaCorrente ContaPedro = new ContaCorrente();

                ContaPedro.Agencia = 123;
                ContaPedro.Numero = 456;
                ContaPedro.Titular = new Cliente();
                ContaPedro.Titular.Nome = "pedro Da Silva";
                ContaPedro.Titular.CPF = "123.456.789-01";
                ContaPedro.Titular.Profissao = "engenheiro";

                ContaCorrente ContaMarina = new ContaCorrente();

                ContaMarina.Agencia = 456;
                ContaMarina.Numero = 789;
                ContaMarina.Titular = new Cliente();
                ContaMarina.Titular.Nome = "marina Oliveira";
                ContaMarina.Titular.CPF = "789.456.123-20";
                ContaMarina.Titular.Profissao = "medica";

                Console.WriteLine("nome anterior" + ContaMarina.Titular.Nome);
                Console.WriteLine(ContaMarina.Titular.CPF);

                Console.WriteLine("Deseja mudar o nome? (s/n) ");
                //Console.ReadLine(resposta);

                //if (resposta == 's')
                //{
                //   Console.WriteLine("Digite o novo nome: ");

                //    //Console.ReadLine(ContaMarina.titular.nome);
                //}
                //Console.WriteLine(ContaMarina.Titular.Nome);


            }
        }
    }
}