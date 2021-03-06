using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Eureka.Cms.EntityFramework;

namespace Eureka.Cms.Migrator
{
    [DependsOn(typeof(CmsDataModule))]
    public class CmsMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CmsDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}