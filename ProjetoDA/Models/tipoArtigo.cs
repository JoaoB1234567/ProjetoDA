using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Models {
    public class TipoArtigo {
        [Key]
        public int Id { get; set; }

        [StringLength(100), Required]
        public string Categoria { get; set; }
    }
}
