#pragma checksum "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5e7d9f54c1f246f8aca9be6153dde73efcc66a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Home_HomePage), @"mvc.1.0.razor-page", @"/Pages/Home/HomePage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5e7d9f54c1f246f8aca9be6153dde73efcc66a7", @"/Pages/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25152d795852518cc499282e563bc297efeed2a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_HomePage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Home\HomePage.cshtml"
  
    ViewData["Title"] = "HomePage";
    Layout = "_MyLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""middle-header"">
    <div class=""main"">
        <!-- TYPER -->
        <h1 class=""aqua"" style=""font-size:50px;margin-bottom:89px;font-weight:800;"">BLOG PROJECT ABP</h1>
        <!-- TYPER END -->
        <div class=""line""></div>
        <p>“It's fine to celebrate success but it is more important to heed the lesson of failure.” ― Bill Gates.</p>
        <button>Welcome to blog <i class=""far fa-arrow-alt-circle-down""></i></button>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<blog.Web.Pages.Home.HomePageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blog.Web.Pages.Home.HomePageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blog.Web.Pages.Home.HomePageModel>)PageContext?.ViewData;
        public blog.Web.Pages.Home.HomePageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
