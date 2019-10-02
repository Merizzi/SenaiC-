using System;
using senha.Models;
namespace senha {
    class Program {
        static void Main (string[] args) {

            Cliente c = new Cliente();

            Console.WriteLine ("Byte Bank");

            Console.Write ("Digite o seu Nome: ");
            string nome =Console.ReadLine();

            Console.Write ("Digite o seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write ("Digite o seu Email: ");
            string email = Console.ReadLine();

            Console.WriteLine ("Digite a sua Senha(Ela deverá ter no minimo 6 caracteres e no maximo 16 caracteres): ");
            c.Senha = Console.ReadLine();

           /*  if(c.Senha<6 && c.Senha > 16 ){
                System.Console.WriteLine("Senha incorreta, digite novamente");
                Console.WriteLine ("Digite a sua Senha(Ela deverá ter no minimo 6 caracteres e no maximo 16 caracteres): ");
                c.Senha = Console.ReadLine();
             }*/
            System.Console.WriteLine("{0}, {1}, {2}, {3}", c.Nome, c.Cpf, c.Email, c.Senha);

        }
    }
}