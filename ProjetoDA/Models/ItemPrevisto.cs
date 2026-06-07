using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public class ItemPrevisto : ItemCompra
    {
        public int qntPrevista {  get; set; }
    }
}
