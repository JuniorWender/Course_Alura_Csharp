using ByteBankImportacaoExportacao;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.IO; //input e output
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CriarArquivoComWriter();
            Console.WriteLine("aplicação finalizada...");
           
            Console.ReadLine();
        }

    }
}