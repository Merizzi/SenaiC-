using System;
namespace senha.Models {
    public class ContaCorrente {
        public Cliente Titular { get; set; }
        public int Agenda { get; set; }
        public int Numero { get; set; }
        private double _saldo;

        public double Saldo
        {
            get {return _saldo;}
        }

        public ContaCorrente (Cliente Titular, int Agenda, int Numero) {
            this.Titular = Titular;
            this.Agenda = Agenda;
            this.Numero = Numero;
            this._saldo = 0.0;
        }

        public double Deposito(double valor){
            this._saldo += valor;
            return this._saldo;
        }
        public bool Saque (double valor){
            if(valor < this._saldo)
            {
                this._saldo -= valor;
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