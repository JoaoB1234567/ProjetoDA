using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public class ItemNaoPrevisto : ItemCompra
    {
        public string descricao {  get; set; }
    }
}
