using Microsoft.EntityFrameworkCore;
using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Domain.ViewModel.TrocaPontuacaoViewModel;
using ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Repositories.TrocaPontuacaoContextRepository
{
    public class CupomRepository : ICupomRepository
    {
        private readonly SqlServerContext _context;

        public CupomRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<Cupom> GetAllCupom()
        {
            return _context.Cupons.ToList();
        }

        public Cupom GetByIdCupom(int id)
        {
            return _context.Cupons.Find(id);
        }
        public Cupom PostCupom(CupomViewModel cupom)
        {
            var cupomRepository = new Cupom
            {
                Valor = cupom.Valor,
                Validade = cupom.Validade,
                LojaId = cupom.LojaId
            };
            _context.Cupons.Add(cupomRepository);
            _context.SaveChanges();
            return cupomRepository;
        }
        public void PutCupom(Cupom cupom)
        {
            _context.Entry(cupom).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
