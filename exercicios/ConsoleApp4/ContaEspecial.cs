using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class ContaEspecial : ContaBancaria
    {
        public double limite;
        public ContaEspecial(int Agencia, int Numero, string Titular):base (Agencia, Numero, Titular)
        {
            limite = 0.0;
        }

        public override bool Saque(double valor)
        {
            if(valor >= 0)
            {
                if(valor <= base.Saldo + limite)
                {
                    Saldo -= valor;
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
