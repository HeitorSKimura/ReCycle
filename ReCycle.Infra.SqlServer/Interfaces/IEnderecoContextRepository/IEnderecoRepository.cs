using ReCycle.Domain.EnderecoContext;
using ReCycle.Domain.ViewModel.EnderecoContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.IEnderecoContextRepository
{
    public interface IEnderecoRepository
    {
        public List<Endereco> GetAllEndereco();
        public Endereco GetByIdEndereco(int id);
        public Endereco PostEndereco(EnderecoViewModel endereco);
        public void PutEndereco(Endereco endereco);
    }
}
