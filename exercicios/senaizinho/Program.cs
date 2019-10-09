using System;
using senaizinho.Models;
namespace senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Senaizinho!");
            System.Console.WriteLine("Escolha uma das opções abaixo: ");
            System.Console.WriteLine("1- Cadastrar Aluno \n2- Cadastrar Sala \n3- Alocar Aluno \n4- Remover Aluno \n5- Verificar Salas \n6- Verificar Alunos \n7- Sair");
            x = int.Parse(Console.ReadLine());
            
            switch(x){
                case 1:
                    System.Console.WriteLine("Digite o Nome do Aluno: ");
                    string nome = Console.ReadLine();
                    System.Console.WriteLine("Digite o Curso do Aluno: ");
                    string curso = Console.ReadLine();
                    System.Console.WriteLine("Digite a Data de Nascimento do Aluno: ");
                    DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                    Aluno aluno = new Aluno (nome, curso,  dataNascimento);
                 break;

                 case 2:
                    
                 break;

                 case 3:
                    
                 break;
                 
                 case 4:
                    
                 break;

                 case 5:
                    
                 break;

                 case 6:
                    
                 break;

                 case 7:

                 break;
            }
        }
    }
}
