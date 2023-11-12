using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Domain.ViewModel.TrocaPontuacaoViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository
{
    public interface ICupomRepository
    {
        public List<Cupom> GetAllCupom();
        public Cupom GetByIdCupom(int id);
        public Cupom PostCupom(CupomViewModel cupom);
        public void PutCupom(Cupom cupom);
    }
}
