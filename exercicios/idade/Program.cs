using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, mes, dia;
            double hora, minuto;
            Console.WriteLine("Idade");
            Console.WriteLine("\nDigite quantos anos você possui:");
            idade = int.Parse(Console.ReadLine());
            mes = idade * 12;
            Console.WriteLine("\nA sua idade em meses é: {0}", mes);
            dia = idade * 365;
            Console.WriteLine("\nA sua idade em dia é: {0}", dia);
            hora = dia * 24;
            Console.WriteLine("\nA sua idade em horas é: {0}", hora);  
            minuto = hora * 60;
            Console.WriteLine("\nA sua idade em minutos é: {0}", minuto);
            Console.ReadKey();
        }
    }
}
