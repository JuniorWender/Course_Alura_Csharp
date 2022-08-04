using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool sacar(double valor)
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

}
