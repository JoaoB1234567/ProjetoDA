using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDA.Models {
    public class User {
        [Key] public int Id { get; set; }

        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        [StringLength(100)]
        public string Password { get; set; }
        public override string ToString() {
            return Username;
        }

    }


}
