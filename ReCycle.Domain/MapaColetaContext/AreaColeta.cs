using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ConfigContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.MapaColetaContext
{
    public class AreaColeta
    {
        [Key]
        public int AreaColetaId { get; set; }
        public string AreaNome { get; set; }
        public bool Desocupado { get; set; }
        public int ConfigId { get; set; }
        public Config Config { get; set; } = null!;
        public int UserId { get; set; }
        public Coletor Coletor { get; set; } = null!;
        public IList<PontoColeta>? PontosColeta { get; set; }
    }
}
