using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.TrocaPontuacaoContext
{
    public class PontuacaoCupom
    {
        [Key]
        public int PontuacaoCupomId { get; set; }

        public int PontuacaoId { get; set; }
        public Pontuacao Pontuacao { get; set; }

        public int CupomId { get; set; }
        public Cupom Cupom { get; set; }
    }
}
