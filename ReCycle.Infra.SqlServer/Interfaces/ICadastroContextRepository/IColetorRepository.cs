using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository
{
    public interface IColetorRepository
    {
        public List<Coletor> GetAllColetor();
        public Coletor GetByIdColetores(int id);
        public string GetEmailColetor(string coletorEmail);
        public string GetSenhaColetor(string coletorSenha);
        public Coletor InsertColetor(ColetorViewModel coletor);
        public void PutColetor(Coletor coletor);
        public void DeleteColetor(int coletorId);
    }
}
