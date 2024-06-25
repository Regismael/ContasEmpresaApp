using ContasEmpresaApp.DOMAIN.Entities;
using ContasEmpresaApp.DOMAIN.Interfaces;
using ContasEmpresaApp.DOMAIN.Interfaces.Repositories;
using ContasEmpresaApp.DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasEmpresaApp.DOMAIN.Services
{
    public class ContaDomainService : IContaDomainService
    {
        private readonly IContaRepository _contaRepository;

        public ContaDomainService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public Conta? ConsultarContaPorId(Guid id)
        {
            return _contaRepository.GetById(id);
        }

        public IEnumerable<Conta> ConsultarContasPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            return _contaRepository.GetByPeriodoDeVencimento(dataInicio, dataFim);
        }

        public void PagarConta(Guid id)
        {
            var conta = _contaRepository.GetById(id);

            if (conta == null)
            {
                throw new ArgumentException("ID não encontrado. Por favor, verifique.");
            }

            _contaRepository.Delete(id);
        }
    
    }
}
