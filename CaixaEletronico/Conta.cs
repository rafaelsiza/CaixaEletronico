using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {

        public int numero;

        public string titular;

        public double saldo;


        public void Saca(double valor) {

            this.saldo -= valor;

        }

        public void Deposita(double valor)
        {

            this.saldo += valor;

        }


    }
}
