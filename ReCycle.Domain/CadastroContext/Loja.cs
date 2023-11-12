using ReCycle.Domain.EnderecoContext;
using ReCycle.Domain.TrocaPontuacaoContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.CadastroContext
{
    public class Loja
    {
        [Key]
        public int LojaId { get; set; }
        public string NomeFicticio { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public bool LojaAtivo { get; set; }
        public DateTime LojaRegistro { get; set; }
        public IList<Endereco>? Enderecos { get; set; }
        public IList<Cupom>? Cupons { get; set; }
    }
}
