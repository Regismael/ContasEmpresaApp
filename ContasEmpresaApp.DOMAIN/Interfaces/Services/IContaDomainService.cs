using ContasEmpresaApp.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasEmpresaApp.DOMAIN.Interfaces.Services
{
    public interface IContaDomainService
    {
        void PagarConta(Guid id);
        Conta? ConsultarContaPorId(Guid id);
        IEnumerable<Conta> ConsultarContasPorPeriodo(DateTime dataInicio, DateTime dataFim);
    }
}
