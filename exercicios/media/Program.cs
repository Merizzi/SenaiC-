using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, nota2, nota3, nota4, media;
            Console.WriteLine("Calculando a Média dos alunos!");

            Console.WriteLine("\nColoque a primeira nota do aluno:");
            nota = double.Parse(Console.ReadLine());
            Console.WriteLine("\nColoque a segunda nota do aluno:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nColoque a terceira nota do aluno:");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nColoque a quarta nota do aluno:");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota + nota2 + nota3 + nota4) / 4;
            if (media >=7){
                Console.WriteLine("\nParabéns aluno aprovado com a média de: {0}", media);
            }
            else{
                Console.WriteLine("\nAluno reprovado com a média de: {0}", media);
            }
        }
    }
}
