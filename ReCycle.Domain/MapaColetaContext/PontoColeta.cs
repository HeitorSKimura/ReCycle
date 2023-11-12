using ReCycle.Domain.EnderecoContext;
using ReCycle.Domain.TrocaPontuacaoContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.MapaColetaContext
{
    public class PontoColeta
    {
        [Key]
        public int PontoColetaId { get; set; }
        public string CoordenadaX { get; set; }
        public string CoordenadaY { get; set; }
        public string Map { get; set; }
        public DateTime DataRegistroPontoColeta { get; set; }
        public int AreaColetaId { get; set; }
        public AreaColeta AreaColeta { get; set; } = null!;
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; } = null!;
        public IList<Pontuacao>? Pontuacoes { get; set; }
    }
}
