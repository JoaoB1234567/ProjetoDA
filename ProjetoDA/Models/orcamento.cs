using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public class Orcamento
    {
        [Key]
        public int id { get; set; }

        [Required]
        public DateTime mes { get; set; }

        [Required]
        public decimal valor_max { get; set; }        
        public User userCriador { get; set; }
        public User userAlterador { get; set; }
    }
}
