using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace IShopping.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class shoppingContext: DbContext
    {
        public shoppingContext() : base("ShoppingContext")
        {
            this.Database.Log = s => System.IO.File.AppendAllText(@"C:\Users\User\Desktop\IShopping\ef6_sql.log", s);
        }

        public DbSet<user> users { get; set; }
        public DbSet<tipoArtigo> tipos { get; set; }

        public DbSet<Artigo> artigos { get; set; }
        public DbSet<itemCompra> itemCompras { get; set; }
        public DbSet<Compra> compras { get; set; }
        public DbSet<orcamento> orcamentos { get; set; }
        public DbSet<artigoPrevisto> artigoPrevistos { get; set; }
        public DbSet<artigoNaoPrevisto> artigoNaoPrevistos { get; set; }

    }
}
