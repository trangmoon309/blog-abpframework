using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace blog.Web
{
    [Dependency(ReplaceServices = true)]
    public class blogBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "blog";
    }
}
