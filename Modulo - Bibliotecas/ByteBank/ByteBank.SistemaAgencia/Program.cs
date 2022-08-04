using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;
using ByteBank.SistemaAgencia.Extensoes;


namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            int program = 10;

            if (program == 0)
            {
                //ContaCorrente conta = new ContaCorrente(847, 489754);
                //Funcionario funcionario = null;
                //Console.WriteLine(conta.Numero);

                DateTime dataFimPagamento = new DateTime(2022, 8, 17);
                DateTime dataHoje = DateTime.Now;

                TimeSpan diferenca = dataFimPagamento - dataHoje;

                string mensagem = "Faltam " + TimeSpanHumanizeExtensions.Humanize(diferenca) + " até o fim do prazo.";

                Console.WriteLine("A data para terminar de pagar é: " + dataFimPagamento);
                Console.WriteLine("A data atual é: " + dataHoje);
                Console.WriteLine(mensagem);

                Console.ReadLine();
            }

            if (program == 1)
            {
                string urlParametros = "hhtp://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
                ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

                string valor = extrator.GetValor("moedaDestino");
                Console.WriteLine("valor de moedaDestino: " + valor);

                string ValorMoedaOrigem = extrator.GetValor("moedaOrigem");
                Console.WriteLine("valor da moedaOrigem: " + ValorMoedaOrigem);

                Console.WriteLine(extrator.GetValor("VALOR"));
                Console.ReadLine();

            }

            if( program == 2)
            {
                string urlTeste = "https://www.bytebank.com/cambio";
              
                Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
                Console.WriteLine(urlTeste.EndsWith("cambio"));
                Console.WriteLine(urlTeste.Contains("bytebank"));


                Console.ReadLine();
            }

            if(program == 3)
            {
                // Verificar um numero de telefone:
                // Olá, meu nome é guilherme , me ligue em 4784-4546

                // string padrao = "[0-9] [0-9] [0-9] [0-9] [-] [0-9] [0-9] [0-9] [0-9]";
                // string padrao = "[0-9]{4} [-] [0-9]{4}";
                // string padrao = "[0-9]{4,5} [-] [0-9]{4}";
                // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
                // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
                string padrao = "[0-9]{4,5}-?[0-9]{4}";

                string textoTeste = "Olá, meu nome é guilherme , me ligue em 25871234";
                Match resultado = Regex.Match(textoTeste, padrao);

                Console.WriteLine(resultado.Value);
                Console.ReadLine();

            }
        
            if(program == 4)
            {
                ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4567897),
                    new ContaCorrente(874, 1234567)
                 };

                for(int i = 0; i <contas.Length; i++)
                {
                    ContaCorrente contaAtual = contas[i];
                    Console.WriteLine($"conta {i} {contaAtual.Numero}");
                    //Console.WriteLine($"conta {i} {contas[i].Numero}");
                }
            }

            if(program == 5)
            {
                ListaDeContaCorrente lista = new ListaDeContaCorrente();
                           
                //for ( int i = 0; i < lista.Tamanho; i++)
                //{
                //    ContaCorrente itemAtual = lista.GetItemNoIndice(i);
                //    Console.WriteLine($"item na posição {i} = conta {itemAtual.Numero}/{itemAtual.Agencia}");
                //}

               lista.AdicionarVarios(new ContaCorrente(874, 1234569), new ContaCorrente(874, 9876543), new ContaCorrente(874, 8259634));

                for (int i = 0; i < lista.Tamanho; i++)
                {
                    ContaCorrente itemAtual = lista[i];
                    Console.WriteLine($"item na posição {i} = conta {itemAtual.Numero}/{itemAtual.Agencia}");
                }

                Console.ReadLine();
            }

            if(program == 6)
            {
                ListaDeObject listaDeIdades = new ListaDeObject();

                listaDeIdades.Adicionar(10);
                listaDeIdades.Adicionar(1);
                listaDeIdades.Adicionar(9);
                listaDeIdades.AdicionarVarios(10,25,30,60,70,80,90);

                for(int i = 0; i < listaDeIdades.Tamanho;i++)
                {
                    int idade = (int)listaDeIdades[i];
                    Console.WriteLine($"Idade no indice {i}: {idade}");
                }

                Console.ReadLine();
            }

            if(program == 7)
            {
                Lista<int> idades = new Lista<int>();

                idades.Adicionar(12);
                idades.AdicionarVarios(27, 67, 94, 32, 01, 44, 88, 77, 99, 55);

                List <int> idade = new List<int>();
                idade.Add(11);
                idade.Add(5);
                idade.Add(4);
                idade.Add(25);

                idade.Remove(4);

                idade.AdicionarVarios(27, 67, 94, 32, 10, 44, 88, 77, 99, 5555);

                for (int i =0; i< idade.Count; i++)
                {
                    Console.WriteLine(idade[i]);
                }
                Console.ReadLine();

            }

            if(program == 8)
            {
                List<int> idade = new List<int>();
                idade.Add(11);
                idade.Add(5);
                idade.Add(4);
                idade.Add(25);

                idade.Remove(4);

                idade.AdicionarVarios(9999,2457,321,024,88,94,27, 67, 94, 32, 10, 44, 88, 77, 99, 5555);

                idade.Sort();

                for (int i = 0; i < idade.Count; i++)
                {
                    Console.WriteLine(idade[i]);
                }
                Console.ReadLine();

            }

            if(program == 9)
            {
                var contas = new List<ContaCorrente>
                {
                    new ContaCorrente(341,57480),
                    new ContaCorrente(338,57000),
                    new ContaCorrente(320,49000),
                    null,
                    new ContaCorrente(150,32804),
                    null,
                    null,
                    new ContaCorrente(290,85231),
                    new ContaCorrente(666,25874)
                };

                // contas.Sort(); ~~~> Chama a iplementação dada em IComparable

                // contas.Sort(new ComparadorContaCorrentePorAgencia());

                // IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => { 
                //    if(conta == null)
                //    {
                //        return int.MaxValue;
                //    }
                //    return conta.Numero; 
                // });

                //var contasNaoNulas = contas.Where(conta => conta != null);

                //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

                var contasOrdenadas = contas.Where(conta => contas != null).OrderBy(conta => conta.Numero);

                foreach (var conta in contasOrdenadas)
                {
                   // if (conta != null)
                   // {
                        Console.WriteLine($"conta Número {conta.Numero}, ag. {conta.Agencia}");
                   // }
                }

                Console.ReadLine();
            }

            if(program == 10)
            {

                var enderecoArquivo = "contas.txt";

                Console.ReadLine();
            }
        }
    }
}
