using ByteBanco.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBanco.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000,cpf) { }

        public override double GetBonificacao() // ao utilizar override ele diz que essa função não está sendo chamada novamente
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}