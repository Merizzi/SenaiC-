using System;

namespace forma
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;
            Console.WriteLine("Analisando triangulos!");   
            System.Console.WriteLine("Digite o valor do Primeiro Lado: ");
            l1 = Double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor do Segundo Lado: ");
            l2 = Double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor do Terceiro Lado: ");
            l3 = Double.Parse(Console.ReadLine());

            if(l1 < (l2 + l3) && l1 > (l2-l3) && l2 < (l1+l3) && l2 > (l1 - l3) && l3 < (l2 + l1) && l3 > ( l1 - l2)){
                System.Console.WriteLine("Esses valores permitem ser um triangulo");
            }
            else{
                System.Console.WriteLine("Esses valores não permitem ser um triangulo");
            }
        }
    }
}
