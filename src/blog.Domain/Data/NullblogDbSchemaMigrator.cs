using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace blog.Data
{
    /* This is used if database provider does't define
     * IblogDbSchemaMigrator implementation.
     */
    public class NullblogDbSchemaMigrator : IblogDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}