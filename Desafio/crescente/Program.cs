using System;
using System.Collections.Generic;

namespace crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Crescentes!");
            int num1, num2, num3;
            Console.WriteLine("Ordenando os Nomes!");
            System.Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            num3 = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();
            lista.Add(num1);
            lista.Add(num2);
            lista.Add(num3);

            lista.Sort();

            foreach(int item in lista)
            {
                System.Console.WriteLine("\n{0}",item);
            }
        }
    }
}
