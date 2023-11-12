using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.ViewModel.UserManagementContextViewModel
{
    public abstract class UserViewModel
    {
        public string UserNomeCompleto { get; set; }
        public string CPFRG { get; set; }
        public string UserEmail { get; set; }
        public string UserSenha { get; set; }
        public string UserTelefone { get; set; }
        public bool UserAtivo { get; set; }
        public DateTime UserRegistro { get; set; }
    }
}
