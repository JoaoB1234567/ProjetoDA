using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public class ItemCompra
    {
        [Key]
        public int id { get; set; }
        public int quantidadeAdquirida { get; set; }
        public decimal precoUnitario { get; set; }

        public virtual Artigo artigo { get; set; }
        public virtual Compra compra { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        public virtual User userCriador { get; set; }
        public virtual User userAlterador { get; set; }
    }
}
