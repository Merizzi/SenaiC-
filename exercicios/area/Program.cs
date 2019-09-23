using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, fn;
            double cl, a, b, c , l, h;
            Console.WriteLine("Caculando areas!");
            do{
            Console.WriteLine("Escolha qual das figuras você deseja calcular: \n1-Quadrado \n2-Triângulo \n3-Círculo \n4-Trapézio \n5-Retângulo \n6-Losango");
            s = int.Parse(Console.ReadLine());

            switch(s){
                case 1: Console.WriteLine("\nVocê escolheu Quadrado");
                Console.WriteLine("\nDigite um lado do quadrado: ");
                l = double.Parse(Console.ReadLine());
                a =  l*4;
                    Console.WriteLine("O valor da area do seu quadrado é: {0}", a);
                break;

                case 2: Console.WriteLine("\nVocê escolheu Triângulo");
                Console.WriteLine("\nDigite a base do triângulo: ");
                l = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite a altura do triângulo: ");
                c = double.Parse(Console.ReadLine());
                a =  (l*c)/2;
                    Console.WriteLine("O valor da area do seu triângulo é: {0}", a);
                break;

                case 3: Console.WriteLine("\nVocê escolheu Círculo");
                Console.WriteLine("\nDigite o raio do seu círculo: ");
                b = double.Parse(Console.ReadLine());
                cl = (b*b) *3.14; 
                Console.WriteLine("O valor da area do seu circulo é: {0}", cl);
                break;

                case 4: Console.WriteLine("\nVocê escolheu Trapézio");
                Console.WriteLine("\nDigite a base maior do trapézio: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite a base menor do trapézio: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite a altura do trapézio: ");
                h = double.Parse(Console.ReadLine());
                cl = ((b+a)*h)/2; 
                Console.WriteLine("O valor da area do seu trapézio é: {0}", cl);
                break;

                case 5: Console.WriteLine("\nVocê escolheu Retângulo");
                Console.WriteLine("\nDigite a base do retângulo: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite a altura do retângulo: ");
                a = double.Parse(Console.ReadLine());
                cl = b*a; 
                Console.WriteLine("O valor da area do seu retângulo é: {0}", cl);
                break;

                case 6: Console.WriteLine("\nVocê escolheu Losango");
                Console.WriteLine("\nDigite a diagonal Maior do seu Losango: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite a diagonal Menor do seu Losango: ");
                a = double.Parse(Console.ReadLine());
                cl = (b*a)/2; 
                Console.WriteLine("O valor da area do seu Losango é: {0}", cl);
                break;
            }
            Console.WriteLine("Aperte 1 para calcular novamente ou 2 Para sair");
			fn = int.Parse(Console.ReadLine()); 
         
          }while(fn==1);

        }
    }
}
