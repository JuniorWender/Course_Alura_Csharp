using ByteBanco.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBanco.Sistemas
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("senha incorreta!");
                return false;
            }
        }

    }
}
