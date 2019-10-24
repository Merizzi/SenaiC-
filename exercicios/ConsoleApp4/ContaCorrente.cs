using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ContaCorrente : ContaBancaria
    {
        public ContaCorrente (int Agencia, int Numero, string Titular): base(Agencia, Numero, Titular)
        {

        }

        public override bool Saque(double valor)
        {
            if(valor >= 0)
            {
                if (valor <= this.Saldo)
                {
                    this.Saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
