using System;
using System.Windows.Forms;
using ProjetoDA.Controllers;

namespace ProjetoDA.Views
{
    public partial class FormLogin : Form
    {
        private LoginController _loginController;

        public FormLogin()
        {
            InitializeComponent(); // Agora ele já deve encontrar este método!
            _loginController = new LoginController();

            txtPassword.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verifica se as caixas de texto existem com estes nomes exatos
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_loginController.ValidarLogin(username, password))
            {
                MessageBox.Show($"Bem-vindo, {SessaoGlobal.UtilizadorLogadoNome}!", "Sucesso");
                // Quando tiveres o menu principal, descomenta a linha abaixo:
                // new FormPrincipal().Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciais erradas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}