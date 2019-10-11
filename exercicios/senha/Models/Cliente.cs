using System;
namespace senha.Models {
    public class Cliente {
        private string _nome ;
        private string _email ;
        private string _cpf;
        private string _senha;
        
        public string Senha{
            get {return _senha;}
        }
        public string Nome{
            get{return _nome;}
        }
        public string Email
        {
            get{return _email;}
        }

        public string Cpf
        {
            get {return _cpf;}
        }

        public Cliente (string _nome, string _cpf, string _email) {
            this._nome = _nome;
            this._cpf = _cpf;
            this._email = _email;
        }
        public bool TrocaSenha (string senha) {
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this._senha = senha;
                return true;
            } else {
                return false;
            }
        }

        
    }
}