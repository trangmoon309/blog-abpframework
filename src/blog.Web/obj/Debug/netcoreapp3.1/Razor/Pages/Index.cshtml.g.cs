#pragma checksum "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa247f6e43e0769ec8c2ecf11e10e4bdd45c9db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#nullable restore
#line 2 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
using blog.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
using Volo.Abp.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa247f6e43e0769ec8c2ecf11e10e4bdd45c9db", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25152d795852518cc499282e563bc297efeed2a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/Pages/Index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/Pages/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleBundleTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleBundleTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpScriptBundleTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptBundleTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpScriptTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpLinkButtonTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-style-bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa247f6e43e0769ec8c2ecf11e10e4bdd45c9db5173", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-style", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5aa247f6e43e0769ec8c2ecf11e10e4bdd45c9db5457", async() => {
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper);
                    __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n    ");
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleBundleTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleBundleTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleBundleTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-script-bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa247f6e43e0769ec8c2ecf11e10e4bdd45c9db7666", async() => {
                    WriteLiteral("\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5aa247f6e43e0769ec8c2ecf11e10e4bdd45c9db7951", async() => {
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper);
                    __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n    ");
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptBundleTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpScriptBundleTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpScriptBundleTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <div class=""p-5 text-center"">
        <div class=""badge badge-success h5 rounded mb-4 "" role=""alert"">
            <h5 class=""m-1""> <i class=""fas fa-rocket""></i> Congratulations, <strong>blog</strong> is successfully running!</h5>
        </div>
        <h1>Welcome to the Application</h1>

        <p class=""lead px-lg-5 mx-lg-5"">");
#nullable restore
#line 26 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
                                   Write(L["LongWelcomeMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n");
#nullable restore
#line 28 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
         if (!CurrentUser.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa247f6e43e0769ec8c2ecf11e10e4bdd45c9db11018", async() => {
                WriteLiteral("<i class=\"fa fa-sign-in\"></i> ");
#nullable restore
#line 30 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
                                                                                     Write(L["Login"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpLinkButtonTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper);
#nullable restore
#line 30 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper.ButtonType = global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonType.Primary;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("abp-button", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpLinkButtonTagHelper.ButtonType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 31 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICurrentUser CurrentUser { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<blogResource> L { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<blog.Web.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blog.Web.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blog.Web.Pages.IndexModel>)PageContext?.ViewData;
        public blog.Web.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591