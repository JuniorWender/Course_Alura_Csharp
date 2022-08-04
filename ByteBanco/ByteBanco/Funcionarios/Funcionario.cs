using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBanco.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario,string cpf)
        {

            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
            
        }

        public abstract void AumentarSalario();
        //Salario = Salario + (Salario * 0.1);
        //Salario = Salario * 1.1; faz a mesma coisa do acima
        //Salario *= 1.1; //faz a mesma coisa do acima

        public abstract double GetBonificacao();
            // return Salario * 0.10;
        
    }
}
