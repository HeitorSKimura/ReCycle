using ReCycle.Domain.EnderecoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.IEnderecoContextRepository
{
    public interface IUserEnderecoRepository
    {
        public List<UserEndereco> GetAllUserEndereco();
        public UserEndereco GetByIdUserEndereco(int id);
        public UserEndereco PostUserEndereco(int userId, int enderecoId);
    }
}
