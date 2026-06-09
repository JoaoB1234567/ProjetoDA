namespace ProjetoDA.Views
{
    partial class Formulário_modo_Compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNomeCompra;
        private System.Windows.Forms.DataGridView dgvItensCompra;
        private System.Windows.Forms.GroupBox grpRegistarItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQtdAdquirida;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Button btnRegistarItem;
        private System.Windows.Forms.GroupBox grpAdicionarExtra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoArtigoExtra;
        private System.Windows.Forms.ComboBox cmbArtigoExtra;
        private System.Windows.Forms.NumericUpDown numQtdExtra;
        private System.Windows.Forms.TextBox txtPrecoExtra;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnAdicionarExtra;
        private System.Windows.Forms.Label lblOrcamentoDisponivel;
        private System.Windows.Forms.Button btnFecharCompra;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeCompra = new System.Windows.Forms.Label();
            this.dgvItensCompra = new System.Windows.Forms.DataGridView();
            this.grpRegistarItem = new System.Windows.Forms.GroupBox();
            this.btnRegistarItem = new System.Windows.Forms.Button();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.numQtdAdquirida = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAdicionarExtra = new System.Windows.Forms.GroupBox();
            this.btnAdicionarExtra = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtPrecoExtra = new System.Windows.Forms.TextBox();
            this.numQtdExtra = new System.Windows.Forms.NumericUpDown();
            this.cmbArtigoExtra = new System.Windows.Forms.ComboBox();
            this.cmbTipoArtigoExtra = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrcamentoDisponivel = new System.Windows.Forms.Label();
            this.btnFecharCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).BeginInit();
            this.grpRegistarItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdAdquirida)).BeginInit();
            this.grpAdicionarExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCompra
            // 
            this.lblNomeCompra.AutoSize = true;
            this.lblNomeCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNomeCompra.Location = new System.Drawing.Point(20, 20);
            this.lblNomeCompra.Name = "lblNomeCompra";
            this.lblNomeCompra.Size = new System.Drawing.Size(164, 24);
            this.lblNomeCompra.TabIndex = 0;
            this.lblNomeCompra.Text = "Carrinho Atual: ";
            // 
            // dgvItensCompra
            // 
            this.dgvItensCompra.AllowUserToAddRows = false;
            this.dgvItensCompra.AllowUserToDeleteRows = false;
            this.dgvItensCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensCompra.Location = new System.Drawing.Point(20, 60);
            this.dgvItensCompra.MultiSelect = false;
            this.dgvItensCompra.Name = "dgvItensCompra";
            this.dgvItensCompra.ReadOnly = true;
            this.dgvItensCompra.RowHeadersWidth = 51;
            this.dgvItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensCompra.Size = new System.Drawing.Size(850, 300);
            this.dgvItensCompra.TabIndex = 1;
            this.dgvItensCompra.SelectionChanged += new System.EventHandler(this.DgvItensCompra_SelectionChanged);
            // 
            // grpRegistarItem
            // 
            this.grpRegistarItem.Controls.Add(this.btnRegistarItem);
            this.grpRegistarItem.Controls.Add(this.txtPrecoUnitario);
            this.grpRegistarItem.Controls.Add(this.numQtdAdquirida);
            this.grpRegistarItem.Controls.Add(this.label2);
            this.grpRegistarItem.Controls.Add(this.label1);
            this.grpRegistarItem.Location = new System.Drawing.Point(20, 380);
            this.grpRegistarItem.Name = "grpRegistarItem";
            this.grpRegistarItem.Size = new System.Drawing.Size(400, 150);
            this.grpRegistarItem.TabIndex = 2;
            this.grpRegistarItem.TabStop = false;
            this.grpRegistarItem.Text = "Registar Item do Carrinho";
            // 
            // btnRegistarItem
            // 
            this.btnRegistarItem.Location = new System.Drawing.Point(130, 100);
            this.btnRegistarItem.Name = "btnRegistarItem";
            this.btnRegistarItem.Size = new System.Drawing.Size(250, 35);
            this.btnRegistarItem.TabIndex = 4;
            this.btnRegistarItem.Text = "Atualizar Item";
            this.btnRegistarItem.UseVisualStyleBackColor = true;
            this.btnRegistarItem.Click += new System.EventHandler(this.BtnRegistarItem_Click);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(130, 65);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(250, 22);
            this.txtPrecoUnitario.TabIndex = 3;
            // 
            // numQtdAdquirida
            // 
            this.numQtdAdquirida.Location = new System.Drawing.Point(130, 30);
            this.numQtdAdquirida.Name = "numQtdAdquirida";
            this.numQtdAdquirida.Size = new System.Drawing.Size(250, 22);
            this.numQtdAdquirida.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço Unitário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qtd. Adquirida:";
            // 
            // grpAdicionarExtra
            // 
            this.grpAdicionarExtra.Controls.Add(this.btnAdicionarExtra);
            this.grpAdicionarExtra.Controls.Add(this.txtObservacoes);
            this.grpAdicionarExtra.Controls.Add(this.txtPrecoExtra);
            this.grpAdicionarExtra.Controls.Add(this.numQtdExtra);
            this.grpAdicionarExtra.Controls.Add(this.cmbArtigoExtra);
            this.grpAdicionarExtra.Controls.Add(this.cmbTipoArtigoExtra);
            this.grpAdicionarExtra.Controls.Add(this.label7);
            this.grpAdicionarExtra.Controls.Add(this.label6);
            this.grpAdicionarExtra.Controls.Add(this.label5);
            this.grpAdicionarExtra.Controls.Add(this.label4);
            this.grpAdicionarExtra.Controls.Add(this.label3);
            this.grpAdicionarExtra.Location = new System.Drawing.Point(440, 380);
            this.grpAdicionarExtra.Name = "grpAdicionarExtra";
            this.grpAdicionarExtra.Size = new System.Drawing.Size(430, 230);
            this.grpAdicionarExtra.TabIndex = 3;
            this.grpAdicionarExtra.TabStop = false;
            this.grpAdicionarExtra.Text = "Adicionar Artigo Extra (Não Previsto)";
            // 
            // btnAdicionarExtra
            // 
            this.btnAdicionarExtra.Location = new System.Drawing.Point(120, 185);
            this.btnAdicionarExtra.Name = "btnAdicionarExtra";
            this.btnAdicionarExtra.Size = new System.Drawing.Size(290, 35);
            this.btnAdicionarExtra.TabIndex = 10;
            this.btnAdicionarExtra.Text = "Adicionar Extra ao Carrinho";
            this.btnAdicionarExtra.UseVisualStyleBackColor = true;
            this.btnAdicionarExtra.Click += new System.EventHandler(this.BtnAdicionarExtra_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(120, 155);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(290, 22);
            this.txtObservacoes.TabIndex = 9;
            // 
            // txtPrecoExtra
            // 
            this.txtPrecoExtra.Location = new System.Drawing.Point(120, 125);
            this.txtPrecoExtra.Name = "txtPrecoExtra";
            this.txtPrecoExtra.Size = new System.Drawing.Size(290, 22);
            this.txtPrecoExtra.TabIndex = 8;
            // 
            // numQtdExtra
            // 
            this.numQtdExtra.Location = new System.Drawing.Point(120, 95);
            this.numQtdExtra.Name = "numQtdExtra";
            this.numQtdExtra.Size = new System.Drawing.Size(290, 22);
            this.numQtdExtra.TabIndex = 7;
            this.numQtdExtra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbArtigoExtra
            // 
            this.cmbArtigoExtra.FormattingEnabled = true;
            this.cmbArtigoExtra.Location = new System.Drawing.Point(120, 60);
            this.cmbArtigoExtra.Name = "cmbArtigoExtra";
            this.cmbArtigoExtra.Size = new System.Drawing.Size(290, 24);
            this.cmbArtigoExtra.TabIndex = 6;
            // 
            // cmbTipoArtigoExtra
            // 
            this.cmbTipoArtigoExtra.FormattingEnabled = true;
            this.cmbTipoArtigoExtra.Location = new System.Drawing.Point(120, 30);
            this.cmbTipoArtigoExtra.Name = "cmbTipoArtigoExtra";
            this.cmbTipoArtigoExtra.Size = new System.Drawing.Size(290, 24);
            this.cmbTipoArtigoExtra.TabIndex = 5;
            this.cmbTipoArtigoExtra.SelectedIndexChanged += new System.EventHandler(this.CmbTipoArtigoExtra_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Observações:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Qtd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Artigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria:";
            // 
            // lblOrcamentoDisponivel
            // 
            this.lblOrcamentoDisponivel.AutoSize = true;
            this.lblOrcamentoDisponivel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrcamentoDisponivel.Location = new System.Drawing.Point(20, 560);
            this.lblOrcamentoDisponivel.Name = "lblOrcamentoDisponivel";
            this.lblOrcamentoDisponivel.Size = new System.Drawing.Size(182, 22);
            this.lblOrcamentoDisponivel.TabIndex = 4;
            this.lblOrcamentoDisponivel.Text = "Saldo Disponível: ";
            // 
            // btnFecharCompra
            // 
            this.btnFecharCompra.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFecharCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharCompra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnFecharCompra.ForeColor = System.Drawing.Color.White;
            this.btnFecharCompra.Location = new System.Drawing.Point(20, 600);
            this.btnFecharCompra.Name = "btnFecharCompra";
            this.btnFecharCompra.Size = new System.Drawing.Size(400, 45);
            this.btnFecharCompra.TabIndex = 5;
            this.btnFecharCompra.Text = "FINALIZAR COMPRA";
            this.btnFecharCompra.UseVisualStyleBackColor = false;
            this.btnFecharCompra.Click += new System.EventHandler(this.BtnFecharCompra_Click);
            // 
            // Formulário_modo_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.btnFecharCompra);
            this.Controls.Add(this.lblOrcamentoDisponivel);
            this.Controls.Add(this.grpAdicionarExtra);
            this.Controls.Add(this.grpRegistarItem);
            this.Controls.Add(this.dgvItensCompra);
            this.Controls.Add(this.lblNomeCompra);
            this.Name = "Formulário_modo_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto DA - Modo de Compra";
            this.Load += new System.EventHandler(this.Formulário_modo_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).EndInit();
            this.grpRegistarItem.ResumeLayout(false);
            this.grpRegistarItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdAdquirida)).EndInit();
            this.grpAdicionarExtra.ResumeLayout(false);
            this.grpAdicionarExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
