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
            //System.Console.Write("Titular: ");
            //string titular = Console.ReadLine();

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

            ContaCorrente contaCorrente = new ContaCorrente (cliente1, Conta, agencia);
            contaCorrente.Deposito(saldo);
            contaCorrente.Agenda = 123;

            bool valorValido = false;
            double valor;

            do {
            System.Console.WriteLine("ByteBank Deposito");
            Cliente usuario = contaCorrente.Titular;
            System.Console.WriteLine("Bem Vindo - {0}", usuario.Nome);
            System.Console.WriteLine("Agencia: {0} , Conta: {1}", contaCorrente.Agenda, contaCorrente.Numero);
            System.Console.WriteLine("Saldo: {0}", contaCorrente.Saldo);
            System.Console.Write("Digite o valor do Deposito:");
             valor = double.Parse(Console.ReadLine());
            contaCorrente.Deposito(valor);
            System.Console.WriteLine();
            if(valor >= 0){
                valorValido = true;
            }
            else{
                valorValido = false;
            }
            }while(!valorValido);
            System.Console.WriteLine("ByteBank - Saque");
            Console.Write("Qual o valor do Saque? ");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Saque(valor)){
                System.Console.WriteLine("Saque Realizado com sucesso. Retire suas notas");
            }
            else{
                System.Console.WriteLine("Não foi possivel realizar o saque");
            }
            System.Console.WriteLine();

            
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.Write("Digite o valor da transferência: ");
            valor = double.Parse(Console.ReadLine());
            Cliente cliente2 = new Cliente("Alexandre", "123.321.123-12", "a@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(cliente2,123, 123 );
            if(contaCorrente.Transferencia(contaCorrente2,valor))
            {
                System.Console.WriteLine("Transferencia efetuada com sucesso");
            }
            else{
                System.Console.WriteLine("Transferencia não foi efetuada");
            }
        }
    }
}