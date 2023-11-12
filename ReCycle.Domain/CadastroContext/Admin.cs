using ReCycle.Domain.ConfigContext;
using ReCycle.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.CadastroContext
{
    public class Admin : User
    {
        public IList<Config>? Configs { get; set; }
    }
}
