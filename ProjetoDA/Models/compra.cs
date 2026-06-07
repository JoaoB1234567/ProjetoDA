using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Models {
    public enum Estado { aberto = 1, fechado = 2, padrao = 0 }
    public class Compra {
        [Key]
        public int Id { get; set; }

        [StringLength(100), Required]
        public string Nome { get; set; }

        [Required]
        public Estado Estado { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        public DateTime? DataFechar { get; set; }

        public virtual User UserCriador { get; set; }
        public virtual User UserFechou { get; set; }

        public virtual List<ItemCompra> ListaCompra { get; set; } = new List<ItemCompra>();
    }
}
