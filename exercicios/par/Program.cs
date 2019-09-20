using System;

namespace par
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            int fn;
            do{
            Console.WriteLine("Numeros ìmpares e pares");
            Console.WriteLine("\nDigite um número: ");
            n = double.Parse(Console.ReadLine());

            if( n % 2 ==0)
            {
                Console.WriteLine("O seu número é par");
                Console.WriteLine("\nO seu número é: {0}", n);
            }
            else{
                Console.WriteLine("O seu número é ímpar");
                Console.WriteLine("\nO seu número é: {0}", n);
            }
             Console.WriteLine("Aperte 1 para jogar novamente ou 2 Para sair");
			 fn = int.Parse(Console.ReadLine()); 		
			}while(fn==1);
            
        }
    }
}
