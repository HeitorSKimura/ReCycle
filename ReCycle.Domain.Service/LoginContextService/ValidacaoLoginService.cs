using ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.Service.LoginContextService
{
    public class ValidacaoLoginService
    {
        readonly IAdminRepository _adminRepository;
        readonly IColetorRepository _coletorRepository;
        readonly IDescartanteRepository _descartanteRepository;
        readonly ILojaRepository _lojaRepository;
        public ValidacaoLoginService(IAdminRepository adminRepository, IColetorRepository coletorRepository, IDescartanteRepository descartanteRepository, ILojaRepository lojaRepository)
        {
            _adminRepository = adminRepository;
            _coletorRepository = coletorRepository;
            _descartanteRepository = descartanteRepository;
            _lojaRepository = lojaRepository;
        }
        public bool Validacao(string email, string senha)
        {
            var adminEmail = _adminRepository.GetEmailAdmin(email);
            var adminSenha = _adminRepository.GetSenhaAdmin(senha);

            var coletorEmail = _coletorRepository.GetEmailColetor(email);
            var coletorSenha = _coletorRepository.GetSenhaColetor(senha);

            var descartanteEmail = _descartanteRepository.GetEmailDescartante(email);
            var descartanteSenha = _descartanteRepository.GetSenhaDescartante(senha);

            var lojaEmail = _lojaRepository.GetEmailLoja(email);
            var lojaSenha = _lojaRepository.GetSenhaLoja(senha);

            if(adminEmail != null && adminSenha != null)
            {
                if(adminEmail == email && adminSenha == senha)
                {
                    return true;
                }
                else { return false; }
            }
            else if(coletorEmail != null && coletorSenha != null)
            {
                if(coletorEmail == email && coletorSenha == senha)
                {
                    return true;
                }
                else { return false; }
            }
            else if(descartanteEmail != null && descartanteSenha != null)
            {
                if(descartanteEmail == email && descartanteSenha == senha)
                {
                    return true;
                }
                else { return false; }
            }
            else if(lojaEmail != null && lojaSenha != null)
            {
                if(lojaEmail == email && lojaSenha == senha)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
    }
}
