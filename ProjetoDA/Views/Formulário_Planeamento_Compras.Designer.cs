namespace ProjetoDA.Views
{
    partial class Formulário_Planeamento_Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.Button btnEditarCompra;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.btnEditarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(502, 64);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Planeamento da Listas de Compras";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(507, 129);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(972, 574);
            this.dgvCompras.TabIndex = 4;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Arial", 10F);
            this.lblFiltro.Location = new System.Drawing.Point(27, 129);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(140, 19);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtrar por Estado:";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "Todas",
            "Abertas",
            "Fechadas"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(175, 126);
            this.cmbFiltroEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(172, 27);
            this.cmbFiltroEstado.TabIndex = 6;
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnNovaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCompra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnNovaCompra.Location = new System.Drawing.Point(106, 251);
            this.btnNovaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(279, 73);
            this.btnNovaCompra.TabIndex = 7;
            this.btnNovaCompra.Text = "Criar Lista Nova";
            this.btnNovaCompra.UseVisualStyleBackColor = false;
            // 
            // btnEditarCompra
            // 
            this.btnEditarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCompra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarCompra.Location = new System.Drawing.Point(106, 452);
            this.btnEditarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCompra.Name = "btnEditarCompra";
            this.btnEditarCompra.Size = new System.Drawing.Size(279, 73);
            this.btnEditarCompra.TabIndex = 8;
            this.btnEditarCompra.Text = "Ver/Editar";
            this.btnEditarCompra.UseVisualStyleBackColor = false;
            // 
            // Formulário_Planeamento_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 739);
            this.Controls.Add(this.btnEditarCompra);
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.cmbFiltroEstado);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Formulário_Planeamento_Compras";
            this.Text = "Formulário_Planeamento_Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
