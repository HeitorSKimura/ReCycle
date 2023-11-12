using ReCycle.Domain.CadastroContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.TrocaPontuacaoContext
{
    public class Cupom
    {
        [Key]
        public int CupomId { get; set; }
        public int Valor { get; set; }
        public DateTime Validade { get; set; }
        public int LojaId { get; set; }
        public Loja Loja { get; set; } = null!;
        public IList<Pontuacao>? Pontuacoes { get; set; }
    }
}
