using ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoDA.Controller
{
    public class CompraPlaneamentoDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime? Data_Alteracao { get; set; }
        public string Criador { get; set; }
    }

    public class PlaneamentoController
    {
        public List<CompraPlaneamentoDTO> ObterListaCompras(string filtro)
        {
            using (var context = new ShoppingContext())
            {
                var query = context.Compras.Include(c => c.UserCriador).AsQueryable();

                if (!string.IsNullOrEmpty(filtro) && filtro != "Todas")
                {
                    if (filtro == "Abertas")
                    {
                        query = query.Where(c => c.Estado == Estado.aberto);
                    }
                    else if (filtro == "Fechadas")
                    {
                        query = query.Where(c => c.Estado == Estado.fechado);
                    }
                }

                return query.Select(c => new CompraPlaneamentoDTO
                {
                    ID = c.Id,
                    Nome = c.Nome,
                    Estado = c.Estado.ToString(),
                    Data_Criacao = c.DataCriacao,
                    Data_Alteracao = c.DataAlteracao,
                    Criador = c.UserCriador != null ? c.UserCriador.Username : "Desconhecido"
                }).ToList();
            }
        }
    }
}
