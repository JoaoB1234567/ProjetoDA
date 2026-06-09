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

        // Additional helpers matching the IShopping sample
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
    }
}