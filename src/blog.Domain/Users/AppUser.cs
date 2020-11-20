using Microsoft.AspNetCore.Identity;
using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace blog.Users
{
    /* This entity shares the same table/collection ("AbpUsers" by default) with the
     * IdentityUser entity of the Identity module.
     *
     * - You can define your custom properties into this class.
     * - You never create or delete this entity, because it is Identity module's job.
     * - You can query users from database with this entity.
     * - You can update values of your custom properties.
     */
    public class AppUser : IdentityUser
    {
        #region Base properties

        public virtual string Name { get; private set; }
        #endregion

        public AppUser()
        {
            
        }

        public AppUser(Guid id,string userName, string phoneNumber)
        {
            Id = id.ToString();
            UserName = userName;
            PhoneNumber = phoneNumber;
        }
    }
}
