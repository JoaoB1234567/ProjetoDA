using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDA.Models {
    public class Orcamento {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Mes { get; set; }

        [Required]
        public decimal ValorMaximo { get; set; }
        public User UserCriador { get; set; }
        public User UserAlterador { get; set; }
    }
}
