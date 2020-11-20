using blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace blog.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class blogController : AbpController
    {
        protected blogController()
        {
            LocalizationResource = typeof(blogResource);
        }
    }
}