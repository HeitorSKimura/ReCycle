using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.ConfigContext;
using ReCycle.Domain.ViewModel.ConfigContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.IConfigContextRepository;

namespace ReCycle.Application.Api.Controllers.ConfigContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        readonly IConfigRepository _configRepository;
        public ConfigController(IConfigRepository configRepository)
        {
            _configRepository = configRepository;
        }

        [HttpGet]
        public ActionResult<List<Config>> Get()
        {
            return Ok(_configRepository.GetAllConfig());
        }
        [HttpGet("{id}")]
        public ActionResult<Config> GetById(int id)
        {
            return Ok(_configRepository.GetByIdConfig(id));
        }
        [HttpPost]
        public ActionResult<Config> PostConfig(ConfigViewModel config)
        {

            var retorno = _configRepository.PostConfig(config);
            return CreatedAtAction(nameof(GetById), new { id = retorno.ConfigId }, retorno); ;
        }
    }
}
