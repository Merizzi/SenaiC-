using System;
namespace senha.Models {
    public class ContaCorrente {
        public string Titular { get; set; }
        public int Agenda { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (string Titular, int Agenda, int Numero) {
            this.Titular = Titular;
            this.Agenda = Agenda;
            this.Numero = Numero;
            this.Saldo = 0.0;
        }
        
    }
}