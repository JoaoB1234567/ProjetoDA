namespace ProjetoDA.Views
{
    partial class Formulário_Gestão_Orçamentos
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
            this.cmbAnoFiltro = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lstOrcamentos = new System.Windows.Forms.ListBox();
            this.lblCriadoPor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEditadoPor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gestão Orçamentos";
            // 
            // cmbAnoFiltro
            // 
            this.cmbAnoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnoFiltro.FormattingEnabled = true;
            this.cmbAnoFiltro.Location = new System.Drawing.Point(28, 754);
            this.cmbAnoFiltro.Name = "cmbAnoFiltro";
            this.cmbAnoFiltro.Size = new System.Drawing.Size(131, 24);
            this.cmbAnoFiltro.TabIndex = 28;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(165, 755);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 23);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Procurar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lstOrcamentos
            // 
            this.lstOrcamentos.FormattingEnabled = true;
            this.lstOrcamentos.ItemHeight = 16;
            this.lstOrcamentos.Location = new System.Drawing.Point(28, 125);
            this.lstOrcamentos.Name = "lstOrcamentos";
            this.lstOrcamentos.Size = new System.Drawing.Size(655, 612);
            this.lstOrcamentos.TabIndex = 37;
            // 
            // lblCriadoPor
            // 
            this.lblCriadoPor.AutoSize = true;
            this.lblCriadoPor.Location = new System.Drawing.Point(270, 96);
            this.lblCriadoPor.Name = "lblCriadoPor";
            this.lblCriadoPor.Size = new System.Drawing.Size(79, 16);
            this.lblCriadoPor.TabIndex = 40;
            this.lblCriadoPor.Text = "Criado por : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Lista de Orçamentos";
            // 
            // lblEditadoPor
            // 
            this.lblEditadoPor.AutoSize = true;
            this.lblEditadoPor.Location = new System.Drawing.Point(476, 96);
            this.lblEditadoPor.Name = "lblEditadoPor";
            this.lblEditadoPor.Size = new System.Drawing.Size(83, 16);
            this.lblEditadoPor.TabIndex = 42;
            this.lblEditadoPor.Text = "Editado por :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Valor máximo :";
            // 
            // txtValorMax
            // 
            this.txtValorMax.Location = new System.Drawing.Point(770, 90);
            this.txtValorMax.Name = "txtValorMax";
            this.txtValorMax.Size = new System.Drawing.Size(159, 22);
            this.txtValorMax.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(972, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mês :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1017, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(718, 293);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(211, 55);
            this.btnAddCategoria.TabIndex = 47;
            this.btnAddCategoria.Text = "Adicionar";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(935, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 55);
            this.button1.TabIndex = 48;
            this.button1.Text = "Guardar Alterações";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(819, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 55);
            this.button2.TabIndex = 49;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Formulário_Gestão_Orçamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 805);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCategoria);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEditadoPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCriadoPor);
            this.Controls.Add(this.lstOrcamentos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cmbAnoFiltro);
            this.Controls.Add(this.label1);
            this.Name = "Formulário_Gestão_Orçamentos";
            this.Text = "Formulário_Gestão_Orçamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnoFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListBox lstOrcamentos;
        private System.Windows.Forms.Label lblCriadoPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEditadoPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}