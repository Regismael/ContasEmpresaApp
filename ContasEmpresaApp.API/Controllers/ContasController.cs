using ContasEmpresaApp.API.DTOs;
using ContasEmpresaApp.DOMAIN.Entities;
using ContasEmpresaApp.DOMAIN.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ContasEmpresaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IContaDomainService _contaDomainService;

        public ContasController(IContaDomainService contaDomainService)
        {
            _contaDomainService = contaDomainService;
        }

        [HttpDelete("pagar/{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var conta = _contaDomainService.ConsultarContaPorId(id);
                if (conta == null)
                {
                    return NotFound("Conta não encontrada.");
                }

                _contaDomainService.PagarConta(id);

                return Ok(conta);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("vencimento")]
        public ActionResult<IEnumerable> GetContasPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var contas = _contaDomainService.ConsultarContasPorPeriodo(dataInicio, dataFim);

                var response = contas.Select(conta => new ContaVencimentoReponseDTO
                {
                    Id = conta.Id,
                    Descricao = conta.Descricao,
                    Valor = conta.Valor,
                    DataVencimento = conta.DataVencimento,
                }).ToList();

                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("porid/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var conta = _contaDomainService.ConsultarContaPorId(id);

                if (conta == null)
                {
                    return NotFound("Conta não encontrada.");
                }

                return Ok(conta);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
