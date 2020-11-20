using blog.Categories;
using blog.Documents;
using blog.Posts;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace blog.EntityFrameworkCore
{
    public static class blogDbContextModelCreatingExtensions
    {
        public static void Configureblog(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Category>(b =>
            {
                b.ToTable(blogConsts.DbTablePrefix + "Cate", blogConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });

            builder.Entity<Post>(b =>
            {
                b.ToTable(blogConsts.DbTablePrefix + "Post", blogConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });

            builder.Entity<DocumentStore>(b =>
            {
                b.ToTable(blogConsts.DbTablePrefix + "DocumentStore", blogConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });
        }
    }
}