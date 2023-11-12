using ReCycle.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.EnderecoContext
{
    public class UserEndereco
    {
        [Key]
        public int UserEnderecoId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
