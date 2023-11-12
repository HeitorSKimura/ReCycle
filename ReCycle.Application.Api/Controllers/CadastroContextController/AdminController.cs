using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository;

namespace ReCycle.Application.Api.Controllers.CadastroContextController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly IAdminRepository _adminRepository;

        public AdminController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        [HttpGet]
        public ActionResult<List<Admin>> Get()
        {
            return Ok(_adminRepository.GetAllAdmin());
        }
        [HttpGet("{id}")]
        public ActionResult<Admin> GetById(int id)
        {
            return Ok(_adminRepository.GetByIdAdmin(id));
        }
        [HttpPost]
        public ActionResult<Admin> PostAdmin(AdminViewModel admin)
        {
            var retorno = _adminRepository.PostAdmin(admin);
            return CreatedAtAction(nameof(GetById), new { id = retorno.UserId }, retorno);
        }
        [HttpPut]
        public ActionResult<Admin> PutAdmin(Admin admin)
        {
            _adminRepository.PutAdmin(admin);
            return Ok("Cliente Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Admin> DeleteAdmin(int adminId)
        {
            _adminRepository.DeleteAdmin(adminId);
            return Ok("Admin Deletado com sucesso");
        }
    }
}
