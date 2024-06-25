namespace ContasEmpresaApp.API.DTOs
{
    public class ContaPagamentoReponseDTO
    {
        public Guid Id { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataHoraPagamento { get; set; }
    }
}
