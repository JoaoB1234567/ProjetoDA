using System;
using System.Windows.Forms;

namespace ProjetoDA.Views {
    public partial class FormListaCompras : Form {
        public FormListaCompras() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            FormLogin principal = new FormLogin();
            principal.Show();

            this.Hide();
        }
    }
}
