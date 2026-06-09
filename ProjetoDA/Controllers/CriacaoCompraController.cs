using ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoDA.Controller
{
    public class CriacaoCompraController
    {
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

        public Compra ObterCabecalhoCompra(int compraId)
        {
            using (var context = new ShoppingContext())
            {
                return context.Compras.FirstOrDefault(c => c.Id == compraId);
            }
        }

        public List<ItemPrevisto> ObterItensPlaneados(int compraId)
        {
            if (compraId == 0) return new List<ItemPrevisto>();

            using (var context = new ShoppingContext())
            {
                return context.ItemCompras
                    .OfType<ItemPrevisto>()
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
                    var utilizadorAtual = context.Users.Find(utilizadorId);
                    var novaCompra = new Compra
                    {
                        Nome = string.IsNullOrWhiteSpace(nomeCompra) ? "Nova Lista Planeada" : nomeCompra,
                        Estado = Estado.aberto,
                        DataCriacao = DateTime.Now,
                        DataAlteracao = DateTime.Now,
                        UserCriador = utilizadorAtual
                    };
                    context.Compras.Add(novaCompra);
                }
                else
                {
                    var compraExistente = context.Compras.Find(compraId);
                    if (compraExistente != null)
                    {
                        compraExistente.Nome = string.IsNullOrWhiteSpace(nomeCompra) ? "Lista Planeada" : nomeCompra;
                        compraExistente.DataAlteracao = DateTime.Now;
                    }
                }
                context.SaveChanges();
            }
        }

        public ItemPrevisto ObterDetalhesItem(int itemId)
        {
            using (var context = new ShoppingContext())
            {
                return context.ItemCompras
                    .OfType<ItemPrevisto>()
                    .Include(i => i.Artigo)
                    .FirstOrDefault(i => i.Id == itemId);
            }
        }

        public int AdicionarItem(int compraId, string nomeCompra, int artigoId, int qtd, int utilizadorId)
        {
            using (var context = new ShoppingContext())
            {
                Compra compraAtual;

                if (compraId == 0)
                {
                    var utilizadorAtual = context.Users.Find(utilizadorId);
                    compraAtual = new Compra
                    {
                        Nome = nomeCompra,
                        Estado = Estado.aberto,
                        DataCriacao = DateTime.Now,
                        DataAlteracao = DateTime.Now,
                        UserCriador = utilizadorAtual
                    };
                    context.Compras.Add(compraAtual);
                    context.SaveChanges();
                    compraId = compraAtual.Id;
                }
                else
                {
                    compraAtual = context.Compras.Find(compraId);
                }

                var artigoSelecionado = context.Artigos.Find(artigoId);
                var utilizadorAcao = context.Users.Find(utilizadorId);

                var novoItem = new ItemPrevisto
                {
                    Compra = compraAtual,
                    Artigo = artigoSelecionado,
                    QuantidadePrevista = qtd,
                    QuantidadeAdquirida = 0,
                    PrecoUnitario = 0,
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    UserCriador = utilizadorAcao
                };

                context.ItemCompras.Add(novoItem);
                if (compraAtual != null) compraAtual.DataAlteracao = DateTime.Now;

                context.SaveChanges();

                return compraId;
            }
        }

        public void AtualizarItem(int itemId, int novoArtigoId, int novaQtd, int compraId)
        {
            using (var context = new ShoppingContext())
            {
                var itemParaAtualizar = context.ItemCompras.OfType<ItemPrevisto>().FirstOrDefault(i => i.Id == itemId);
                var novoArtigo = context.Artigos.Find(novoArtigoId);

                if (itemParaAtualizar != null && novoArtigo != null)
                {
                    itemParaAtualizar.Artigo = novoArtigo;
                    itemParaAtualizar.QuantidadePrevista = novaQtd;
                    itemParaAtualizar.DataAlteracao = DateTime.Now;

                    var compra = context.Compras.Find(compraId);
                    if (compra != null) compra.DataAlteracao = DateTime.Now;

                    context.SaveChanges();
                }
            }
        }

        public void RemoverItem(int itemId, int compraId)
        {
            using (var context = new ShoppingContext())
            {
                var itemParaRemover = context.ItemCompras.Find(itemId);
                if (itemParaRemover != null)
                {
                    context.ItemCompras.Remove(itemParaRemover);

                    var compra = context.Compras.Find(compraId);
                    if (compra != null) compra.DataAlteracao = DateTime.Now;

                    context.SaveChanges();
                }
            }
        }
    }
}
