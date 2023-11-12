using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository;

namespace ReCycle.Application.Api.Controllers.CadastroContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojaController : ControllerBase
    {
        readonly ILojaRepository _lojaRepository;

        public LojaController(ILojaRepository lojaRepository)
        {
            _lojaRepository = lojaRepository;
        }

        [HttpGet]
        public ActionResult<List<Loja>> Get()
        {
            return Ok(_lojaRepository.GetAllLoja());
        }
        [HttpGet("{id}")]
        public ActionResult<Loja> GetById(int id)
        {
            return Ok(_lojaRepository.GetByIdLoja(id));
        }
        [HttpPost]
        public ActionResult<Loja> PostLoja(LojaViewModel loja)
        {
            var retorno = _lojaRepository.InsertLoja(loja);
            return CreatedAtAction(nameof(GetById), new { id = retorno.LojaId }, retorno);
        }
        [HttpPut]
        public ActionResult<Loja> PutLoja(Loja loja)
        {
            _lojaRepository.PutLoja(loja);
            return Ok("Cliente Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Loja> DeleteLoja(int lojaId)
        {
            _lojaRepository.DeleteLoja(lojaId);
            return Ok("Loja Deletado com sucesso");
        }
    }
}
