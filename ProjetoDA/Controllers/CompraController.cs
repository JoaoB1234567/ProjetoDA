using ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoDA.Controller
{
    public class CompraController
    {
        public List<Compra> ObterCompras()
        {
            using (var context = new ShoppingContext())
            {
                return context.Compras
                    .Include(c => c.ListaCompra)
                    .ToList();
            }
        }

        public Compra ObterCompraPorId(int id)
        {
            using (var context = new ShoppingContext())
            {
                return context.Compras
                    .Include(c => c.ListaCompra)
                    .FirstOrDefault(c => c.Id == id);
            }
        }

        public void CriarCompra(Compra compra)
        {
            using (var context = new ShoppingContext())
            {
                context.Compras.Add(compra);
                context.SaveChanges();
            }
        }

        public void RemoverCompra(int id)
        {
            using (var context = new ShoppingContext())
            {
                var compra = context.Compras.Find(id);
                if (compra != null)
                {
                    context.Compras.Remove(compra);
                    context.SaveChanges();
                }
            }
        }

        public List<Compra> ObterComprasAbertas()
        {
            using (var context = new ShoppingContext())
            {
                return context.Compras
                    .Include(c => c.UserCriador)
                    .Where(c => c.Estado == Estado.aberto)
                    .ToList();
            }
        }

        public string ObterNomeCompra(int compraId)
        {
            using (var context = new ShoppingContext())
            {
                var compra = context.Compras.Find(compraId);
                return compra != null ? compra.Nome : string.Empty;
            }
        }

        public List<TipoArtigo> ObterCategorias()
        {
            using (var context = new ShoppingContext())
            {
                return context.Tipos.ToList();
            }
        }

        public List<Artigo> ObterArtigosPorCategoria(int tipoId)
        {
            using (var context = new ShoppingContext())
            {
                return context.Artigos
                    .Where(a => a.TipoArtigoId == tipoId)
                    .ToList();
            }
        }

        public List<ItemCompra> ObterItensDaCompra(int compraId)
        {
            using (var context = new ShoppingContext())
            {
                return context.ItemCompras
                    .Include(i => i.Artigo)
                    .Where(i => i.Compra.Id == compraId)
                    .ToList();
            }
        }

        public void AtualizarItemAdquirido(int itemId, int qtdAdquirida, decimal precoUnitario, int compraId)
        {
            using (var context = new ShoppingContext())
            {
                var item = context.ItemCompras.Find(itemId);
                if (item != null)
                {
                    item.QuantidadeAdquirida = qtdAdquirida;
                    item.PrecoUnitario = precoUnitario;
                    item.DataAlteracao = DateTime.Now;

                    var compra = context.Compras.Find(compraId);
                    if (compra != null)
                        compra.DataAlteracao = DateTime.Now;

                    context.SaveChanges();
                }
            }
        }

        public void AdicionarItemExtra(int compraId, int artigoId, int qtd, decimal preco, string obs, int utilizadorId)
        {
            using (var context = new ShoppingContext())
            {
                var compraAtual = context.Compras.Find(compraId);
                var artigoSelecionado = context.Artigos.Find(artigoId);
                var utilizadorAcao = context.Users.Find(utilizadorId);

                var novoItemExtra = new ItemNaoPrevisto
                {
                    Compra = compraAtual,
                    Artigo = artigoSelecionado,
                    QuantidadeAdquirida = qtd,
                    PrecoUnitario = preco,
                    Observacoes = string.IsNullOrWhiteSpace(obs) ? "Compra por impulso" : obs,
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    UserCriador = utilizadorAcao
                };

                context.ItemCompras.Add(novoItemExtra);

                if (compraAtual != null)
                    compraAtual.DataAlteracao = DateTime.Now;

                context.SaveChanges();
            }
        }

        public decimal CalcularSaldoDisponivel(int compraId)
        {
            using (var context = new ShoppingContext())
            {
                int mesAtual = DateTime.Now.Month;
                int anoAtual = DateTime.Now.Year;

                var orcamentoMes = context.Orcamentos
                    .FirstOrDefault(o => o.Mes.Month == mesAtual && o.Mes.Year == anoAtual);

                decimal valorDisponivel = orcamentoMes != null ? orcamentoMes.ValorMaximo : 250.00m;

                decimal totalGastoCompra = context.ItemCompras
                    .Where(i => i.Compra.Id == compraId)
                    .Sum(i => (decimal?)(i.QuantidadeAdquirida * i.PrecoUnitario)) ?? 0;

                return valorDisponivel - totalGastoCompra;
            }
        }

        public void FecharCompra(int compraId, int utilizadorId)
        {
            using (var context = new ShoppingContext())
            {
                var compra = context.Compras.Find(compraId);
                var utilizadorFechou = context.Users.Find(utilizadorId);

                if (compra != null)
                {
                    compra.Estado = Estado.fechado;
                    compra.DataAlteracao = DateTime.Now;
                    compra.DataFechar = DateTime.Now;
                    compra.UserFechou = utilizadorFechou;

                    context.SaveChanges();
                }
            }
        }

        // ===========================
        // MÉTODOS NECESSÁRIOS PARA O FORM
        // ===========================

        public Compra ObterCabecalhoCompra(int compraId)
        {
            using (var context = new ShoppingContext())
            {
                return context.Compras
                    .FirstOrDefault(c => c.Id == compraId);
            }
        }

        public int AdicionarItem(int compraId, string nomeCompra, int artigoId, int quantidadePrevista, int utilizadorId)
        {
            using (var context = new ShoppingContext())
            {
                Compra compra;

                if (compraId == 0)
                {
                    compra = new Compra
                    {
                        Nome = nomeCompra,
                        Estado = Estado.aberto,
                        DataCriacao = DateTime.Now,
                        DataAlteracao = DateTime.Now,
                        UserCriador = context.Users.Find(utilizadorId)
                    };

                    context.Compras.Add(compra);
                    context.SaveChanges();

                    compraId = compra.Id;
                }
                else
                {
                    compra = context.Compras.Find(compraId);
                }

                var artigo = context.Artigos.Find(artigoId);

                var item = new ItemCompra
                {
                    Compra = compra,
                    Artigo = artigo,
                    QuantidadePrevista = quantidadePrevista,
                    QuantidadeAdquirida = 0,
                    PrecoUnitario = 0,
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    UserCriador = context.Users.Find(utilizadorId)
                };

                context.ItemCompras.Add(item);

                context.SaveChanges();

                return compraId;
            }
        }

        public ItemCompra ObterDetalhesItem(int itemId)
        {
            using (var context = new ShoppingContext())
            {
                return context.ItemCompras
                    .Include(i => i.Artigo)
                    .Include(i => i.Artigo.TipoArtigo)
                    .FirstOrDefault(i => i.Id == itemId);
            }
        }

        public void AtualizarItem(int itemId, int artigoId, int quantidadePrevista, int compraId)
        {
            using (var context = new ShoppingContext())
            {
                var item = context.ItemCompras
                    .Include(i => i.Compra)
                    .FirstOrDefault(i => i.Id == itemId);

                if (item == null)
                    return;

                item.Artigo = context.Artigos.Find(artigoId);
                item.QuantidadePrevista = quantidadePrevista;
                item.DataAlteracao = DateTime.Now;

                var compra = context.Compras.Find(compraId);

                if (compra != null)
                    compra.DataAlteracao = DateTime.Now;

                context.SaveChanges();
            }
        }

        public void RemoverItem(int itemId, int compraId)
        {
            using (var context = new ShoppingContext())
            {
                var item = context.ItemCompras.Find(itemId);

                if (item != null)
                {
                    context.ItemCompras.Remove(item);

                    var compra = context.Compras.Find(compraId);

                    if (compra != null)
                        compra.DataAlteracao = DateTime.Now;

                    context.SaveChanges();
                }
            }
        }

        public List<ItemCompra> ObterItensPlaneados(int compraId)
        {
            using (var context = new ShoppingContext())
            {
                return context.ItemCompras
                    .Include(i => i.Artigo)
                    .Where(i => i.Compra.Id == compraId)
                    .ToList();
            }
        }

        public void GuardarCompra(int compraId, string nomeCompra, int utilizadorId)
        {
            using (var context = new ShoppingContext())
            {
                if (compraId == 0)
                {
                    var compra = new Compra
                    {
                        Nome = nomeCompra,
                        Estado = Estado.aberto,
                        DataCriacao = DateTime.Now,
                        DataAlteracao = DateTime.Now,
                        UserCriador = context.Users.Find(utilizadorId)
                    };

                    context.Compras.Add(compra);
                }
                else
                {
                    var compra = context.Compras.Find(compraId);

                    if (compra != null)
                    {
                        compra.Nome = nomeCompra;
                        compra.DataAlteracao = DateTime.Now;
                    }
                }

                context.SaveChanges();
            }
        }
    }
}