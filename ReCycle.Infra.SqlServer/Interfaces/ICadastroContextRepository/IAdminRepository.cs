using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository
{
    public interface IAdminRepository
    {
        public List<Admin> GetAllAdmin();
        public Admin GetByIdAdmin(int id);
        public string GetEmailAdmin(string adminEmail);
        public string GetSenhaAdmin(string adminSenha);
        public Admin PostAdmin(AdminViewModel admin);
        public void PutAdmin(Admin admin);
        public void DeleteAdmin(int adminId);
    }
}
