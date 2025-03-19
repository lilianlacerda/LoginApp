using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.Telas
{
    public partial class CadastrarForm : Form
    {
        public CadastrarForm()
        {
            InitializeComponent();
            this.FormClosed += applicationClose;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void applicationClose(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        public void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmacaoSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            armazenarUsuario();
        }
        public void armazenarUsuario()
        {
            if (!string.IsNullOrEmpty(textBoxNome.Text) || !string.IsNullOrEmpty(textBoxTelefone.Text) || !string.IsNullOrEmpty(textBoxEmail.Text) || !string.IsNullOrEmpty(textBoxSenha.Text) || !string.IsNullOrEmpty(textBoxConfirmacaoSenha.Text))
            {
                List<Usuario> ListaUsuarios = new List<Usuario>();
                Usuario usuario = new Usuario(textBoxNome.Text, textBoxEmail.Text, textBoxTelefone.Text, textBoxSenha.Text, textBoxConfirmacaoSenha.Text);
                ListaUsuarios.Add(usuario);
                MessageBox.Show("Usuário cadastrado com sucesso!");
                limparCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!");
            }
        }

        public void limparCampos()
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxTelefone.Text = "";
            textBoxSenha.Text = "";
            textBoxConfirmacaoSenha.Text = "";

        }
    }
}
