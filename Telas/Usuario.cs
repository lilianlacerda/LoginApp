using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Telas
{
    internal class Usuario
    {
        public string Nome;
        public string Email;
        public string Telefone;
        public string Senha;
        public string ConfirmacaoSenha;

        public Usuario(string nome, string email, string telefone, string senha, string confirmacaoSenha)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            ConfirmacaoSenha = confirmacaoSenha;
        }
    }
}
