namespace ProjetoDA.Views
{
    partial class Formulário_modo_Compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.numQtdAdquirida = new System.Windows.Forms.NumericUpDown();
            this.lblQtdAdquirida = new System.Windows.Forms.Label();
            this.grpAdicionarExtra = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtPrecoExtra = new System.Windows.Forms.TextBox();
            this.lblPrecoExtra = new System.Windows.Forms.Label();
            this.numQtdExtra = new System.Windows.Forms.NumericUpDown();
            this.lblQtdExtra = new System.Windows.Forms.Label();
            this.cmbArtigoExtra = new System.Windows.Forms.ComboBox();
            this.lblArtigoExtra = new System.Windows.Forms.Label();
            this.cmbTipoArtigoExtra = new System.Windows.Forms.ComboBox();
            this.lblTipoArtigoExtra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).BeginInit();
            this.grpRegistarItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdAdquirida)).BeginInit();
            this.grpAdicionarExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCompra
            // 
            this.lblNomeCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNomeCompra.Location = new System.Drawing.Point(24, 47);
            this.lblNomeCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCompra.Name = "lblNomeCompra";
            this.lblNomeCompra.Size = new System.Drawing.Size(600, 31);
            this.lblNomeCompra.TabIndex = 6;
            this.lblNomeCompra.Text = "A Listar Compras:";
            // 
            // dgvItensCompra
            // 
            this.dgvItensCompra.AllowUserToAddRows = false;
            this.dgvItensCompra.AllowUserToDeleteRows = false;
            this.dgvItensCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensCompra.Location = new System.Drawing.Point(28, 96);
            this.dgvItensCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItensCompra.MultiSelect = false;
            this.dgvItensCompra.Name = "dgvItensCompra";
            this.dgvItensCompra.ReadOnly = true;
            this.dgvItensCompra.RowHeadersWidth = 51;
            this.dgvItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensCompra.Size = new System.Drawing.Size(910, 636);
            this.dgvItensCompra.TabIndex = 7;
            // 
            // grpRegistarItem
            // 
            this.grpRegistarItem.Controls.Add(this.btnRegistarItem);
            this.grpRegistarItem.Controls.Add(this.txtPrecoUnitario);
            this.grpRegistarItem.Controls.Add(this.lblPrecoUnitario);
            this.grpRegistarItem.Controls.Add(this.numQtdAdquirida);
            this.grpRegistarItem.Controls.Add(this.lblQtdAdquirida);
            this.grpRegistarItem.Location = new System.Drawing.Point(977, 105);
            this.grpRegistarItem.Margin = new System.Windows.Forms.Padding(4);
            this.grpRegistarItem.Name = "grpRegistarItem";
            this.grpRegistarItem.Padding = new System.Windows.Forms.Padding(4);
            this.grpRegistarItem.Size = new System.Drawing.Size(513, 252);
            this.grpRegistarItem.TabIndex = 8;
            this.grpRegistarItem.TabStop = false;
            this.grpRegistarItem.Text = "Registar Item ";
            // 
            // btnRegistarItem
            // 
            this.btnRegistarItem.Location = new System.Drawing.Point(316, 201);
            this.btnRegistarItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistarItem.Name = "btnRegistarItem";
            this.btnRegistarItem.Size = new System.Drawing.Size(189, 43);
            this.btnRegistarItem.TabIndex = 0;
            this.btnRegistarItem.Text = "Atualizar Item no Carrinho";
            this.btnRegistarItem.UseVisualStyleBackColor = true;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(23, 134);
            this.txtPrecoUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(159, 22);
            this.txtPrecoUnitario.TabIndex = 1;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.Location = new System.Drawing.Point(20, 105);
            this.lblPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(133, 25);
            this.lblPrecoUnitario.TabIndex = 2;
            this.lblPrecoUnitario.Text = "Preço Unitário (€):";
            // 
            // numQtdAdquirida
            // 
            this.numQtdAdquirida.Location = new System.Drawing.Point(23, 66);
            this.numQtdAdquirida.Margin = new System.Windows.Forms.Padding(4);
            this.numQtdAdquirida.Name = "numQtdAdquirida";
            this.numQtdAdquirida.Size = new System.Drawing.Size(67, 22);
            this.numQtdAdquirida.TabIndex = 3;
            // 
            // lblQtdAdquirida
            // 
            this.lblQtdAdquirida.Location = new System.Drawing.Point(20, 43);
            this.lblQtdAdquirida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdAdquirida.Name = "lblQtdAdquirida";
            this.lblQtdAdquirida.Size = new System.Drawing.Size(133, 25);
            this.lblQtdAdquirida.TabIndex = 4;
            this.lblQtdAdquirida.Text = "Qtd. Adquirida:";
            // 
            // grpAdicionarExtra
            // 
            this.grpAdicionarExtra.Controls.Add(this.button1);
            this.grpAdicionarExtra.Controls.Add(this.txtObservacoes);
            this.grpAdicionarExtra.Controls.Add(this.lblObservacoes);
            this.grpAdicionarExtra.Controls.Add(this.txtPrecoExtra);
            this.grpAdicionarExtra.Controls.Add(this.lblPrecoExtra);
            this.grpAdicionarExtra.Controls.Add(this.numQtdExtra);
            this.grpAdicionarExtra.Controls.Add(this.lblQtdExtra);
            this.grpAdicionarExtra.Controls.Add(this.cmbArtigoExtra);
            this.grpAdicionarExtra.Controls.Add(this.lblArtigoExtra);
            this.grpAdicionarExtra.Controls.Add(this.cmbTipoArtigoExtra);
            this.grpAdicionarExtra.Controls.Add(this.lblTipoArtigoExtra);
            this.grpAdicionarExtra.Location = new System.Drawing.Point(977, 427);
            this.grpAdicionarExtra.Margin = new System.Windows.Forms.Padding(4);
            this.grpAdicionarExtra.Name = "grpAdicionarExtra";
            this.grpAdicionarExtra.Padding = new System.Windows.Forms.Padding(4);
            this.grpAdicionarExtra.Size = new System.Drawing.Size(540, 252);
            this.grpAdicionarExtra.TabIndex = 9;
            this.grpAdicionarExtra.TabStop = false;
            this.grpAdicionarExtra.Text = "Adicionar Artigo Não Previsto";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(133, 144);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(385, 22);
            this.txtObservacoes.TabIndex = 1;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Location = new System.Drawing.Point(20, 148);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(107, 25);
            this.lblObservacoes.TabIndex = 2;
            this.lblObservacoes.Text = "Observações:";
            // 
            // txtPrecoExtra
            // 
            this.txtPrecoExtra.Location = new System.Drawing.Point(360, 105);
            this.txtPrecoExtra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoExtra.Name = "txtPrecoExtra";
            this.txtPrecoExtra.Size = new System.Drawing.Size(145, 22);
            this.txtPrecoExtra.TabIndex = 3;
            // 
            // lblPrecoExtra
            // 
            this.lblPrecoExtra.Location = new System.Drawing.Point(267, 108);
            this.lblPrecoExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoExtra.Name = "lblPrecoExtra";
            this.lblPrecoExtra.Size = new System.Drawing.Size(93, 25);
            this.lblPrecoExtra.TabIndex = 4;
            this.lblPrecoExtra.Text = "Preço (€):";
            // 
            // numQtdExtra
            // 
            this.numQtdExtra.Location = new System.Drawing.Point(133, 106);
            this.numQtdExtra.Margin = new System.Windows.Forms.Padding(4);
            this.numQtdExtra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdExtra.Name = "numQtdExtra";
            this.numQtdExtra.Size = new System.Drawing.Size(58, 22);
            this.numQtdExtra.TabIndex = 5;
            this.numQtdExtra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQtdExtra
            // 
            this.lblQtdExtra.Location = new System.Drawing.Point(20, 108);
            this.lblQtdExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdExtra.Name = "lblQtdExtra";
            this.lblQtdExtra.Size = new System.Drawing.Size(107, 25);
            this.lblQtdExtra.TabIndex = 6;
            this.lblQtdExtra.Text = "Qtd. Extra:";
            // 
            // cmbArtigoExtra
            // 
            this.cmbArtigoExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtigoExtra.Location = new System.Drawing.Point(133, 64);
            this.cmbArtigoExtra.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArtigoExtra.Name = "cmbArtigoExtra";
            this.cmbArtigoExtra.Size = new System.Drawing.Size(151, 24);
            this.cmbArtigoExtra.TabIndex = 7;
            // 
            // lblArtigoExtra
            // 
            this.lblArtigoExtra.Location = new System.Drawing.Point(20, 68);
            this.lblArtigoExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtigoExtra.Name = "lblArtigoExtra";
            this.lblArtigoExtra.Size = new System.Drawing.Size(107, 25);
            this.lblArtigoExtra.TabIndex = 8;
            this.lblArtigoExtra.Text = "Artigo:";
            // 
            // cmbTipoArtigoExtra
            // 
            this.cmbTipoArtigoExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArtigoExtra.Location = new System.Drawing.Point(133, 27);
            this.cmbTipoArtigoExtra.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoArtigoExtra.Name = "cmbTipoArtigoExtra";
            this.cmbTipoArtigoExtra.Size = new System.Drawing.Size(151, 24);
            this.cmbTipoArtigoExtra.TabIndex = 9;
            // 
            // lblTipoArtigoExtra
            // 
            this.lblTipoArtigoExtra.Location = new System.Drawing.Point(20, 31);
            this.lblTipoArtigoExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoArtigoExtra.Name = "lblTipoArtigoExtra";
            this.lblTipoArtigoExtra.Size = new System.Drawing.Size(107, 25);
            this.lblTipoArtigoExtra.TabIndex = 10;
            this.lblTipoArtigoExtra.Text = "Tipo Artigo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Inserir artigo não previsto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Formulário_modo_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 803);
            this.Controls.Add(this.grpAdicionarExtra);
            this.Controls.Add(this.grpRegistarItem);
            this.Controls.Add(this.dgvItensCompra);
            this.Controls.Add(this.lblNomeCompra);
            this.Name = "Formulário_modo_Compra";
            this.Text = "Formulário_modo_Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).EndInit();
            this.grpRegistarItem.ResumeLayout(false);
            this.grpRegistarItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdAdquirida)).EndInit();
            this.grpAdicionarExtra.ResumeLayout(false);
            this.grpAdicionarExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdExtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompra;
        private System.Windows.Forms.DataGridView dgvItensCompra;
        private System.Windows.Forms.GroupBox grpRegistarItem;
        private System.Windows.Forms.Button btnRegistarItem;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.NumericUpDown numQtdAdquirida;
        private System.Windows.Forms.Label lblQtdAdquirida;
        private System.Windows.Forms.GroupBox grpAdicionarExtra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtPrecoExtra;
        private System.Windows.Forms.Label lblPrecoExtra;
        private System.Windows.Forms.NumericUpDown numQtdExtra;
        private System.Windows.Forms.Label lblQtdExtra;
        private System.Windows.Forms.ComboBox cmbArtigoExtra;
        private System.Windows.Forms.Label lblArtigoExtra;
        private System.Windows.Forms.ComboBox cmbTipoArtigoExtra;
        private System.Windows.Forms.Label lblTipoArtigoExtra;
    }
}