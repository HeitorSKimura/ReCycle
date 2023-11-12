using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.ViewModel.TrocaPontuacaoViewModel
{
    public class CupomViewModel
    {
        public int Valor { get; set; }
        public DateTime Validade { get; set; }
        public int LojaId { get; set; }
    }
}
