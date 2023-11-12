using ReCycle.Domain.EnderecoContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.UserManagementContext
{
    public abstract class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserNomeCompleto { get; set; }
        public string CPFRG { get; set; }
        public string UserEmail { get; set; }
        public string UserSenha { get; set; }
        public string UserTelefone { get; set; }
        public bool UserAtivo { get; set; }
        public DateTime UserRegistro { get; set; }
        public IList<Endereco>? Endereco { get; set; }
    }
}
