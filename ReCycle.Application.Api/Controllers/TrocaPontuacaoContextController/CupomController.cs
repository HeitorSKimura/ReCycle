using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Domain.ViewModel.TrocaPontuacaoViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository;

namespace ReCycle.Application.Api.Controllers.TrocaPontuacaoContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupomController : ControllerBase
    {
        readonly ICupomRepository _cupomRepository;
        public CupomController(ICupomRepository cupomRepository)
        {
            _cupomRepository = cupomRepository;
        }

        [HttpGet]
        public ActionResult<List<Cupom>> Get()
        {
            return Ok(_cupomRepository.GetAllCupom());
        }
        [HttpGet("{id}")]
        public ActionResult<Cupom> GetById(int id)
        {
            return Ok(_cupomRepository.GetByIdCupom(id));
        }
        [HttpPost]
        public ActionResult<Cupom> PostCupom(CupomViewModel cupom)
        {
            var retorno = _cupomRepository.PostCupom(cupom);
            return CreatedAtAction(nameof(GetById), new { id = retorno.CupomId }, retorno);
        }
        [HttpPut]
        public ActionResult<Cupom> PutCupom(Cupom cupom)
        {
            _cupomRepository.PutCupom(cupom);
            return Ok("Cupom Atualizado com sucesso!");
        }
    }
}
