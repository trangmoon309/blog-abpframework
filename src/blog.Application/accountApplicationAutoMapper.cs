using AutoMapper;
using blog.Account;
using Volo.Abp.Identity;

namespace blog
{
    public class accountApplicationAutoMapper : Profile
    {
        public accountApplicationAutoMapper()
        {
            CreateMap<IdentityUser, IdentityUserDto>();
        }
    }
}
