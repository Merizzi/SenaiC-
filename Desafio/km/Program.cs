using System;

namespace km
{
    class Program
    {
        static void Main(string[] args)
        {
            double t, v, d, l;
            Console.WriteLine("Calculando os litros gastos");

             System.Console.WriteLine("Digite o tempo gasto na viagem: ");
             t = Double.Parse(Console.ReadLine());

             System.Console.WriteLine("Digite a velocidade média: ");
             v = Double.Parse(Console.ReadLine());

             d = t * v;
             d = d/60;
             l = d/12;

            System.Console.WriteLine("Os litros de combustiveis gastos foram: {0}l", l);
        }
    }
}
