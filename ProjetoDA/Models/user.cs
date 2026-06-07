using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDA.Models {
    public class User {
        [Key] public int id { get; set; }

        [StringLength(100)]
        [Index(IsUnique = true)]
        public string username { get; set; }

        [StringLength(100)]
        public string password { get; set; }
        public override string ToString() {
            return username;
        }

    }


}
