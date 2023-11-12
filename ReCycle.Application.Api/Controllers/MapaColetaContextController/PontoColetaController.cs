using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.ViewModel.MapaColetaContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.IMapaColetaContextRepository;

namespace ReCycle.Application.Api.Controllers.MapaColetaContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontoColetaController : ControllerBase
    {
        readonly IPontoColetaRepository _pontoColetaRepository;
        public PontoColetaController(IPontoColetaRepository pontoColetaRepository)
        {
            _pontoColetaRepository = pontoColetaRepository;
        }

        [HttpGet]
        public ActionResult<List<PontoColeta>> Get()
        {
            return Ok(_pontoColetaRepository.GetAllPontoColeta());
        }
        [HttpGet("{id}")]
        public ActionResult<PontoColeta> GetById(int id)
        {
            return Ok(_pontoColetaRepository.GetByIdPontoColeta(id));
        }
        [HttpPost]
        public ActionResult<PontoColeta> PostAdmin(PontoColetaViewModel pontoColeta)
        {
            var retorno = _pontoColetaRepository.PostPontoColeta(pontoColeta);
            return CreatedAtAction(nameof(GetById), new { id = retorno.PontoColetaId }, retorno);
        }
        [HttpPut]
        public ActionResult<PontoColeta> PutPontoColeta(PontoColeta pontoColeta)
        {
            _pontoColetaRepository.PutPontoColeta(pontoColeta);
            return Ok("Ponto de Coleta Atualizado com sucesso!");
        }
    }
}
