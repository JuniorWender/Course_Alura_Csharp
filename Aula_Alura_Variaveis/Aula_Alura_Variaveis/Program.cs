using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Alura_05
{
    class program
    {
        static void Main(string[] args)
        {
            int questao = 5;

            if (questao == 0)
            {
                // declarar variaveis inteiras
                Console.WriteLine("Projeto 2 - Criar Variaveis");

                int idade = 32;
                Console.WriteLine("Tecle enter: " + idade + " idade");
                Console.ReadLine();
            }

            if (questao == 1) { 
                //Codigo Para Variaveis de ponto flutuante
                double salario = 1200.70;

                Console.WriteLine("Salario é de: R$" + salario);
                Console.ReadLine();
            }

            if (questao == 2)
            {
                // codigo conversão de numeros
                double salario = 1200.50;
                int salarioInteiro;
                salarioInteiro = (int)salario; // converte um numero double para inteiro para ser recebido pela variavel
                Console.WriteLine(salarioInteiro);

                // a variavel int tem um limite de digitos (1000000000[32bits]) para numeros maiores que isso deve
                // utilizar variaveis "long"

                long Tempo = 1000000000000000000;
                int tempo = 1000000000;
                // variaveis short são para numeros de 16bits

                float altura = 1.80f; //necessario colocar (f) pq o c# entende numeros reais como double por ser mais preciso
            }

            if (questao == 3)
            {
                //caracteres
                char letra = 'a'; // declara um caracter para a variavel char
                letra = (char)65; // converte pela tabela ASCII
                Console.WriteLine (letra);
                string texto = "texto com aspas";
                string texto_corte = "alo\n" + "teste";
                Console.WriteLine (texto_corte);

            }

            if (questao == 4)
            {
                //variaveis booleans

                // bool ...
                // && - e
                // || - ou

            }

            if (questao == 5)
            {
                // Programação orientada objeto
                // ByteBank
                                
                ContaCorrente contaDaGabriela = new ContaCorrente(); // declara uma variavel "conta da gabriela" que está
                //apontando para ContaCorrente.

                contaDaGabriela.titular = "Gabriela"; // Acessa "titular" em "contaDaGabriela" que está apontando para "ContaCorrente"
                contaDaGabriela.agencia = 863;
                contaDaGabriela.numero = 863452;
                contaDaGabriela.saldo = 100;

                Console.WriteLine(contaDaGabriela.titular);
                Console.WriteLine("agencia: " + contaDaGabriela.agencia);
                Console.WriteLine("numero: " + contaDaGabriela.numero);
                Console.WriteLine("saldo: " + contaDaGabriela.saldo);

                contaDaGabriela.saldo += 200; // atribui e soma 200
                Console.WriteLine("Novo saldo: " + contaDaGabriela.saldo);

            }
        }
    }
}
