using System;
using System.Collections.Generic;
using System.Text;
using blog.Localization;
using Volo.Abp.Application.Services;

namespace blog
{
    /* Inherit your application services from this class.
     */
    public abstract class blogAppService : ApplicationService
    {
        protected blogAppService()
        {
            LocalizationResource = typeof(blogResource);
        }
    }
}
