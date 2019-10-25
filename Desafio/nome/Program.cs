using System;
using System.Collections.Generic;

namespace nome
{
    class Program
    {
        static void Main(string[] args)
        {
            /* String [] nome = new String[2];
            System.Console.WriteLine("Digite o primeiro nome: ");
            nome[0] = Console.ReadLine();
            System.Console.WriteLine("Digite o segundo nome: ");
            nome[1] = Console.ReadLine();
            */

            string nome1,nome2;
            Console.WriteLine("Ordenando os Nomes!");
            System.Console.WriteLine("Digite o primeiro nome: ");
            nome1 = Console.ReadLine();
            System.Console.WriteLine("Digite o segundo nome: ");
            nome2 = Console.ReadLine();
            
            List<string> lista = new List<string>();
            lista.Add(nome1);
            lista.Add(nome2);

            lista.Sort();

            foreach(string item in lista)
            {
                System.Console.WriteLine("\n{0}",item);
            }

        }
    }
}
