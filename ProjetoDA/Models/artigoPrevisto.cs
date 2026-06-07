using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShopping.Model
{
    public class artigoPrevisto : itemCompra
    {
        public int qntPrevista {  get; set; }
    }
}
