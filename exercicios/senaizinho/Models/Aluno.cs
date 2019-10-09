using System;
namespace senaizinho.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string Curso {get; set;}
        public int numeroSala { get; set; } 
        public Aluno (string Nome, DateTime dataNascimento, string Curso) {
            this.Nome = Nome;
            this.dataNascimento = dataNascimento;
            this.Curso = Curso;
        }

    }
}