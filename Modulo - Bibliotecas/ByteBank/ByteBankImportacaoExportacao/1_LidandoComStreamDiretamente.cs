using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; //input e output

namespace ByteBankImportacaoExportacao
{
    partial class program
    {
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt"; // Declara o nome do arquivo que deve ser aberto.(se encontra na pasta debug)
            // var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);//Abre o nosso arquivo

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];  // 1 kb
                var numeroDeBytesLidos = -1; // .Read só retorna 0 quando chega ao fim da leitura ou 1 qnd tem mais pra ler,por isso foi inicialziado com -1

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); // vai ler o nosso arquivo do byte 0 até o 1024
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.UTF8;

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
        }
    }
}