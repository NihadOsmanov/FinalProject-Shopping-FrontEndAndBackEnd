#pragma checksum "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10719d4589399e6103dc7428ac137d90ff0f7d52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Basket), @"mvc.1.0.view", @"/Views/Home/Basket.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10719d4589399e6103dc7428ac137d90ff0f7d52", @"/Views/Home/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
  
    ViewData["Title"] = "Basket";
    List<BasketViewModel> basketViewModel = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--Bredcrum start-->
<section class=""breadcrumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""breadcrumb-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <div class=""page-title"">
                                <h2>Cart</h2>
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <nav class=""theme-breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10719d4589399e6103dc7428ac137d90ff0f7d526562", async() => {
                WriteLiteral("Home ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </li>
                                    <li class=""breadcrumb-item active"">Cart</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--Bredcrumb end-->
<basket id=""cart_basket"">
    <table class=""table"" style=""text-align: center"">
        <thead>
            <tr>
                <th scope=""col"">Image</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Count</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
              
                double sum = 0;
                foreach (var item in basketViewModel)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td style=\"vertical-align:middle\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "10719d4589399e6103dc7428ac137d90ff0f7d529137", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1857, "~/img/product/", 1857, 14, true);
#nullable restore
#line 53 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
AddHtmlAttributeValue("", 1871, item.Image, 1871, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\">");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
                                                         Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\">");
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
                                                         Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\">$");
#nullable restore
#line 56 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
                                                          Write(Math.Round((Convert.ToDouble(item.Price) - (((double)item.Price * item.Discount) / 100)) * (double)item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle; width: 600px;\">\r\n                                <button class=\"btn btn-danger\" id=\"decrease\"");
            BeginWriteAttribute("value", " value=\"", 2433, "\"", 2449, 1);
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
WriteAttributeValue("", 2441, item.Id, 2441, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">-</button>\r\n                                <input hidden type=\"number\" id=\"cart_amount\"");
            BeginWriteAttribute("value", " value=\"", 2539, "\"", 2558, 1);
#nullable restore
#line 59 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
WriteAttributeValue("", 2547, item.Count, 2547, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" class=\"amount cart_amount\" />\r\n                                <button class=\"btn btn-danger\" id=\"increase\"");
            BeginWriteAttribute("value", " value=\"", 2675, "\"", 2691, 1);
#nullable restore
#line 60 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
WriteAttributeValue("", 2683, item.Id, 2683, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">+</button>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10719d4589399e6103dc7428ac137d90ff0f7d5213646", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
                    { sum += ((Convert.ToDouble(item.Price) - ((Convert.ToDouble(item.Price) * item.Discount) / 100)) * (item.Count)); }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <h2 style=\"text-align: end; padding-right: 40px\">\r\n        Total : $");
#nullable restore
#line 70 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Home\Basket.cshtml"
            Write(Math.Round(sum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n</basket>\r\n\r\n\r\n\r\n\r\n");
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
