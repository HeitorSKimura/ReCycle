using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.EnderecoContext;
using ReCycle.Domain.ViewModel.EnderecoContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.IEnderecoContextRepository;

namespace ReCycle.Application.Api.Controllers.EnderecoContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        readonly IEnderecoRepository _enderecoRepository;
        public EnderecoController(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        [HttpGet]
        public ActionResult<List<Endereco>> Get()
        {
            return Ok(_enderecoRepository.GetAllEndereco());
        }
        [HttpGet("{id}")]
        public ActionResult<Endereco> GetById(int id)
        {
            return Ok(_enderecoRepository.GetByIdEndereco(id));
        }
        [HttpPost]
        public ActionResult<Endereco> PostEndereco(EnderecoViewModel endereco)
        {
            var retorno = _enderecoRepository.PostEndereco(endereco);
            return CreatedAtAction(nameof(GetById), new { id = retorno.EnderecoId }, retorno);
        }
        [HttpPut]
        public ActionResult<Endereco> PutEndereco(Endereco endereco)
        {
            _enderecoRepository.PutEndereco(endereco);
            return Ok("Endereco Atualizado com sucesso!");
        }
    }
}
