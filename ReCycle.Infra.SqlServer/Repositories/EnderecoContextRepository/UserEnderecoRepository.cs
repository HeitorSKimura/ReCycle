using ReCycle.Domain.EnderecoContext;
using ReCycle.Infra.SqlServer.Interfaces.IEnderecoContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Repositories.EnderecoContextRepository
{
    public class UserEnderecoRepository : IUserEnderecoRepository
    {
        private readonly SqlServerContext _context;

        public UserEnderecoRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<UserEndereco> GetAllUserEndereco()
        {
            return _context.UserEnderecos.ToList();
        }

        public UserEndereco GetByIdUserEndereco(int id)
        {
            return _context.UserEnderecos.Find(id);
        }
        public UserEndereco PostUserEndereco(int userId, int enderecoId)
        {
            var user = _context.Users.First(i => i.UserId == userId);
            var endereco = _context.Enderecos.First(i => i.EnderecoId == enderecoId);

            var userEndereco = new UserEndereco
            {
                User = user,
                Endereco = endereco
            };

            _context.Add(userEndereco);
            _context.SaveChanges();
            return userEndereco;
        }
    }
}
