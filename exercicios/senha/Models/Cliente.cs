using System;
namespace senha.Models {
    public class Cliente {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha{ get; set; }

        public Cliente(string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email= Email;
        }
        
        public bool trocaSenha(string senha){
            if(senha.Length > 6 && senha.Length < 16)
            {
                this.senha = Senha;
                return true;
            }
            else {
                return false;
            }
        }
    }
}