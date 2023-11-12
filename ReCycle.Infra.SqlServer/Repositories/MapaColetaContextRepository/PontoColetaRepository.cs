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
    public class PontoColetaRepository : IPontoColetaRepository
    {
        private readonly SqlServerContext _context;

        public PontoColetaRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<PontoColeta> GetAllPontoColeta()
        {
            return _context.PontosColeta.ToList();
        }

        public PontoColeta GetByIdPontoColeta(int id)
        {
            return _context.PontosColeta.Find(id);
        }
        public PontoColeta PostPontoColeta(PontoColetaViewModel pontoColeta)
        {
            var pontoColetaRepository = new PontoColeta
            {
                CoordenadaX = pontoColeta.CoordenadaX,
                CoordenadaY = pontoColeta.CoordenadaY,
                Map = pontoColeta.Map,
                DataRegistroPontoColeta = pontoColeta.DataRegistroPontoColeta,
                AreaColetaId = pontoColeta.AreaColetaId,
                EnderecoId = pontoColeta.EnderecoId
            };
            _context.PontosColeta.Add(pontoColetaRepository);
            _context.SaveChanges();
            return pontoColetaRepository;
        }
        public void PutPontoColeta(PontoColeta pontoColeta)
        {
            _context.Entry(pontoColeta).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
