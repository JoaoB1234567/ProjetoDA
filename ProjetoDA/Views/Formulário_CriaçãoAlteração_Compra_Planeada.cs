using ProjetoDA.Controller;
using ProjetoDA.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.Views {
    public partial class Formulário_CriaçãoAlteração_Compra_Planeada : Form {
        private int _compraId;
        private bool _modoLeitura;
        private CompraController _controller;

        public Formulário_CriaçãoAlteração_Compra_Planeada() {
            InitializeComponent();
            _compraId = 0;
            _modoLeitura = false;
            _controller = new CompraController();
        }

        public Formulário_CriaçãoAlteração_Compra_Planeada(int compraId) {
            InitializeComponent();
            _compraId = compraId;
            _modoLeitura = false;
            _controller = new CompraController();
        }

        private void Formulário_CriaçãoAlteração_Compra_Planeada_Load(object sender, EventArgs e) {
            CarregarTiposArtigo();

            if (_compraId != 0) {
                CarregarDadosCompra();
            } else {
                txtNomeCompra.Text = $"Nova Lista - {DateTime.Now.ToString("dd/MM/yyyy")}";
            }
        }

        private void CarregarTiposArtigo() {
            try {
                cmbTipoArtigo.DataSource = _controller.ObterCategorias();
                cmbTipoArtigo.DisplayMember = "Categoria";
                cmbTipoArtigo.ValueMember = "Id";
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao carregar categorias: {ex.Message}");
            }
        }

        private void CmbTipoArtigo_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbTipoArtigo.SelectedValue != null && int.TryParse(cmbTipoArtigo.SelectedValue.ToString(), out int tipoId)) {
                try {
                    cmbArtigo.DataSource = _controller.ObterArtigosPorCategoria(tipoId);
                    cmbArtigo.DisplayMember = "Nome";
                    cmbArtigo.ValueMember = "Id";
                } catch (Exception) { }
            }
        }

        private void CarregarDadosCompra() {
            try {
                var cabecalho = _controller.ObterCabecalhoCompra(_compraId);
                if (cabecalho != null) {
                    txtNomeCompra.Text = cabecalho.Nome;

                    if (cabecalho.Estado == Estado.fechado) {
                        _modoLeitura = true;
                        DesativarControlosParaLeitura();
                    }

                    AtualizarGrelhaItens();
                }
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        private void DesativarControlosParaLeitura() {
            txtNomeCompra.Enabled = false;
            cmbTipoArtigo.Enabled = false;
            cmbArtigo.Enabled = false;
            numQuantidadePrevista.Enabled = false;
            btnAdicionarItem.Enabled = false;
            btnRemoverItem.Enabled = false;
            btnAtualizarItem.Enabled = false;
            btnGuardarCompra.Enabled = false;
            this.Text += " (Modo Leitura - Fechada)";
        }

        private void BtnAdicionarItem_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNomeCompra.Text)) {
                MessageBox.Show("Por favor, dê um nome à lista antes de adicionar artigos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbArtigo.SelectedValue == null) {
                MessageBox.Show("Por favor, selecione um artigo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                int artigoId = (int)cmbArtigo.SelectedValue;
                int utilizadorId = SessaoGlobal.UtilizadorLogadoId;

                _compraId = _controller.AdicionarItem(_compraId, txtNomeCompra.Text.Trim(), artigoId, (int)numQuantidadePrevista.Value, utilizadorId);

                numQuantidadePrevista.Value = 1;
                AtualizarGrelhaItens();
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao adicionar item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvItensPlaneados_SelectionChanged(object sender, EventArgs e) {
            if (dgvItensPlaneados.CurrentRow != null && !_modoLeitura) {
                try {
                    int itemId = (int)dgvItensPlaneados.CurrentRow.Cells["ID"].Value;
                    var detalhes = _controller.ObterDetalhesItem(itemId);

                    if (detalhes != null) {
                        cmbTipoArtigo.SelectedValue = detalhes.Artigo.TipoArtigo.Id;
                        cmbArtigo.SelectedValue = detalhes.Artigo.Id;
                        numQuantidadePrevista.Value = detalhes.QuantidadePrevista;
                    }
                } catch { }
            }
        }

        private void BtnAtualizarItem_Click(object sender, EventArgs e) {
            if (dgvItensPlaneados.CurrentRow == null) {
                MessageBox.Show("Selecione um artigo na tabela primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbArtigo.SelectedValue == null) {
                MessageBox.Show("Por favor, selecione um artigo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                int itemId = (int)dgvItensPlaneados.CurrentRow.Cells["ID"].Value;
                int novoArtigoId = (int)cmbArtigo.SelectedValue;

                _controller.AtualizarItem(itemId, novoArtigoId, (int)numQuantidadePrevista.Value, _compraId);

                AtualizarGrelhaItens();
                MessageBox.Show("Artigo atualizado com sucesso!");
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao atualizar item: {ex.Message}");
            }
        }

        private void BtnRemoverItem_Click(object sender, EventArgs e) {
            if (dgvItensPlaneados.CurrentRow != null && !_modoLeitura) {
                try {
                    int itemId = (int)dgvItensPlaneados.CurrentRow.Cells["ID"].Value;

                    _controller.RemoverItem(itemId, _compraId);

                    AtualizarGrelhaItens();
                } catch (Exception ex) {
                    MessageBox.Show($"Erro ao remover item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (dgvItensPlaneados.CurrentRow == null) {
                MessageBox.Show("Selecione um artigo na tabela para o remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarGrelhaItens() {
            if (_compraId == 0) return;

            try {
                var itensPlaneados = _controller.ObterItensPlaneados(_compraId);

                var itensFormatados = itensPlaneados.Select(i => new {
                    ID = i.Id,
                    Produto = i.Artigo != null ? i.Artigo.Nome : "Artigo Desconhecido",
                    Qtd_Prevista = i.QuantidadePrevista
                }).ToList();

                dgvItensPlaneados.DataSource = itensFormatados;
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao atualizar tabela de itens: {ex.Message}");
            }
        }

        private void BtnGuardarCompra_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNomeCompra.Text)) {
                MessageBox.Show("O nome da lista não pode estar vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                int utilizadorId = SessaoGlobal.UtilizadorLogadoId;
                _controller.GuardarCompra(_compraId, txtNomeCompra.Text.Trim(), utilizadorId);

                MessageBox.Show("Lista de compras guardada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao guardar a lista: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
