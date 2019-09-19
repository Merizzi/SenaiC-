using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novo, total;
            Console.WriteLine("Calculo dos Salarios da Empresa!");
            Console.WriteLine("Vamos ver se você tem direito a um aumento...");
            Console.WriteLine("Digite o valor do seu salario: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500)
            {
                novo = (salario * 30)/100;
                total= novo + salario;
                Console.WriteLine("Você tem direito ao aumento de salario!! ");
                Console.WriteLine("Você teve um aumento de 30% no seu salário: R${0} ", novo);
                Console.WriteLine("O seu novo salário é: {0} ", total);

            }
            else{
                Console.WriteLine("Que pena, infelizmente você não tem direito ao aumento de salario! ");
            }
        }
    }
}
