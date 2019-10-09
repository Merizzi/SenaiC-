using System;
namespace senaizinho.Models
{
    public class Sala
    {
        public int capacidadeAtual { get; set; }
        public int capacidadeTotal { get; set; }
        public int numeroSala {get; set;}
        public string Alunos { get; set; } 
        public string alocarAluno;
        public string removerAluno;
        public string mostrarAlunos;
        public Sala (int capacidadeAtual, int capacidadeTotal, int numeroSala, string Alunos) {
            this.capacidadeAtual = capacidadeAtual;
            this.capacidadeTotal = capacidadeTotal;
            this.numeroSala = numeroSala;
            this.Alunos = Alunos;
        }
    }
}