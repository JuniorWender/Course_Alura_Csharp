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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {

                var contaComoString = "456,78945,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString); // converte o texto "contaComoString" para bytes

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,65465,456.0,Pedro");

            }
        }
            static void TestaEscrita()
            {
                var caminhoArquivo = "teste.txt";

                using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
                using(var escritor = new StreamWriter(fluxoDeArquivo))
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        escritor.WriteLine($"Linha {i}");

                        Console.WriteLine($"Linha {i} foi escrita no arquivo. tecle enter para adicionar mais um");
                        Console.ReadLine();
                    }
                }
            }
        
    }
}
