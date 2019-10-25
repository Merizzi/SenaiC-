using System;

namespace graus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando a temperatura!");

            double f,c;
            System.Console.WriteLine("Digite a sua temperatura em Graus: ");
            c = Double.Parse(Console.ReadLine());

            f = ((c * 1.8) + 32);

            System.Console.WriteLine("A sua temperatura em Fahrenheit é: {0}", f);
            System.Console.WriteLine("A sua temperatura em Centígradus é: {0}", c);
        }
    }
}
