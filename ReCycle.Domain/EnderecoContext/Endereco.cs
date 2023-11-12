using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.EnderecoContext
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string NumeroCasa { get; set; }

        public int LojaId { get; set; }
        public Loja Loja { get; set; } = null!;
        public IList<User> User { get; set; }
        public IList<PontoColeta>? PontosColeta { get; set; }
    }
}
