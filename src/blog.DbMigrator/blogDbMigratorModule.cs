using blog.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace blog.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(blogEntityFrameworkCoreDbMigrationsModule),
        typeof(blogApplicationContractsModule)
        )]
    public class blogDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
