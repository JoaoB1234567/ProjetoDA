using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace ProjetoDA.Models {
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ShoppingContext : DbContext {
        public ShoppingContext() : base("ShoppingContext") {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TipoArtigo> Tipos { get; set; }

        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<ItemCompra> ItemCompras { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<ItemPrevisto> ArtigoPrevistos { get; set; }
        public DbSet<ItemNaoPrevisto> ArtigoNaoPrevistos { get; set; }

    }
}
