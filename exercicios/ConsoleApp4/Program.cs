using System;
using Bytebank2;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente1 = "Alexandre";
            string cliente2 = "Cesar";

            ContaCorrente contaCorrente = new ContaCorrente(1,1, cliente1);
            ContaEspecial contaEspecial = new ContaEspecial(1, 2, cliente2);
            ContaCorrente.Deposito(10);
        }
    }
}
