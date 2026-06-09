using ProjetoDA.Controller;
using System;
using System.Windows.Forms;

namespace ProjetoDA.Views {
    public partial class Formulário_Planeamento_Compras : Form {
        private PlaneamentoController _controller;

        public Formulário_Planeamento_Compras() {
            InitializeComponent();
            _controller = new PlaneamentoController();
        }

        private void Formulário_Planeamento_Compras_Load(object sender, EventArgs e) {
            if (cmbFiltroEstado.Items.Count > 0) {
                cmbFiltroEstado.SelectedIndex = 0;
            }
            AtualizarGrelhaCompras();
        }

        private void CmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e) {
            AtualizarGrelhaCompras();
        }

        private void AtualizarGrelhaCompras() {
            try {
                string filtro = cmbFiltroEstado.SelectedItem != null ? cmbFiltroEstado.SelectedItem.ToString() : "Todas";
                dgvCompras.DataSource = _controller.ObterListaCompras(filtro);
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao carregar a lista de compras: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNovaCompra_Click(object sender, EventArgs e) {
            var formCriacao = new Formulário_CriaçãoAlteração_Compra_Planeada();
            formCriacao.ShowDialog();
            AtualizarGrelhaCompras();
        }

        private void BtnEditarCompra_Click(object sender, EventArgs e) {
            if (dgvCompras.CurrentRow != null) {
                int compraIdSelecionada = (int)dgvCompras.CurrentRow.Cells["ID"].Value;
                var formCriacao = new Formulário_CriaçãoAlteração_Compra_Planeada(compraIdSelecionada);
                formCriacao.ShowDialog();
                AtualizarGrelhaCompras();
            } else {
                MessageBox.Show("Por favor, selecione uma compra na lista para ver ou editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
