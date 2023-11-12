using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.ViewModel.MapaColetaContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.IMapaColetaContextRepository
{
    public interface IAreaColetaRepository
    {
        public List<AreaColeta> GetAllAreaColeta();
        public AreaColeta GetByIdAreaColeta(int id);
        public AreaColeta PostAreaColeta(AreaColetaViewModel areaColeta);
        public void PutAreaColeta(AreaColeta areaColeta);
    }
}
