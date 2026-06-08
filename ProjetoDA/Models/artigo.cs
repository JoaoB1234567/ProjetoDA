using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDA.Models
{
    public class Artigo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        // Relação com TipoArtigo
        [ForeignKey("TipoArtigo")]
        public int TipoArtigoId { get; set; }

        public virtual TipoArtigo TipoArtigo { get; set; }
    }
}