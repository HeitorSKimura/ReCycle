using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.ViewModel.MapaColetaContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.IMapaColetaContextRepository;

namespace ReCycle.Application.Api.Controllers.MapaColetaContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaColetaController : ControllerBase
    {
        readonly IAreaColetaRepository _areaColetaRepository;
        public AreaColetaController(IAreaColetaRepository areaColetaRepository)
        {
            _areaColetaRepository = areaColetaRepository;
        }

        [HttpGet]
        public ActionResult<List<AreaColeta>> Get()
        {
            return Ok(_areaColetaRepository.GetAllAreaColeta());
        }
        [HttpGet("{id}")]
        public ActionResult<AreaColeta> GetById(int id)
        {
            return Ok(_areaColetaRepository.GetByIdAreaColeta(id));
        }
        [HttpPost]
        public ActionResult<AreaColeta> PostAreaColeta(AreaColetaViewModel areaColeta)
        {
            var retorno = _areaColetaRepository.PostAreaColeta(areaColeta);
            return CreatedAtAction(nameof(GetById), new { id = retorno.AreaColetaId }, retorno);
        }
        [HttpPut]
        public ActionResult<AreaColeta> PutAreaColeta(AreaColeta areaColeta)
        {
            _areaColetaRepository.PutAreaColeta(areaColeta);
            return Ok("Area de Coleta Atualizado com sucesso!");
        }
    }
}
