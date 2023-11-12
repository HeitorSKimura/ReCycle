using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.TrocaPontuacaoContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.ConfigContext
{
    public class Config
    {
        [Key]
        public int ConfigId { get; set; }
        public DateTime DataAlteracaoAdmin { get; set; }
        public int UserId { get; set; }
        public Admin Admin { get; set; } = null!;
        public IList<Pontuacao>? Pontuacoes { get; set; }
        public IList<AreaColeta>? AreasColeta { get; set; }
    }
}
