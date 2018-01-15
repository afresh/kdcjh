using EWeb.EntityFramework;
using EntityFramework.DynamicFilters;

namespace EWeb.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly EWebDbContext _context;

        public InitialHostDbBuilder(EWebDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
