#pragma checksum "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b208682083c59b2f577ed8fbe00b55fa30c67d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Post_PostList), @"mvc.1.0.razor-page", @"/Pages/Post/PostList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b208682083c59b2f577ed8fbe00b55fa30c67d03", @"/Pages/Post/PostList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25152d795852518cc499282e563bc297efeed2a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Post_PostList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/css/listpost.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Post/PostDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Post/UpdatePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:14px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
  
    ViewData["Title"] = "List of Post";
    Layout = "_MyLayout";
    var posts = Model.PostList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-style", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b208682083c59b2f577ed8fbe00b55fa30c67d034536", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"container-fluid\" style=\"position:relative\">\r\n    <ul class=\"blog-list\" style=\"margin-top: 10%; list-style-type:none \">\r\n");
#nullable restore
#line 16 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
         for (int i = 0; i < Model.PostList.Count(); i++)
        {
            var photoPath = "";
            if (posts[i].PhotoPath == null) photoPath = "/imgs/default.jpg";
            else
            {
                photoPath = "/imgs/" + posts[i].PhotoPath;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div class=\"post\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 725, "\"", 741, 1);
#nullable restore
#line 26 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
WriteAttributeValue("", 731, photoPath, 731, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"No image\" width=\"100%\" />\r\n                    <h1 style=\"font-size:25px;font-weight:800\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b208682083c59b2f577ed8fbe00b55fa30c67d037051", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
                       Write(posts[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
                                                             WriteLiteral(posts[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </h1>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b208682083c59b2f577ed8fbe00b55fa30c67d039618", async() => {
                WriteLiteral("Update Post");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
                                                         WriteLiteral(posts[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h4>");
#nullable restore
#line 33 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
                   Write(posts[i].Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5>");
#nullable restore
#line 34 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
                   Write(posts[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>... </span><i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b208682083c59b2f577ed8fbe00b55fa30c67d0312410", async() => {
                WriteLiteral(" View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
                                                                                                                              WriteLiteral(posts[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</i></h5>\r\n                    <h4>\r\n                        <i>");
#nullable restore
#line 36 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
                      Write(posts[i].CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                    </h4>\r\n");
            WriteLiteral("                </div>\r\n            </li>\r\n");
#nullable restore
#line 44 "D:\Self-learning\(3).C#\Thực tập\Blog-abp\blog-abp\test\src\blog.Web\Pages\Post\PostList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<blog.Web.Pages.Post.PostListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blog.Web.Pages.Post.PostListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<blog.Web.Pages.Post.PostListModel>)PageContext?.ViewData;
        public blog.Web.Pages.Post.PostListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591