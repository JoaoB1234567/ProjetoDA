using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Models {
    public enum Estado { aberto = 1, fechado = 2, padrao = 0 }
    public class Compra {
        [Key]
        public int id { get; set; }

        [StringLength(100), Required]
        public string nome { get; set; }

        [Required]
        public Estado estado { get; set; }

        public DateTime dataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        public DateTime? dataFechar { get; set; }

        public virtual User userCriador { get; set; }
        public virtual User userFechou { get; set; }

        public virtual List<ItemCompra> listaCompra { get; set; } = new List<ItemCompra>();
    }
}
