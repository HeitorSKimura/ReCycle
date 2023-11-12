using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Application.Service.ApplicationServiceLogin;
using ReCycle.Domain.Service.LoginContextService;

namespace ReCycle.Application.Api.Controllers.CadastroContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly ApplicationServiceValidacaoLogin _loginService;

        public LoginController(ApplicationServiceValidacaoLogin loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("ValidarLogin")]
        public ActionResult<ValidacaoLoginService> ValidarLoginApplicationService(string email, string password)
        {
            return Ok(_loginService.ValidarLogin(email, password)); //Retornara um valor bool(true/false)
        }
    }
}
