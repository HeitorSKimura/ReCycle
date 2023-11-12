using Microsoft.EntityFrameworkCore;
using ReCycle.Domain.EnderecoContext;
using ReCycle.Domain.ViewModel.EnderecoContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.IEnderecoContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Repositories.EnderecoContextRepository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly SqlServerContext _context;

        public EnderecoRepository(SqlServerContext context)
        {
            _context = context;
        }

        public List<Endereco> GetAllEndereco()
        {
            return _context.Enderecos.ToList();
        }

        public Endereco GetByIdEndereco(int id)
        {
            return _context.Enderecos.Find(id);
        }
        public Endereco PostEndereco(EnderecoViewModel endereco)
        {
            var enderecoRepository = new Endereco
            {
                CEP = endereco.CEP,
                Logradouro = endereco.Logradouro,
                Complemento = endereco.Complemento,
                Bairro = endereco.Bairro,
                Localidade = endereco.Localidade,
                UF = endereco.UF,
                NumeroCasa = endereco.NumeroCasa,
                LojaId = endereco.LojaId
            };
            _context.Enderecos.Add(enderecoRepository);
            _context.SaveChanges();
            return enderecoRepository;
        }
        public void PutEndereco(Endereco endereco)
        {
            _context.Entry(endereco).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
