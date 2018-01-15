using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using EWeb.EntityFramework;

namespace EWeb.Migrator
{
    [DependsOn(typeof(EWebDataModule))]
    public class EWebMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<EWebDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}