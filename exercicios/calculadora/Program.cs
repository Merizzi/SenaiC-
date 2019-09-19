using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            int opcao;
            double n1, n2;
            Console.WriteLine("\nDigite o Primeiro Valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o Segundo Valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 para Adição");
            Console.WriteLine("Digite 2 para Subtração");
            Console.WriteLine("Digite 3 para Multiplicação");
            Console.WriteLine("Digite 4 para Divisão");

            Console.Write("\nDigite sua Opção: ");
            opcao = int.Parse(Console.ReadLine());

          
            switch(opcao)
            {
                
                case 1: Console.WriteLine("\nVocê escolheu Adição");
                c = n1 + n2;
                    Console.WriteLine("O valor da sua operação foi: {0}", c);
                break;

                case 2: Console.WriteLine("\nVocê escolheu Subtração");
                c = n1 - n2;
                    Console.WriteLine("O valor da sua operação foi: {0}", c);
                break;

                case 3: Console.WriteLine("\nVocê escolheu Multiplicação");
                c = n1 * n2;
                    Console.WriteLine("O valor da sua operação foi: {0}", c);
                break;

                case 4: Console.WriteLine("\nVocê escolheu Divisão");
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                //Console.WriteLine(c);
                c = n1 / n2;
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(c);
                    Console.WriteLine("O valor da sua operação foi: {0}", c);
                break;
            }
        }
    }
}
