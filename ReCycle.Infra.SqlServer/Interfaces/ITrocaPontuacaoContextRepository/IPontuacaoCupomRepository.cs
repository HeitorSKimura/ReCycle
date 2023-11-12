using ReCycle.Domain.TrocaPontuacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository
{
    public interface IPontuacaoCupomRepository
    {
        public List<PontuacaoCupom> GetAllPontuacaoCupom();
        public PontuacaoCupom GetByIdPontuacaoCupom(int id);
        public PontuacaoCupom PostPontuacaoCupom(int pontuacaoId, int cupomId);
    }
}
