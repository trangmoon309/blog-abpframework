using blog.Categories;
using blog.Posts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace blog.IdentityServer
{
    class PostDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Post, Guid> _postRepository;
        private readonly IGuidGenerator _guidGenerator;

        public PostDataSeedContributor(
            IRepository<Post, Guid> postRepository,
            IGuidGenerator guidGenerator)
        {
            _postRepository = postRepository;
            _guidGenerator = guidGenerator;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _postRepository.GetCountAsync() > 0)
            {
                return;
            }

            var post = new Post(_guidGenerator.Create(),"Test","Test","test","Test","Test",DateTime.Now, Guid.Parse("7A33CD78-84AF-4BDE-882D-39F8C35B4AA9"));

            await _postRepository.InsertAsync(post);
        }     
    }
}
