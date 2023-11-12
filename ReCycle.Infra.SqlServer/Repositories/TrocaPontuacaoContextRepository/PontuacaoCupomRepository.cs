using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Repositories.TrocaPontuacaoContextRepository
{
    public class PontuacaoCupomRepository : IPontuacaoCupomRepository
    {
        private readonly SqlServerContext _context;

        public PontuacaoCupomRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<PontuacaoCupom> GetAllPontuacaoCupom()
        {
            return _context.PontuacoesCupom.ToList();
        }

        public PontuacaoCupom GetByIdPontuacaoCupom(int id)
        {
            return _context.PontuacoesCupom.Find(id);
        }
        public PontuacaoCupom PostPontuacaoCupom(int pontuacaoId, int cupomId)
        {
            var pontuacao = _context.Pontuacoes.First(i => i.PontuacaoId == pontuacaoId);
            var cupom = _context.Cupons.First(i => i.CupomId == cupomId);

            var pontuacaoCupom = new PontuacaoCupom
            {
                Pontuacao = pontuacao,
                Cupom = cupom
            };

            _context.Add(pontuacaoCupom);
            _context.SaveChanges();
            return pontuacaoCupom;
        }
    }
}
