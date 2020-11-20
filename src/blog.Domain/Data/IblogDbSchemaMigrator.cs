using System.Threading.Tasks;

namespace blog.Data
{
    public interface IblogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
