using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace blog.EntityFrameworkCore
{
    [DependsOn(
        typeof(blogEntityFrameworkCoreModule)
        )]
    public class blogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<blogMigrationsDbContext>();
        }
    }
}
