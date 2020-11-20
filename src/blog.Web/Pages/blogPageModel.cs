using blog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace blog.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class blogPageModel : AbpPageModel
    {
        protected blogPageModel()
        {
            LocalizationResourceType = typeof(blogResource);
        }
    }
}