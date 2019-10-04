using System;
namespace senha.Models {
    public class ContaCorrente {
        public Cliente Titular { get; set; }
        public int Agenda { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (Cliente Titular, int Agenda, int Numero) {
            this.Titular = Titular;
            this.Agenda = Agenda;
            this.Numero = Numero;
            this.Saldo = 0.0;
        }

        public double Deposito(double valor){
            this.Saldo += valor;
            return this.Saldo;
        }
        public bool Saque (double valor){
            if(valor < this.Saldo)
            {
                this.Saldo -= valor;
                return true;
            }
            else{
                return false;
            }
        }
        public bool Transferencia (ContaCorrente destino, double valor){
            if (this.Saque(valor)){
                destino.Deposito(valor);
                return true;
            }
            else{
                return false;
            }
        }

    }
}