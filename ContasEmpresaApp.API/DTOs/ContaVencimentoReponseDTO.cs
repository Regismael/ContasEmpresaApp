namespace ContasEmpresaApp.API.DTOs
{
    public class ContaVencimentoReponseDTO
    {
          
        public Guid Id { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}

