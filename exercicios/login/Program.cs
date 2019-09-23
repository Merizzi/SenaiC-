using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string log, senha;
            Console.WriteLine("Login");
            Console.Write("\nDigite seu Usuario: ");
            log = Console.ReadLine();
            Console.Write("Digite a sua Senha: ");
            senha = Console.ReadLine();

            if(log=="admin" && senha=="admin"){
                Console.WriteLine("Você é um Administrador, Seja Bem Vindo ao nosso sistema!");
            }
            else{
                Console.WriteLine("Você é um Usuário, Seja Bem Vindo {0} ao nosso Aplicativo!", log);
            }
        }
    }
}
