using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository;

namespace ReCycle.Application.Api.Controllers.CadastroContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColetorController : ControllerBase
    {
        readonly IColetorRepository _coletorRepository;

        public ColetorController(IColetorRepository coletorRepository)
        {
            _coletorRepository = coletorRepository;
        }

        [HttpGet]
        public ActionResult<List<Coletor>> Get()
        {
            return Ok(_coletorRepository.GetAllColetor());
        }
        [HttpGet("{id}")]
        public ActionResult<Coletor> GetById(int id)
        {
            return Ok(_coletorRepository.GetByIdColetores(id));
        }
        [HttpPost]
        public ActionResult<Coletor> PostColetor(ColetorViewModel coletor)
        {
            var retorno = _coletorRepository.InsertColetor(coletor);
            return CreatedAtAction(nameof(GetById), new { id = retorno.UserId }, retorno);
        }
        [HttpPut]
        public ActionResult<Coletor> PutColetor(Coletor coletor)
        {
            _coletorRepository.PutColetor(coletor);
            return Ok("Cliente Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Coletor> DeleteColetor(int coletorId)
        {
            _coletorRepository.DeleteColetor(coletorId);
            return Ok("Coletor Deletado com sucesso");
        }
    }
}
