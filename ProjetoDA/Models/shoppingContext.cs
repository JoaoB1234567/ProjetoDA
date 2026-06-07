using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace ProjetoDA.Models {
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ShoppingContext : DbContext {
        public ShoppingContext() : base("ShoppingContext") {
        }

        public DbSet<User> users { get; set; }
        public DbSet<TipoArtigo> tipos { get; set; }

        public DbSet<Artigo> artigos { get; set; }
        public DbSet<ItemCompra> itemCompras { get; set; }
        public DbSet<Compra> compras { get; set; }
        public DbSet<Orcamento> orcamentos { get; set; }
        public DbSet<ItemPrevisto> artigoPrevistos { get; set; }
        public DbSet<ItemNaoPrevisto> artigoNaoPrevistos { get; set; }

    }
}
