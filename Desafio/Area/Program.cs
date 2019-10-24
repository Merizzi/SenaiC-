using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, total;
            Console.WriteLine("Valores do seu Retângulo");
            System.Console.WriteLine("Digite a base do seu retângulo:");
            a = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a altura do seu retângulo:");
            b = float.Parse(Console.ReadLine());

            total = a + a + b + b;
            System.Console.WriteLine("O perimetro do seu retangulo é: {0}",total);

            total = a * b;
            System.Console.WriteLine("A area do seu retangulo é: {0}", total);

            total = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
            System.Console.WriteLine("A diagonal do seu retangulo é: {0}",total);
        }
    }
}
