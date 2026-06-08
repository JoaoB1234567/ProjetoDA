using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Models
{
    public class ItemNaoPrevisto
    {
        [Key]
        public int Id { get; set; }

        public virtual ItemCompra ItemCompra { get; set; }

        public int QuantidadeAdquirida { get; set; }

        public string Observacoes { get; set; }
    }
}