using Microsoft.VisualBasic;
using ReCycle.Domain.Service.LoginContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Application.Service.ApplicationServiceLogin
{
    public class ApplicationServiceValidacaoLogin
    {
        readonly ValidacaoLoginService _loginService;
        public ApplicationServiceValidacaoLogin(ValidacaoLoginService loginService)
        {
            _loginService = loginService;
        }
        public bool ValidarLogin(string email, string password)
        {
            return _loginService.Validacao(email, password);
        }
    }
}
