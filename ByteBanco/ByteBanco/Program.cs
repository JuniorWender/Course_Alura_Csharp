using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBanco.Funcionarios;

namespace ByteBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
                GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

                Funcionario carlos = new Funcionario(1000, "123.456.789-12");

                carlos.Nome = "carlos";

                gerenciador.Registrar(carlos);

                Diretor Roberta = new Diretor("123.654.987-22");

                Roberta.Nome = "roberta";

                gerenciador.Registrar(Roberta);

                Funcionario cirlene = Roberta;


                Console.WriteLine("Salario do carlos é de: " + carlos.Salario + " e a bonificação do funcionario " + carlos.Nome + " é de: R$" + carlos.GetBonificacao() + ",00");
                carlos.AumentarSalario();
                Console.WriteLine("Novo Salário do carlos é: " + carlos.Salario);
                Console.WriteLine("Salario Da Roberta é de: " + Roberta.Salario + "A bonificação da diretora " + Roberta.Nome + " é de: R$" + Roberta.GetBonificacao() + ",00");
                Roberta.AumentarSalario();
                Console.WriteLine("Novo Salário da Roberta é: " + Roberta.Salario);
                Console.WriteLine("A bonificação da diretora cirlene é de:" + cirlene.GetBonificacao() + ",00");
                Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
                Console.ReadLine();
        } 
    }
}
