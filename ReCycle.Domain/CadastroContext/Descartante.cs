using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.CadastroContext
{
    public class Descartante : User
    {
        public IList<Pontuacao>? Pontuacoes { get; set; }
    }
}
