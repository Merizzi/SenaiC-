using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
           int iconpar = 0, isoma=0, iconipar= 0, isomai=0;
            int [] number;
            number = new int[6]; 
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            number[3] = 4;
            number[4] = 5;
            number[5] = 6;

             for(int i = 0; i < 6; i++)
            {
                if((number[i]%2)==0){
                    iconpar++;
                    isoma += number[i];
                    
                     Console.WriteLine(number[i].ToString());
                }
                if((number[i]%2)==1){
                    iconipar++;
                    isomai += number[i];
                     Console.WriteLine(number[i].ToString());
                }
                
            }
           
           
            Console.WriteLine("A soma dos numeros pares é: {0}",isoma); 
            Console.WriteLine("A quantidade de Numeros pares é: {0}",iconpar);
            
            
            
            Console.WriteLine("\nA soma dos numeros ímpares e: {0}",isomai); 
            Console.WriteLine("A quantidade de numeros ímpares e: {0}",iconipar);
        }
    }
}
