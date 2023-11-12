using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Domain.ViewModel.TrocaPontuacaoViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository;

namespace ReCycle.Application.Api.Controllers.TrocaPontuacaoContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoController : ControllerBase
    {
        readonly IPontuacaoRepository _pontuacaoRepository;
        public PontuacaoController(IPontuacaoRepository pontuacaoRepository)
        {
            _pontuacaoRepository = pontuacaoRepository;
        }

        [HttpGet]
        public ActionResult<List<Pontuacao>> Get()
        {
            return Ok(_pontuacaoRepository.GetAllPontuacao());
        }
        [HttpGet("{id}")]
        public ActionResult<Pontuacao> GetById(int id)
        {
            return Ok(_pontuacaoRepository.GetByIdPontuacao(id));
        }
        [HttpPost]
        public ActionResult<Pontuacao> PostPontuacao(PontuacaoViewModel pontuacao)
        {
            var retorno = _pontuacaoRepository.PostPontuacao(pontuacao);
            return CreatedAtAction(nameof(GetById), new { id = retorno.PontuacaoId }, retorno);
        }
        [HttpPut]
        public ActionResult<Pontuacao> PutPontuacao(Pontuacao pontuacao)
        {
            _pontuacaoRepository.PutPontuacao(pontuacao);
            return Ok("Pontuacao Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Pontuacao> DeletePontuacao(int pontuacaoId)
        {
            _pontuacaoRepository.NullPontuacao(pontuacaoId);
            return Ok("Pontuacao Negada com sucesso");
        }
    }
}
