using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.ViewModel.MapaColetaContextViewModel
{
    public class PontoColetaViewModel
    {
        public string CoordenadaX { get; set; }
        public string CoordenadaY { get; set; }
        public string Map { get; set; }
        public DateTime DataRegistroPontoColeta { get; set; }
        public int AreaColetaId { get; set; }
        public int EnderecoId { get; set; }
    }
}
