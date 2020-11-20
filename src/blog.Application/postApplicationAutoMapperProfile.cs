using AutoMapper;
using blog.Document;
using blog.Documents;
using blog.Posts;
using Volo.Abp.Identity;

namespace blog
{
    public class postApplicationAutoMapperProfile : Profile
    {
        public postApplicationAutoMapperProfile()
        {
            CreateMap<blog.Posts.Post, PostDto>();
            CreateMap<CreateUpdatePostDto, blog.Posts.Post>();
            CreateMap<CreateUpdatePostDto, PostDto>();
            CreateMap<PostDto, CreateUpdatePostDto>();
            CreateMap<PostDto, blog.Posts.Post>();
            CreateMap<IdentityRole, blog.Identity.IdentityRoleDto>();
            CreateMap<IdentityUser, IdentityUserDto>()
                        .MapExtraProperties();
            CreateMap<DocumentStore, DocumentDto>();
            CreateMap<DocumentDto, DocumentStore>();

        }
    }
}
