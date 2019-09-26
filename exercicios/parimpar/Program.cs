using System;

namespace parimpar
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] vetor = new int [6];
            int pares =0, impares = 0;

            for(int cont= 0; cont <= 5; cont++){
            Console.WriteLine("Digite um número: ");
            vetor[cont] = int.Parse(Console.ReadLine());
            }
        
        foreach(int num in vetor)
        {
            if( num%2 ==0)
            {
                //pares = pares + 1;
                //pares++;
                pares += 1;
            }
            else{
                impares++;
            }
        }
        /* int num;
            for(int cont = 0; cont <=5 ; cont++){
                num = vetor [cont];
                if(num% 2== 0){
                    pares ++;
                }
                else{
                    impares++;
                }
            }
         */

        Console.WriteLine("Você tem {0} números pares e {1} números impares", pares,impares);

        }
    }
}
