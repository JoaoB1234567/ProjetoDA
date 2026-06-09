using System;
using System.Linq;
using System.Windows.Forms;
using ProjetoDA.Controller;
using ProjetoDA.Models;

namespace ProjetoDA.Views {
    public partial class FormListaCompras : Form {
        private CompraController _compraController;

        public FormListaCompras() {
            InitializeComponent();

            _compraController = new CompraController();

            // wire up events for existing buttons
            this.Load += FormListaCompras_Load;
            this.button3.Click += button3_Click;
            this.button5.Click += button5_Click;
            this.button6.Click += button6_Click;
            this.button7.Click += button7_Click;
            this.button8.Click += button8_Click;
            this.button9.Click += button9_Click;
            this.button10.Click += button10_Click;
            this.listBox1.DoubleClick += listBox1_DoubleClick;
        }

        private void FormListaCompras_Load(object sender, EventArgs e) {
            LoadCompras();
        }

        private void LoadCompras() {
            try {
                var compras = _compraController.ObterCompras() ?? Enumerable.Empty<Compra>().ToList();

                listBox1.DisplayMember = "Nome";
                listBox1.ValueMember = "Id";
                listBox1.DataSource = compras;
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao carregar as compras: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            FormLogin principal = new FormLogin();
            principal.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            var f = new Formulário_de_Gestão_de_Tipos_de_Artigo();
            f.ShowDialog();
            LoadCompras();
        }

        private void button5_Click(object sender, EventArgs e) {
            var f = new Formulário_Gestão_Artigos();
            f.ShowDialog();
            LoadCompras();
        }

        private void button6_Click(object sender, EventArgs e) {
            var f = new Formulário_Gestão_Orçamentos();
            f.ShowDialog();
            LoadCompras();
        }

        private void button7_Click(object sender, EventArgs e) {
            var f = new Formulário_Planeamento_Compras();
            f.ShowDialog();
            LoadCompras();
        }

        private void button8_Click(object sender, EventArgs e) {
            var f = new Formulário_CriaçãoAlteração_Compra_Planeada();
            f.ShowDialog();
            LoadCompras();
        }

        private void button9_Click(object sender, EventArgs e) {
            if (listBox1.SelectedValue != null && int.TryParse(listBox1.SelectedValue.ToString(), out int id)) {
                var f = new Formulário_modo_Compra(id);
                f.ShowDialog();
                LoadCompras();
            } else {
                MessageBox.Show("Selecione uma compra na lista para entrar no Modo Compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e) {
            var f = new Formulário_Estatísticas();
            f.ShowDialog();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e) {
            if (listBox1.SelectedValue != null && int.TryParse(listBox1.SelectedValue.ToString(), out int id)) {
                var f = new Formulário_CriaçãoAlteração_Compra_Planeada(id);
                f.ShowDialog();
                LoadCompras();
            }
        }
    }
}
