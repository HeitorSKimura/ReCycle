using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ViewModel.CadastroContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository
{
    public interface IDescartanteRepository
    {
        public List<Descartante> GetAllDescartante();
        public Descartante GetByIdDescartante(int id);
        public string GetEmailDescartante(string descartanteEmail);
        public string GetSenhaDescartante(string descartanteSenha);
        public Descartante InsertDescartante(DescartanteViewModel descartante);
        public void PutDescartante(Descartante descartante);
        public void DeleteDescartante(int descartanteId);
    }
}
