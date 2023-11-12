using Microsoft.EntityFrameworkCore;
using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Repositories.CadastroContextRepository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly SqlServerContext _context;

        public AdminRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<Admin> GetAllAdmin()
        {
            return _context.Admins.ToList();
        }

        public Admin GetByIdAdmin(int id)
        {
            return _context.Admins.Find(id);
        }
        public string GetEmailAdmin(string adminEmail)
        {
            var admin = _context.Admins.FirstOrDefault(i => i.UserEmail == adminEmail);
            if(admin != null)
            {
                return admin.UserEmail;
            }
            else { return null; }
        }
        public string GetSenhaAdmin(string adminSenha)
        {
            var admin = _context.Admins.FirstOrDefault(i => i.UserSenha == adminSenha);
            if (admin != null)
            {
                return admin.UserSenha;
            }
            else { return null; }
        }
        public Admin PostAdmin(AdminViewModel admin)
        {
            var adminRepository = new Admin
            {
                UserNomeCompleto = admin.UserNomeCompleto,
                CPFRG = admin.CPFRG,
                UserEmail = admin.UserEmail,
                UserSenha = admin.UserSenha,
                UserTelefone = admin.UserTelefone,
                UserAtivo = admin.UserAtivo,
                UserRegistro = admin.UserRegistro,
            };
            _context.Admins.Add(adminRepository);
            _context.SaveChanges();
            return adminRepository;
        }
        public void PutAdmin(Admin admin)
        {
            _context.Entry(admin).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteAdmin(int adminId)
        {
            var admin = _context.Admins.First(i => i.UserId == adminId);
            admin.UserAtivo = false;
            _context.SaveChanges();
        }
    }
}
