using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ConfigContext;
using ReCycle.Domain.MapaColetaContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.TrocaPontuacaoContext
{
    public class Pontuacao
    {
        [Key]
        public int PontuacaoId { get; set; }
        public bool Confirmacao { get; set; }
        public int Quantidade { get; set; }
        public bool PontuacaoAtivo { get; set; }
        public int ConfigId { get; set; }
        public Config Config { get; set; } = null!;
        public IList<Cupom>? Cupons { get; set; }
        public int DescartanteId { get; set; }
        public Descartante Descartante { get; set; } = null!;
        public int PontoColetaId { get; set; }
        public PontoColeta PontoColeta { get; set; } = null!;
    }
}
