using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.ViewModel.MapaColetaContextViewModel
{
    public class AreaColetaViewModel
    {
        public string AreaNome { get; set; }
        public bool Desocupado { get; set; }
        public int ConfigId { get; set; }
        public int UserId { get; set; }
    }
}
