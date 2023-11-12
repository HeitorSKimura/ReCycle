using ReCycle.Domain.ConfigContext;
using ReCycle.Domain.ViewModel.ConfigContextViewModel;
using ReCycle.Infra.SqlServer.Interfaces.IConfigContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer.Repositories.ConfigContextRepository
{
    public class ConfigRepository : IConfigRepository
    {
        private readonly SqlServerContext _context;

        public ConfigRepository(SqlServerContext contex)
        {
            _context = contex;
        }

        public List<Config> GetAllConfig()
        {
            return _context.Configs.ToList();
        }
        public Config GetByIdConfig(int id)
        {
            return _context.Configs.Find(id);
        }
        public Config PostConfig(ConfigViewModel config)
        {
            var configRepository = new Config
            {
                DataAlteracaoAdmin = config.DataAlteracaoAdmin,
                UserId = config.UserId
            };
            _context.Configs.Add(configRepository);
            _context.SaveChanges();
            return configRepository;
        }
    }
}
