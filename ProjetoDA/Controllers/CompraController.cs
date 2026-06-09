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
                return context.Artigos.Where(a => a.TipoArtigoId == tipoId).ToList();
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
                    if (compra != null) compra.DataAlteracao = DateTime.Now;

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
                if (compraAtual != null) compraAtual.DataAlteracao = DateTime.Now;

                context.SaveChanges();
            }
        }

        public decimal CalcularSaldoDisponivel(int compraId)
        {
            using (var context = new ShoppingContext())
            {
                int mesAtual = DateTime.Now.Month;
                int anoAtual = DateTime.Now.Year;

                var orcamentoMes = context.Orcamentos.FirstOrDefault(o => o.Mes.Month == mesAtual && o.Mes.Year == anoAtual);
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
    }
}
