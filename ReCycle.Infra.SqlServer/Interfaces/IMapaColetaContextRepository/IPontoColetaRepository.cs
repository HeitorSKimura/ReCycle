using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.ViewModel.MapaColetaContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.IMapaColetaContextRepository
{
    public interface IPontoColetaRepository
    {
        public List<PontoColeta> GetAllPontoColeta();
        public PontoColeta GetByIdPontoColeta(int id);
        public PontoColeta PostPontoColeta(PontoColetaViewModel pontoColeta);
        public void PutPontoColeta(PontoColeta pontoColeta);
    }
}
