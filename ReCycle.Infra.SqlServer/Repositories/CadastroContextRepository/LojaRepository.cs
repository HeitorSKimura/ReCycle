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
    public class LojaRepository : ILojaRepository
    {
        private readonly SqlServerContext _context;
        public LojaRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<Loja> GetAllLoja()
        {
            return _context.Lojas.ToList();
        }
        public Loja GetByIdLoja(int id)
        {
            return _context.Lojas.Find(id);
        }
        public string GetEmailLoja(string lojaEmail)
        {
            var loja = _context.Lojas.FirstOrDefault(i => i.Email == lojaEmail);
            if(loja != null)
            {
                return loja.Email;
            }
            else { return null; }
        }
        public string GetSenhaLoja(string lojaSenha)
        {
            var loja = _context.Lojas.FirstOrDefault(i => i.Senha == lojaSenha);
            if(loja != null)
            {
                return loja.Senha;
            }
            else { return null; }
        }
        public Loja InsertLoja(LojaViewModel loja)
        {
            var lojaRepository = new Loja
            {
                NomeFicticio = loja.NomeFicticio,
                RazaoSocial = loja.RazaoSocial,
                CNPJ = loja.CNPJ,
                Email = loja.Email,
                Senha = loja.Senha,
                Telefone = loja.Telefone,
                LojaAtivo = loja.LojaAtivo,
                LojaRegistro = loja.LojaRegistro
            };
            _context.Lojas.Add(lojaRepository);
            _context.SaveChanges();
            return lojaRepository;
        }
        public void PutLoja(Loja loja)
        {
            _context.Entry(loja).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteLoja(int lojaId)
        {
            var loja = _context.Lojas.First(i => i.LojaId == lojaId);
            loja.LojaAtivo = false;
            _context.SaveChanges();
        }
    }
}
