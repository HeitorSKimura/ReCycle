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
    public class ColetorRepository : IColetorRepository
    {
        private readonly SqlServerContext _context;

        public ColetorRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<Coletor> GetAllColetor()
        {
            return _context.Coletores.ToList();
        }
        public Coletor GetByIdColetores(int id)
        {
            return _context.Coletores.Find(id);
        }
        public string GetEmailColetor(string coletorEmail)
        {
            var coletor = _context.Coletores.FirstOrDefault(i => i.UserEmail == coletorEmail);
            if (coletor != null)
            {
                return coletor.UserEmail;
            }
            else { return null; }
        }
        public string GetSenhaColetor(string coletorSenha)
        {
            var coletor= _context.Coletores.FirstOrDefault(i => i.UserSenha == coletorSenha);
            if (coletor != null)
            {
                return coletor.UserSenha;
            }
            else { return null; }
        }
        public Coletor InsertColetor(ColetorViewModel coletor)
        {
            var coletorRepository = new Coletor
            {
                UserNomeCompleto = coletor.UserNomeCompleto,
                CPFRG = coletor.CPFRG,
                UserEmail = coletor.UserEmail,
                UserSenha = coletor.UserSenha,
                UserTelefone = coletor.UserTelefone,
                UserAtivo = coletor.UserAtivo,
                UserRegistro = coletor.UserRegistro,
            };
            _context.Coletores.Add(coletorRepository);
            _context.SaveChanges();
            return coletorRepository;
        }
        public void PutColetor(Coletor coletor)
        {
            _context.Entry(coletor).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteColetor(int coletorId)
        {
            var coletor = _context.Coletores.First(i => i.UserId == coletorId);
            coletor.UserAtivo = false;
            _context.SaveChanges();
        }
    }
}
