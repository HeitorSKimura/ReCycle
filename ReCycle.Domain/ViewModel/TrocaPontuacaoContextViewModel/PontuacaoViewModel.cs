using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.ViewModel.TrocaPontuacaoViewModel
{
    public class PontuacaoViewModel
    {
        public bool Confirmacao { get; set; }
        public int Quantidade { get; set; }
        public bool PontuacaoAtivo { get; set; }
        public int ConfigId { get; set; }
        public int DescartanteId { get; set; }
        public int PontoColetaId { get; set; }
    }
}
