using System;

namespace planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg, fimkg;
            int esc;

            Console.WriteLine("Calculando Peso!");

            System.Console.WriteLine("Digite o seu Peso na terra: ");
            kg = Double.Parse(Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine("Escolha uma das opções para verificar seu peço no planeta que deseja...");
            
            Console.WriteLine("Digite 1 para Mercúrio");
            Console.WriteLine("Digite 2 para Vênus");
            Console.WriteLine("Digite 3 para Marte");
            Console.WriteLine("Digite 4 para Júpiter");
            Console.WriteLine("Digite 5 para Saturno");
            Console.WriteLine("Digite 6 para Urano");

            Console.Write("\nDigite sua Opção: ");
            esc = int.Parse(Console.ReadLine());

            switch(esc)
            {
                case 1: fimkg = (kg* 0.37)+0.4;
                System.Console.WriteLine("O seu Peso no Planeta Mercúrio será: {0}",fimkg);
                break;

                case 2:fimkg = kg* 0.88;
                System.Console.WriteLine("O seu Peso no Planeta Vênus será: {0}",fimkg);
                break;

                case 3:fimkg = kg* 0.38;
                System.Console.WriteLine("O seu Peso no Planeta Marte será: {0}",fimkg);
                break;

                case 4:fimkg = kg* 2.64;
                System.Console.WriteLine("O seu Peso no Planeta Júpiter será: {0}",fimkg);
                break;

                case 5:fimkg = kg* 1.15;
                System.Console.WriteLine("O seu Peso no Planeta Saturno será: {0}",fimkg);
                break;

                case 6:fimkg = kg* 1.17;
                System.Console.WriteLine("O seu Peso no Planeta Urano será: {0}",fimkg);
                break;

            }

        }
    }
}
