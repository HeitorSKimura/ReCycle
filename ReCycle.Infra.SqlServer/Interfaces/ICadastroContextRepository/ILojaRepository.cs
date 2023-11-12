using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository
{
    public interface ILojaRepository
    {
        public List<Loja> GetAllLoja();
        public Loja GetByIdLoja(int id);
        public string GetEmailLoja(string lojaEmail);
        public string GetSenhaLoja(string lojaSenha);
        public Loja InsertLoja(LojaViewModel loja);
        public void PutLoja(Loja loja);
        public void DeleteLoja(int lojaId);
    }
}
