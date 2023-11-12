using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.EnderecoContext;
using ReCycle.Infra.SqlServer.Interfaces.IEnderecoContextRepository;

namespace ReCycle.Application.Api.Controllers.EnderecoContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserEnderecoController : ControllerBase
    {
        readonly IUserEnderecoRepository _userEnderecoRepository;
        public UserEnderecoController(IUserEnderecoRepository userEnderecoRepository)
        {
            _userEnderecoRepository = userEnderecoRepository;
        }

        [HttpGet]
        public ActionResult<List<UserEndereco>> Get()
        {
            return Ok(_userEnderecoRepository.GetAllUserEndereco());
        }
        [HttpGet("{id}")]
        public ActionResult<UserEndereco> GetById(int id)
        {
            return Ok(_userEnderecoRepository.GetByIdUserEndereco(id));
        }
        [HttpPost]
        public ActionResult<UserEndereco> PostUserEndereco(int userId, int enderecoId)
        {
            UserEndereco userEnderecoIdSaved = _userEnderecoRepository.PostUserEndereco(userId, enderecoId);
            return CreatedAtAction(nameof(GetById), new { id = userEnderecoIdSaved.UserEnderecoId }, userEnderecoIdSaved);
        }
    }
}
