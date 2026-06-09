namespace ProjetoDA.Views
{
    partial class Formulário_de_Gestão_de_Tipos_de_Artigo
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCategoria = new System.Windows.Forms.TextBox();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(487, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gestão Tipo de Artigos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Lista de Categorias";
            // 
            // lstCategorias
            // 
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 16;
            this.lstCategorias.Location = new System.Drawing.Point(31, 135);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(709, 516);
            this.lstCategorias.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nome :";
            // 
            // txtNameCategoria
            // 
            this.txtNameCategoria.Location = new System.Drawing.Point(841, 135);
            this.txtNameCategoria.Name = "txtNameCategoria";
            this.txtNameCategoria.Size = new System.Drawing.Size(270, 22);
            this.txtNameCategoria.TabIndex = 34;
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(774, 273);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(211, 55);
            this.btnAddCategoria.TabIndex = 35;
            this.btnAddCategoria.Text = "Adicionar";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 55);
            this.button1.TabIndex = 36;
            this.button1.Text = "Guardar Alterações";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(876, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 55);
            this.button2.TabIndex = 37;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Formulário_de_Gestão_de_Tipos_de_Artigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 668);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCategoria);
            this.Controls.Add(this.txtNameCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Formulário_de_Gestão_de_Tipos_de_Artigo";
            this.Text = "Formulário_de_Gestão_de_Tipos_de_Artigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameCategoria;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}