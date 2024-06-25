using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasEmpresaApp.DOMAIN.Entities
{
    public class Conta
    {
        public Guid Id { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataHoraPagamento { get; set; }
    }
}
