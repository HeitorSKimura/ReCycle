using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Domain.ViewModel.TrocaPontuacaoViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository
{
    public interface IPontuacaoRepository
    {
        public List<Pontuacao> GetAllPontuacao();
        public Pontuacao GetByIdPontuacao(int id);
        public Pontuacao PostPontuacao(PontuacaoViewModel pontuacao);
        public void PutPontuacao(Pontuacao pontuacao);
        public void NullPontuacao(int pontuacaoId);
    }
}
