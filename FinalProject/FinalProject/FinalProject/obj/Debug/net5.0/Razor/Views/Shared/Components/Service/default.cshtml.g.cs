#pragma checksum "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Shared\Components\Service\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1b8e1d3416390c2b83c70cf5fdfc145d78c0828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Service_default), @"mvc.1.0.view", @"/Views/Shared/Components/Service/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b8e1d3416390c2b83c70cf5fdfc145d78c0828", @"/Views/Shared/Components/Service/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Service_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<section class=\"service\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Shared\Components\Service\default.cshtml"
             foreach (var service in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 service-block\">\r\n                    <div class=\"media\">\r\n                        <i class=\"fas fa-shipping-fast\"></i>\r\n                        <div class=\"media-body\">\r\n                            <h4>");
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Shared\Components\Service\default.cshtml"
                           Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Shared\Components\Service\default.cshtml"
                          Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\FinalProject\FinalProject\FinalProject\Views\Shared\Components\Service\default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
