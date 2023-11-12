using ReCycle.Domain.ConfigContext;
using ReCycle.Domain.ViewModel.ConfigContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Interfaces.IConfigContextRepository
{
    public interface IConfigRepository
    {
        public List<Config> GetAllConfig();
        public Config GetByIdConfig(int id);
        public Config PostConfig(ConfigViewModel config);
    }
}
