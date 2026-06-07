using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Models {
    public class ItemCompra {
        [Key]
        public int Id { get; set; }
        public int QuantidadeAdquirida { get; set; }
        public decimal PrecoUnitario { get; set; }

        public virtual Artigo Artigo { get; set; }
        public virtual Compra Compra { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        public virtual User UserCriador { get; set; }
        public virtual User UserAlterador { get; set; }
    }
}
