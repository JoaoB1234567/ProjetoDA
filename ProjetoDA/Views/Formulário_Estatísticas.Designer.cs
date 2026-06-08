namespace ProjetoDA.Views
{
    partial class Formulário_Estatísticas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblOrcamentoSugerido = new System.Windows.Forms.Label();
            this.btnGerarSugestao = new System.Windows.Forms.Button();
            this.dgvSugestaoCompras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestaoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orçamento vs Gastos do Mes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 276);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orçamento vs Gastos do Mes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 459);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(651, 276);
            this.dataGridView2.TabIndex = 4;
            // 
            // lblOrcamentoSugerido
            // 
            this.lblOrcamentoSugerido.AutoSize = true;
            this.lblOrcamentoSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrcamentoSugerido.ForeColor = System.Drawing.Color.Black;
            this.lblOrcamentoSugerido.Location = new System.Drawing.Point(736, 32);
            this.lblOrcamentoSugerido.Name = "lblOrcamentoSugerido";
            this.lblOrcamentoSugerido.Size = new System.Drawing.Size(473, 25);
            this.lblOrcamentoSugerido.TabIndex = 5;
            this.lblOrcamentoSugerido.Text = "Orçamento Recomendado  para o Próximo Mês:";
            // 
            // btnGerarSugestao
            // 
            this.btnGerarSugestao.Location = new System.Drawing.Point(1248, 29);
            this.btnGerarSugestao.Name = "btnGerarSugestao";
            this.btnGerarSugestao.Size = new System.Drawing.Size(225, 36);
            this.btnGerarSugestao.TabIndex = 7;
            this.btnGerarSugestao.Text = "Gerar Sugestão Semanal";
            this.btnGerarSugestao.UseVisualStyleBackColor = true;
            // 
            // dgvSugestaoCompras
            // 
            this.dgvSugestaoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugestaoCompras.Location = new System.Drawing.Point(753, 86);
            this.dgvSugestaoCompras.Name = "dgvSugestaoCompras";
            this.dgvSugestaoCompras.RowHeadersWidth = 51;
            this.dgvSugestaoCompras.Size = new System.Drawing.Size(711, 649);
            this.dgvSugestaoCompras.TabIndex = 8;
            // 
            // Formulário_Estatísticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 764);
            this.Controls.Add(this.dgvSugestaoCompras);
            this.Controls.Add(this.btnGerarSugestao);
            this.Controls.Add(this.lblOrcamentoSugerido);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Formulário_Estatísticas";
            this.Text = "Formulário_Estatísticas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestaoCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblOrcamentoSugerido;
        private System.Windows.Forms.Button btnGerarSugestao;
        private System.Windows.Forms.DataGridView dgvSugestaoCompras;
    }
}