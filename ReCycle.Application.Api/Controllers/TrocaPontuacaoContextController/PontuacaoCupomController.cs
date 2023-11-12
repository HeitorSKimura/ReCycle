using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository;

namespace ReCycle.Application.Api.Controllers.TrocaPontuacaoContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoCupomController : ControllerBase
    {
        readonly IPontuacaoCupomRepository _pontuacaoCupomRepository;
        public PontuacaoCupomController(IPontuacaoCupomRepository pontuacaoCupomRepository)
        {
            _pontuacaoCupomRepository = pontuacaoCupomRepository;
        }

        [HttpGet]
        public ActionResult<List<PontuacaoCupom>> Get()
        {
            return Ok(_pontuacaoCupomRepository.GetAllPontuacaoCupom());
        }
        [HttpGet("{id}")]
        public ActionResult<PontuacaoCupom> GetById(int id)
        {
            return Ok(_pontuacaoCupomRepository.GetByIdPontuacaoCupom(id));
        }
        [HttpPost]
        public ActionResult<PontuacaoCupom> PostPontuacaoCupom(int pontuacaoId, int cupomId)
        {
            PontuacaoCupom pontuacaoCupomIsSaved = _pontuacaoCupomRepository.PostPontuacaoCupom(pontuacaoId, cupomId);
            return CreatedAtAction(nameof(GetById), new { id = pontuacaoCupomIsSaved.PontuacaoCupomId }, pontuacaoCupomIsSaved);
        }
    }
}
