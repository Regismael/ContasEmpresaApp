using ContasEmpresaApp.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasEmpresaApp.DOMAIN.Interfaces.Repositories
{
    public interface IContaRepository
    {
        void Delete(Guid id);
        Conta? GetById(Guid id);
        IEnumerable<Conta> GetByPeriodoDeVencimento(DateTime dataInicio, DateTime dataFim);
    }
}
