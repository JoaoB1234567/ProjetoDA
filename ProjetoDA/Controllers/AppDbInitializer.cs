using System;
using System.Collections.Generic;
using System.Data.Entity;
using ProjetoDA.Models;

namespace ProjetoDA.Controllers {
    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<ShoppingContext> {
        protected override void Seed(ShoppingContext context) {
            var Users = new List<User>
            {
                new User { Username = "admin", Password = "123" },
                new User { Username = "tomas", Password = "321" },
                new User { Username = "joao", Password = "321" },
                new User { Username = "luis", Password = "321" },
            };
            context.Users.AddRange(Users);

            //var categorias = new List<TipoArtigo>
            //{
            //    new TipoArtigo { Categoria = "Comida" },
            //    new TipoArtigo { Categoria = "Higiene Pessoal" },
            //    new TipoArtigo { Categoria = "Limpeza Doméstica" },
            //    new TipoArtigo { Categoria = "Talho" },
            //    new TipoArtigo { Categoria = "Peixaria" },
            //    new TipoArtigo { Categoria = "Frutaria" },
            //    new TipoArtigo { Categoria = "Padaria / Pastelaria" },
            //    new TipoArtigo { Categoria = "Congelados" },
            //    new TipoArtigo { Categoria = "Bebidas" },
            //    new TipoArtigo { Categoria = "Laticínios" },
            //    new TipoArtigo { Categoria = "Snacks" }
            //};
            //context.Tipos.AddRange(categorias);

            //var Artigos = new List<Artigo>
            //{
            //    new Artigo { Nome = "Arroz", TipoArtigo = categorias[0] },
            //    new Artigo { Nome = "Gel de Banho Doce", TipoArtigo = categorias[1] },
            //    new Artigo { Nome = "Lixívia Perfumada", TipoArtigo = categorias[2] },
            //    new Artigo { Nome = "Bife de Peru", TipoArtigo = categorias[3] },
            //    new Artigo { Nome = "Posta de Salmão", TipoArtigo = categorias[4] },
            //    new Artigo { Nome = "Maçã Riscadinha", TipoArtigo = categorias[5] },
            //    new Artigo { Nome = "Pão de Forma Integral", TipoArtigo = categorias[6] },
            //    new Artigo { Nome = "Douradinhos 15 un.", TipoArtigo = categorias[7] },
            //    new Artigo { Nome = "Água Mineral 1.5L", TipoArtigo = categorias[8] },
            //    new Artigo { Nome = "Leite Meio Gordo", TipoArtigo = categorias[9] },
            //    new Artigo { Nome = "Batatas Fritas", TipoArtigo = categorias[10] }
            //};
            //context.Artigos.AddRange(Artigos);

            //var Orcamentos = new List<Orcamento>
            //{
            //    new Orcamento { mes = DateTime.Now, UserCriador = Users[0], valor_max = 1.1m }
            //};
            //for (int i = 1; i <= 10; i++) {
            //    Orcamentos.Add(new Orcamento {
            //        mes = new DateTime(DateTime.Now.Year, i, 1),
            //        valor_max = 200m + (i * 15.5m),
            //        UserCriador = Users[0],
            //        UserAlterador = Users[0]
            //    });
            //}
            //context.Orcamentos.AddRange(Orcamentos);

            //var Compras = new List<Compra>
            //{
            //    new Compra { Nome = "Compras Mensais Continente", Estado = Estado.aberto, DataCriacao = DateTime.Now, DataAlteracao = DateTime.Now, UserCriador = Users[0] },
            //    new Compra { Nome = "Compras Mensais FECHADO Continente", Estado = Estado.fechado, DataCriacao = DateTime.Now, DataAlteracao = DateTime.Now, UserCriador = Users[0] }
            //};
            //for (int i = 1; i <= 10; i++) {
            //    bool isFechado = (i % 2 == 0);
            //    Compras.Add(new Compra {
            //        Nome = $"Compra Adicional {i}",
            //        Estado = isFechado ? Estado.fechado : Estado.aberto,
            //        DataCriacao = DateTime.Now.AddDays(-i * 5),
            //        DataAlteracao = DateTime.Now.AddDays(-i * 2),
            //        DataFechar = isFechado ? (DateTime?)DateTime.Now.AddDays(-i * 1) : null,
            //        UserCriador = Users[i % 3 + 1],
            //        UserFechou = isFechado ? Users[0] : null
            //    });
            //}
            //context.Compras.AddRange(Compras);

            //var ItensPrevistos = new List<ArtigoPrevisto>
            //{
            //    new ArtigoPrevisto { Compra = Compras[0], Artigo = Artigos[0], qntPrevista = 4, quantidadeAdquirida = 0, precoUnitario = 1.10m, UserCriador = Users[0], UserAlterador = Users[0] }
            //};
            //for (int i = 0; i < 10; i++) {
            //    ItensPrevistos.Add(new ArtigoPrevisto {
            //        Compra = Compras[i + 2],
            //        Artigo = Artigos[i + 1],
            //        qntPrevista = (i % 3) + 2,
            //        quantidadeAdquirida = Compras[i + 2].Estado == Estado.fechado ? ((i % 3) + 2) : 0,
            //        precoUnitario = 1.10m + (i * 0.45m),
            //        DataCriacao = DateTime.Now,
            //        DataAlteracao = DateTime.Now,
            //        UserCriador = Users[0],
            //        UserAlterador = Users[0]
            //    });
            //}
            //context.ItemCompras.AddRange(ItensPrevistos);

            //var itensNaoPrevistos = new List<ArtigoNaoPrevisto>();
            //for (int i = 0; i < 10; i++) {
            //    itensNaoPrevistos.Add(new ArtigoNaoPrevisto {
            //        Compra = Compras[i + 2],
            //        Artigo = Artigos[(i + 2) % Artigos.Count],
            //        descricao = $"Desejo do momento {i + 1}",
            //        quantidadeAdquirida = 1 + (i % 2),
            //        precoUnitario = 2.00m + (i * 1.20m),
            //        DataCriacao = DateTime.Now,
            //        DataAlteracao = DateTime.Now,
            //        UserCriador = Users[1],
            //        UserAlterador = Users[1]
            //    });
            //}
            //context.ItemCompras.AddRange(itensNaoPrevistos);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
