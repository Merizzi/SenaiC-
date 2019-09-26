using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {

           double [] temperaturas = new double [12];
           double maior = 0, menor = 0;

           for(int i = 0; i < 12; i++)
           {
               Console.WriteLine("Digite a temparatura do mês: ");
               temperaturas[i] = double.Parse(Console.ReadLine());
           }

           maior = temperaturas[0];
           menor = temperaturas[0];

           foreach(double temp in temperaturas)
           {
               if(temp > maior)
               {
                   maior  = temp;
               }
               else if (temp < menor){
                   menor = temp;
               }
           }

            Console.WriteLine("A temperatura maior é: {0}", maior);
            Console.WriteLine("A temperatura menor é: {0}", menor);
        }
    }
}
