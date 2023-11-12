using Microsoft.EntityFrameworkCore;
using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.ViewModel.MapaColetaContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.IMapaColetaContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Repositories.MapaColetaContextRepository
{
    public class AreaColetaRepository : IAreaColetaRepository
    {
        private readonly SqlServerContext _context;

        public AreaColetaRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<AreaColeta> GetAllAreaColeta()
        {
            return _context.AreasColeta.ToList();
        }

        public AreaColeta GetByIdAreaColeta(int id)
        {
            return _context.AreasColeta.Find(id);
        }
        public AreaColeta PostAreaColeta(AreaColetaViewModel areaColeta)
        {
            var areaColetaRepository = new AreaColeta
            {
                AreaNome = areaColeta.AreaNome,
                Desocupado = areaColeta.Desocupado,
                ConfigId = areaColeta.ConfigId,
                UserId = areaColeta.UserId
            };
            _context.AreasColeta.Add(areaColetaRepository);
            _context.SaveChanges();
            return areaColetaRepository;
        }
        public void PutAreaColeta(AreaColeta areaColeta)
        {
            _context.Entry(areaColeta).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
