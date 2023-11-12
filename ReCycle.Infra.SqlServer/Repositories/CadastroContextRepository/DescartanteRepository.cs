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
    public class DescartanteRepository : IDescartanteRepository
    {
        private readonly SqlServerContext _context;

        public DescartanteRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<Descartante> GetAllDescartante()
        {
            return _context.Descartantes.ToList();
        }
        public Descartante GetByIdDescartante(int id)
        {
            return _context.Descartantes.Find(id);
        }
        public string GetEmailDescartante(string descartanteEmail)
        {
            var descartante = _context.Descartantes.FirstOrDefault(i => i.UserEmail == descartanteEmail);
            if(descartante != null)
            {
                return descartante.UserEmail;
            }
            else { return null; }
        }
        public string GetSenhaDescartante(string descartanteSenha)
        {
            var descartante = _context.Descartantes.FirstOrDefault(i => i.UserSenha == descartanteSenha);
            if(descartante != null)
            {
                return descartante.UserSenha;
            }
            else { return null; }
        }
        public Descartante InsertDescartante(DescartanteViewModel descartante)
        {
            var descartanteRepository = new Descartante
            {
                UserNomeCompleto = descartante.UserNomeCompleto,
                CPFRG = descartante.CPFRG,
                UserEmail = descartante.UserEmail,
                UserSenha = descartante.UserSenha,
                UserTelefone = descartante.UserTelefone,
                UserAtivo = descartante.UserAtivo,
                UserRegistro = descartante.UserRegistro,
            };
            _context.Descartantes.Add(descartanteRepository);
            _context.SaveChanges();
            return descartanteRepository;
        }
        public void PutDescartante(Descartante descartante)
        {
            _context.Entry(descartante).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteDescartante(int descartanteId)
        {
            var descartante = _context.Descartantes.First(i => i.UserId == descartanteId);
            descartante.UserAtivo = false;
            _context.SaveChanges();
        }
    }
}
