#pragma checksum "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7148d6b1e939d194d098a693ea9e5fd04bc82d79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7148d6b1e939d194d098a693ea9e5fd04bc82d79", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    List<Blog> blogs = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Bredcrum start-->
<section class=""breadcrumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""breadcrumb-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <div class=""page-title"">
                                <h2>Blog</h2>
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <nav class=""theme-breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item"">
                                        <a href=""./index.html"">Home </a>
                                    </li>
                                    <li class=""breadcrumb-item active"">Blog</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
     ");
            WriteLiteral(@"           </div>
            </div>
        </div>
    </div>
</section>
<!--Bredcrumb end-->
<!--Blog start-->
<section class=""blog-page"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-9 col-lg-8 col-md-7"">
");
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                 foreach (var blog in blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row blog-detail\">\r\n                        <div class=\"col-xl-6\">\r\n                            <div class=\"blog-left\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7148d6b1e939d194d098a693ea9e5fd04bc82d795964", async() => {
                WriteLiteral("\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1717, "\"", 1745, 2);
                WriteAttributeValue("", 1723, "./img/Blog/", 1723, 11, true);
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1734, blog.Image, 1734, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"blog-1\" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                               WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-xl-6\">\r\n                            <div class=\"blog-right\">\r\n                                <h6>");
#nullable restore
#line 53 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                               Write(blog.Date.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7148d6b1e939d194d098a693ea9e5fd04bc82d799443", async() => {
                WriteLiteral("\r\n                                    <h4>\r\n                                        ");
#nullable restore
#line 56 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                   Write(blog.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h4>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                               WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <ul class=\"post-social\">\r\n                                    <li>Posted By : ");
#nullable restore
#line 60 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                               Write(blog.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li><i class=\"fa fa-comments\"></i> 10 Comment</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 66 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""col-xl-3 col-lg-4 col-md-5"">
                <div class=""blog-sidebar"">
                    <div class=""theme-card"">
                        <h4>Recent Blog</h4>
                        <ul class=""recent-blog"">
");
#nullable restore
#line 74 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                             foreach (var blog in blogs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7148d6b1e939d194d098a693ea9e5fd04bc82d7913686", async() => {
                WriteLiteral("\r\n                                <li>\r\n                                    <div class=\"media\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 3289, "\"", 3317, 2);
                WriteAttributeValue("", 3295, "./img/Blog/", 3295, 11, true);
#nullable restore
#line 79 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3306, blog.Image, 3306, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3318, "\"", 3324, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <div class=\"media-body align-self-center\">\r\n                                            <h6>");
#nullable restore
#line 81 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                           Write(blog.Date.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""theme-card"">
                        <h4>Popular Blog</h4>
                        <ul class=""popular-blog"">
                            <li>
                                <div class=""media"">
                                    <div class=""blog-date"">
                                        <span>03 </span>
                                        <span>May </span>
                                    </div>
                                    <div class=""media-body align-self-center"">
                                        <h6>Injected humour the like</h6>
                                    </div>
                                </div>
                                <p>
                                    it look like readable English. Many desktop publishing
                                    text.
                                </p>
                            </li>
                            ");
            WriteLiteral(@"<li>
                                <div class=""media"">
                                    <div class=""blog-date"">
                                        <span>03 </span>
                                        <span>May </span>
                                    </div>
                                    <div class=""media-body align-self-center"">
                                        <h6>Injected humour the like</h6>
                                    </div>
                                </div>
                                <p>
                                    it look like readable English. Many desktop publishing
                                    text.
                                </p>
                            </li>
                            <li>
                                <div class=""media"">
                                    <div class=""blog-date"">
                                        <span>03 </span>
                                        <span>May </s");
            WriteLiteral(@"pan>
                                    </div>
                                    <div class=""media-body align-self-center"">
                                        <h6>Injected humour the like</h6>
                                    </div>
                                </div>
                                <p>
                                    it look like readable English. Many desktop publishing
                                    text.
                                </p>
                            </li>
                            <li>
                                <div class=""media"">
                                    <div class=""blog-date"">
                                        <span>03 </span>
                                        <span>May </span>
                                    </div>
                                    <div class=""media-body align-self-center"">
                                        <h6>Injected humour the like</h6>
                          ");
            WriteLiteral(@"          </div>
                                </div>
                                <p>
                                    it look like readable English. Many desktop publishing
                                    text.
                                </p>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--Blog end-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
