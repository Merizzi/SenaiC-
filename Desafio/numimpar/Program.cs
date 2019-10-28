using System;

namespace numimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Número impares antes do escolhido!");
            System.Console.WriteLine("Escolha um número: ");
            x = int.Parse(Console.ReadLine());

            for(y = 1; y < x ; y+=2){
                System.Console.Write("\t{0}", y);
            }
        }
    }
}
