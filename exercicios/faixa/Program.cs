using System;

namespace faixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, x;
            Console.WriteLine("Faixa etaria");

            Console.WriteLine("Digite o ano do seu nascimento: ");
            ano = int.Parse(Console.ReadLine());

            x = 2019 - ano ;
            if( x <= 2){
                Console.WriteLine("A pessoa é uma Recém-nascida com a idade de: {0} anos ", x);
            }
            if( x >= 3 && x <= 11){
                Console.WriteLine("A pessoa é uma criança com a idade de: {0} anos ", x);
            }
            if( x >= 12 && x <= 19){
                Console.WriteLine("A pessoa é um adolescente com a idade de: {0} anos ", x);
            }
            if( x >= 20 && x <= 65){
                Console.WriteLine("A pessoa é um adulto com a idade de: {0} anos ", x);
            }
            if( x > 65){
                Console.WriteLine("A pessoa é um idoso com a idade de: {0} anos ", x);
            }
        }
    }
}
