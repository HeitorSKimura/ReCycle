using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository;

namespace ReCycle.Application.Api.Controllers.CadastroContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescartanteController : ControllerBase
    {
        readonly IDescartanteRepository _descartanteRepository;

        public DescartanteController(IDescartanteRepository descartante)
        {
            _descartanteRepository = descartante;
        }

        [HttpGet]
        public ActionResult<List<Descartante>> Get()
        {
            return Ok(_descartanteRepository.GetAllDescartante());
        }
        [HttpGet("{id}")]
        public ActionResult<Descartante> GetById(int id)
        {
            return Ok(_descartanteRepository.GetByIdDescartante(id));
        }
        [HttpPost]
        public ActionResult<Descartante> PostDescartante(DescartanteViewModel descartante)
        {
            var retorno = _descartanteRepository.InsertDescartante(descartante);
            return CreatedAtAction(nameof(GetById), new { id = retorno.UserId }, retorno);
        }
        [HttpPut]
        public ActionResult<Descartante> PutDescartante(Descartante descartante)
        {
            _descartanteRepository.PutDescartante(descartante);
            return Ok("Cliente Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Descartante> DeleteDescartante(int descartanteId)
        {
            _descartanteRepository.DeleteDescartante(descartanteId);
            return Ok("Descartante Deletado com sucesso");
        }
    }
}
