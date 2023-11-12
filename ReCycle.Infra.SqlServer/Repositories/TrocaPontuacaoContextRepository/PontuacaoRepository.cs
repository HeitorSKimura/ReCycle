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
    public class PontuacaoRepository : IPontuacaoRepository
    {
        private readonly SqlServerContext _context;

        public PontuacaoRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<Pontuacao> GetAllPontuacao()
        {
            return _context.Pontuacoes.ToList();
        }

        public Pontuacao GetByIdPontuacao(int id)
        {
            return _context.Pontuacoes.Find(id);
        }
        public Pontuacao PostPontuacao(PontuacaoViewModel pontuacao)
        {
            var pontuacaoRepository = new Pontuacao
            {
                Confirmacao = pontuacao.Confirmacao,
                Quantidade = pontuacao.Quantidade,
                PontuacaoAtivo = pontuacao.PontuacaoAtivo,
                ConfigId = pontuacao.ConfigId,
                DescartanteId = pontuacao.DescartanteId,
                PontoColetaId = pontuacao.PontoColetaId
            };
            _context.Pontuacoes.Add(pontuacaoRepository);
            _context.SaveChanges();
            return pontuacaoRepository;
        }
        public void PutPontuacao(Pontuacao pontuacao)
        {
            _context.Entry(pontuacao).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void NullPontuacao(int pontuacaoId)
        {
            var pontuacao = _context.Pontuacoes.First(i => i.PontuacaoId == pontuacaoId);
            pontuacao.PontuacaoAtivo = false;
            _context.SaveChanges();
        }
    }
}
