using System;

namespace impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

         while (a <= 100)
            {

             if (a % 2 != 0)
                {
               Console.WriteLine("\n {0}", a);   
                }

                 a++; 
            }
        }
    }
}

//for (int i= 1; i <= 100; i+2){
//    Console.WriteLine(i + " ");
//}