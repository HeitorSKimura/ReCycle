using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.CadastroContext
{
    public class Coletor : User
    {
        public AreaColeta? AreasColeta { get; set; }
    }
}
