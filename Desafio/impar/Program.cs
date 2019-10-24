using System;

namespace impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrando numeros ímpares de 0 a 10");

            for(int x = 1; x <= 10; x+=2){
                System.Console.WriteLine("{0}",x);
            }
        }
    }
}
