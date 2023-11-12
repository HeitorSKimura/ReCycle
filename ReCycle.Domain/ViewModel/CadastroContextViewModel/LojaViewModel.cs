using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Domain.ViewModel.CadastroContextViewModel
{
    public class LojaViewModel
    {
        public string NomeFicticio { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public bool LojaAtivo { get; set; }
        public DateTime LojaRegistro { get; set; }
    }
}
