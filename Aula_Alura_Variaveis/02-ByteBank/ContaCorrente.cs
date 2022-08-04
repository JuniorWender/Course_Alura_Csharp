using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using _02_ByteBank; ESTÁ NO MESMO NAMESPACE POR ISSO NÃO É NECESSARIO DAR O USING


namespace _02_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {

            if (this.saldo < valor) //Se o saldo em conta for menor que o valor que quer sacar ele retorna falso
            {

                return false;

            }
            else // se o saldo em conta for maior do que o valor que quer sacar, ele retorna true e desconta o valor.
            {
                this.saldo -= valor;
                return true;

            }

        }

        public void Depositar(double valor)
        {

            this.saldo += valor;

        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {

            if (this.saldo < valor)
            {

                return false;

            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;


        }

    }
}