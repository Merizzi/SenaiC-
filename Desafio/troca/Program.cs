using System;

namespace troca
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Trocando o valor das variaveis!");

            System.Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            c = b;
            b = a;
            a = c;

            System.Console.WriteLine("O valor de A agora é: {0}",a);
            System.Console.WriteLine("O valor de B agora é: {0}",b);
        }
    }
}
