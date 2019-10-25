using System;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Multiplos de 3!");

            System.Console.WriteLine("Digite um Número: ");
            x = int.Parse(Console.ReadLine());

            if(x%3==0)
            {
                System.Console.WriteLine("O seu número é multiplo de 3, o seu número é: {0}",x);
            }
            else{
                System.Console.WriteLine("O seu número NÃO é multiplo de 3, o seu número é: {0}",x);
            }
        }
    }
}
