namespace ProjetoDA.Views
{
    partial class Formulário_CriaçãoAlteração_Compra_Planeada
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCompra = new System.Windows.Forms.TextBox();
            this.dgvItensPlaneados = new System.Windows.Forms.DataGridView();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAtualizarItem = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.cmbArtigo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantidadePrevista = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoArtigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPlaneados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadePrevista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Lista de Compras:";
            // 
            // txtNomeCompra
            // 
            this.txtNomeCompra.Location = new System.Drawing.Point(298, 52);
            this.txtNomeCompra.Multiline = true;
            this.txtNomeCompra.Name = "txtNomeCompra";
            this.txtNomeCompra.Size = new System.Drawing.Size(519, 34);
            this.txtNomeCompra.TabIndex = 1;
            // 
            // dgvItensPlaneados
            // 
            this.dgvItensPlaneados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensPlaneados.Location = new System.Drawing.Point(30, 126);
            this.dgvItensPlaneados.Name = "dgvItensPlaneados";
            this.dgvItensPlaneados.RowHeadersWidth = 51;
            this.dgvItensPlaneados.RowTemplate.Height = 24;
            this.dgvItensPlaneados.Size = new System.Drawing.Size(787, 411);
            this.dgvItensPlaneados.TabIndex = 2;
            this.dgvItensPlaneados.SelectionChanged += new System.EventHandler(this.DgvItensPlaneados_SelectionChanged);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(30, 577);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(270, 52);
            this.btnRemoverItem.TabIndex = 3;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.BtnRemoverItem_Click);
            // 
            // btnAtualizarItem
            // 
            this.btnAtualizarItem.Location = new System.Drawing.Point(306, 577);
            this.btnAtualizarItem.Name = "btnAtualizarItem";
            this.btnAtualizarItem.Size = new System.Drawing.Size(270, 52);
            this.btnAtualizarItem.TabIndex = 4;
            this.btnAtualizarItem.Text = "Atualizar";
            this.btnAtualizarItem.UseVisualStyleBackColor = true;
            this.btnAtualizarItem.Click += new System.EventHandler(this.BtnAtualizarItem_Click);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.Location = new System.Drawing.Point(933, 577);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(270, 52);
            this.btnGuardarCompra.TabIndex = 5;
            this.btnGuardarCompra.Text = "Guardar";
            this.btnGuardarCompra.UseVisualStyleBackColor = true;
            this.btnGuardarCompra.Click += new System.EventHandler(this.BtnGuardarCompra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionarItem);
            this.groupBox1.Controls.Add(this.cmbArtigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numQuantidadePrevista);
            this.groupBox1.Controls.Add(this.cmbTipoArtigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(857, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 293);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar artigo ao planeamento";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(29, 219);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(278, 48);
            this.btnAdicionarItem.TabIndex = 15;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.BtnAdicionarItem_Click);
            // 
            // cmbArtigo
            // 
            this.cmbArtigo.FormattingEnabled = true;
            this.cmbArtigo.Location = new System.Drawing.Point(101, 100);
            this.cmbArtigo.Name = "cmbArtigo";
            this.cmbArtigo.Size = new System.Drawing.Size(206, 24);
            this.cmbArtigo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Qtd:";
            // 
            // numQuantidadePrevista
            // 
            this.numQuantidadePrevista.Location = new System.Drawing.Point(101, 152);
            this.numQuantidadePrevista.Name = "numQuantidadePrevista";
            this.numQuantidadePrevista.Size = new System.Drawing.Size(206, 22);
            this.numQuantidadePrevista.TabIndex = 12;
            this.numQuantidadePrevista.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTipoArtigo
            // 
            this.cmbTipoArtigo.FormattingEnabled = true;
            this.cmbTipoArtigo.Location = new System.Drawing.Point(101, 41);
            this.cmbTipoArtigo.Name = "cmbTipoArtigo";
            this.cmbTipoArtigo.Size = new System.Drawing.Size(206, 24);
            this.cmbTipoArtigo.TabIndex = 11;
            this.cmbTipoArtigo.SelectedIndexChanged += new System.EventHandler(this.CmbTipoArtigo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Artigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria:";
            // 
            // Formulário_CriaçãoAlteração_Compra_Planeada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarCompra);
            this.Controls.Add(this.btnAtualizarItem);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.dgvItensPlaneados);
            this.Controls.Add(this.txtNomeCompra);
            this.Controls.Add(this.label1);
            this.Name = "Formulário_CriaçãoAlteração_Compra_Planeada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto DA - Criar / Editar Planeamento";
            this.Load += new System.EventHandler(this.Formulário_CriaçãoAlteração_Compra_Planeada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPlaneados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadePrevista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCompra;
        private System.Windows.Forms.DataGridView dgvItensPlaneados;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnAtualizarItem;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantidadePrevista;
        private System.Windows.Forms.ComboBox cmbTipoArtigo;
        private System.Windows.Forms.ComboBox cmbArtigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarItem;
    }
}
