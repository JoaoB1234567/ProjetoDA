using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoDA.Models
{    
    public class User
    {
        [Key] public int id { get; set; }

        [StringLength(100)]
        [Index(IsUnique = true)] 
        public string username { get; set; }

        [StringLength(100)]
        public string password {  get; set; }
        public override string ToString()
        {
            return username;
        }

    }

    
    }
