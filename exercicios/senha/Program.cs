using System;
using senha.Models;
namespace senha {
    class Program {
        static void Main (string[] args) {

            System.Console.WriteLine ("Cadastro de Clientes");
            System.Console.WriteLine ();
            System.Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("Email: ");
            string email = Console.ReadLine ();
            Cliente cliente1 = new Cliente (nome, cpf, email);
            
            bool senhaOk = false;
            do {
                System.Console.Write ("Digite a Senha: ");
                string senha = Console.ReadLine ();
                senhaOk = cliente1.TrocaSenha (senha);
                if (!senhaOk) {
                    System.Console.WriteLine ("Senha não atende aos requisitos !");
                } else {
                    System.Console.WriteLine ("Senha trocada com sucesso !");
                }
            } while (!senhaOk);

            System.Console.WriteLine("Cadastro da Conta Corrente");
            System.Console.Write("Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Conta: ");
            int Conta = int.Parse(Console.ReadLine());
            System.Console.Write("Titular: ");
            string titular = Console.ReadLine();

            bool saldoValido = false;
            double saldo;
            do{
                System.Console.WriteLine("Digite o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if(saldo > 0){
                    saldoValido = true;
                    System.Console.WriteLine("");
                }
                else{
                    System.Console.WriteLine("O saldo não pode ser negativo");
                }
            }while(!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (titular, Conta, agencia);
            contaCorrente.Saldo = saldo;
        }
    }
}