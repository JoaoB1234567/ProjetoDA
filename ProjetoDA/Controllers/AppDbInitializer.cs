using System;
using System.Collections.Generic;
using System.Data.Entity;
using ProjetoDA.Models;

namespace ProjetoDA.Controllers
{
    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<ShoppingContext>
    {
        protected override void Seed(ShoppingContext context)
        {
            var Users = new List<User>
            {
                new User { Username = "admin", Password = "123" },
                new User { Username = "tomas", Password = "321" },
                new User { Username = "joao", Password = "321" },
                new User { Username = "luis", Password = "321" },
            };

            context.Users.AddRange(Users);

            var categorias = new List<TipoArtigo>
            {
                new TipoArtigo { Categoria = "Mercearia seca" },
                new TipoArtigo { Categoria = "Produtos de limpeza" },
                new TipoArtigo { Categoria = "Cuidados pessoais" },
                new TipoArtigo { Categoria = "Carnes frescas" },
                new TipoArtigo { Categoria = "Peixaria fresca" },
                new TipoArtigo { Categoria = "Frutas e legumes" },
                new TipoArtigo { Categoria = "Padaria e pastelaria" },
                new TipoArtigo { Categoria = "Congelados e ultracongelados" },
                new TipoArtigo { Categoria = "Bebidas não alcoólicas" },
                new TipoArtigo { Categoria = "Laticínios e derivados" },
                new TipoArtigo { Categoria = "Snacks e petiscos" }
            };

            context.Tipos.AddRange(categorias);

            var Artigos = new List<Artigo>
            {
                new Artigo { Nome = "Massa esparguete italiana", TipoArtigo = categorias[0] },
                new Artigo { Nome = "Detergente concentrado multiusos", TipoArtigo = categorias[1] },
                new Artigo { Nome = "Shampoo reparação intensiva", TipoArtigo = categorias[2] },
                new Artigo { Nome = "Carne de vaca fatiada", TipoArtigo = categorias[3] },
                new Artigo { Nome = "Filetes de bacalhau", TipoArtigo = categorias[4] },
                new Artigo { Nome = "Bananas da Madeira", TipoArtigo = categorias[5] },
                new Artigo { Nome = "Pão rústico de fermentação lenta", TipoArtigo = categorias[6] },
                new Artigo { Nome = "Pizza quatro queijos congelada", TipoArtigo = categorias[7] },
                new Artigo { Nome = "Sumo natural de laranja", TipoArtigo = categorias[8] },
                new Artigo { Nome = "Iogurte grego natural", TipoArtigo = categorias[9] },
                new Artigo { Nome = "Amendoins torrados salgados", TipoArtigo = categorias[10] }
            };

            context.Artigos.AddRange(Artigos);

            var Orcamentos = new List<Orcamento>
            {
                new Orcamento
                {
                    Mes = DateTime.Now,
                    ValorMaximo = 150m,
                    UserCriador = Users[0]
                }
            };

            for (int i = 1; i <= 10; i++)
            {
                Orcamentos.Add(new Orcamento
                {
                    Mes = new DateTime(DateTime.Now.Year, i, 1),
                    ValorMaximo = 180m + (i * 22m),
                    UserCriador = Users[0],
                    UserAlterador = Users[0]
                });
            }

            context.Orcamentos.AddRange(Orcamentos);

            var Compras = new List<Compra>
            {
                new Compra
                {
                    Nome = "Despensa semanal casa principal",
                    Estado = Estado.aberto,
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    UserCriador = Users[0]
                },
                new Compra
                {
                    Nome = "Reposição mensal congelados",
                    Estado = Estado.fechado,
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    UserCriador = Users[0]
                }
            };

            for (int i = 1; i <= 10; i++)
            {
                bool fechado = (i % 2 == 0);

                Compras.Add(new Compra
                {
                    Nome = $"Lista de abastecimento local {i}",
                    Estado = fechado ? Estado.fechado : Estado.aberto,
                    DataCriacao = DateTime.Now.AddDays(-i * 3),
                    DataAlteracao = DateTime.Now.AddDays(-i),
                    DataFechar = fechado ? DateTime.Now.AddDays(-i) : (DateTime?)null,
                    UserCriador = Users[i % 3],
                    UserFechou = fechado ? Users[0] : null
                });
            }

            context.Compras.AddRange(Compras);

            var ItensPrevistos = new List<ItemPrevisto>
            {
                new ItemPrevisto
                {
                    Compra = Compras[0],
                    Artigo = Artigos[0],
                    QuantidadePrevista = 3,
                    QuantidadeAdquirida = 0,
                    PrecoUnitario = 2.30m,
                    UserCriador = Users[0],
                    UserAlterador = Users[0]
                }
            };

            for (int i = 0; i < 10; i++)
            {
                ItensPrevistos.Add(new ItemPrevisto
                {
                    Compra = Compras[i + 2],
                    Artigo = Artigos[i + 1],
                    QuantidadePrevista = (i % 4) + 1,
                    QuantidadeAdquirida = Compras[i + 2].Estado == Estado.fechado ? ((i % 4) + 1) : 0,
                    PrecoUnitario = 1.80m + (i * 0.60m),
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    UserCriador = Users[0],
                    UserAlterador = Users[0]
                });
            }

            context.ItemCompras.AddRange(ItensPrevistos);

            var itensNaoPrevistos = new List<ItemNaoPrevisto>();

            for (int i = 0; i < 10; i++)
            {
                itensNaoPrevistos.Add(new ItemNaoPrevisto
                {
                    Compra = Compras[i + 2],
                    Artigo = Artigos[i % Artigos.Count],
                    QuantidadeAdquirida = 1 + (i % 3),
                    PrecoUnitario = 3.50m + i,
                    UserCriador = Users[0],
                    Observacoes = $"Aquisição pontual não planeada {i + 1}"
                });
            }

            context.ItemCompras.AddRange(itensNaoPrevistos);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}