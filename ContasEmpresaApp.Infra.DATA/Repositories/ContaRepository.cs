using ContasEmpresaApp.DOMAIN.Entities;
using ContasEmpresaApp.DOMAIN.Interfaces.Repositories;
using ContasEmpresaApp.Infra.DATA.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ContasEmpresaApp.Infra.DATA.Repositories
{
    public class ContaRepository : IContaRepository
    {
        public void Delete(Guid id)
        {
            using(var context = new DataContext())
            {
                var entity = context.Set<Conta>().Find(id);
                if (entity == null)
                {
                    throw new Exception("Conta não encontrada.");
                }

                context.Set<Conta>().Remove(entity);
                context.SaveChanges();

                entity.DataHoraPagamento = DateTime.Now; 
                context.SaveChanges();


            }
        } 

        public Conta? GetById(Guid id)
        {
            using(var context = new DataContext())
            {
                return context.Set<Conta>()
                    .Where( c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<Conta> GetByPeriodoDeVencimento(DateTime dataInicio, DateTime dataFim)
        {
            using (var context = new DataContext())
            {
                return context.Set<Conta>()
                    .Where(c => c.DataVencimento >= dataInicio && c.DataVencimento <= dataFim)
                    .ToList();
            }
        }
    }
}
