using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_ByteBank
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo o Arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo Lnha . . .");

           throw new IOException(); // exceção de imput/output logo, entrada e saída

        }

        public void Dispose()
        {
            Console.WriteLine("fechando arquivo.");
        }

    }
}
