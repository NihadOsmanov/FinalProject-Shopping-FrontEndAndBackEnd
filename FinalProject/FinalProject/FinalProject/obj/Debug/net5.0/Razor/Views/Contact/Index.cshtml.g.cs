#pragma checksum "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e31bace0393ba745460b16a1f2213c92567cfef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e31bace0393ba745460b16a1f2213c92567cfef", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("theme-form ng-untouched ng-pristine ng-valid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

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
                                <h2>Contact</h2>
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <nav class=""theme-breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item"">
                                        <a href=""./index.html"">Home </a>
                                    </li>
                                    <li class=""breadcrumb-item active"">Contact</li>
                                </ol>
                            </nav>
                        </div>
                    </div>");
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>
<!--Bredcrumb end-->
<!--Contact start-->
<section class=""contact-page"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 map"">
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2315.00721216222!2d45.36671974945402!3d41.093795227080314!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x404125b72fd6a1c7%3A0xbccc76ab29fb6489!2sUniversam!5e0!3m2!1sen!2s!4v1626211835051!5m2!1sen!2s""");
            BeginWriteAttribute("allowfullscreen", "\r\n                        allowfullscreen=\"", 1611, "\"", 1654, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                        loading=""lazy""></iframe>
            </div>
            <div class=""col-lg-5"">
                <div class=""contact-right"">
                    <ul>
                        <li>
                            <div class=""contact-icon"">
                                <img src=""./img/phone.png""
                                     alt=""Generic placeholder image"" />
                                <h6>Contact Us</h6>
                            </div>
                            <div class=""media-body"">
                                <p>+91 123 - 456 - 7890</p>
                                <p>+86 163 - 451 - 7894</p>
                            </div>
                        </li>
                        <li>
                            <div class=""contact-icon"">
                                <i aria-hidden=""true"" class=""fa fa-map-marker""></i>
                                <h6>Address</h6>
                            </div>
                            <div clas");
            WriteLiteral(@"s=""media-body"">
                                <p>ABC Complex,Near xyz, New York</p>
                                <p>USA 123456</p>
                            </div>
                        </li>
                        <li>
                            <div class=""contact-icon"">
                                <img src=""./img/email.png""
                                     alt=""Generic placeholder image"" />
                                <h6>Address</h6>
                            </div>
                            <div class=""media-body"">
                                <p>Support@Shopcart.com</p>
                                <p>info@shopcart.com</p>
                            </div>
                        </li>
                        <li>
                            <div class=""contact-icon"">
                                <i aria-hidden=""true"" class=""fa fa-fax""></i>
                                <h6>Fax</h6>
                            </div>
                           ");
            WriteLiteral(@" <div class=""media-body"">
                                <p>Support@Shopcart.com</p>
                                <p>info@shopcart.com</p>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-12"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e31bace0393ba745460b16a1f2213c92567cfef9193", async() => {
                WriteLiteral("\r\n                    <div class=\"form-row\">\r\n");
#nullable restore
#line 97 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                         if (!User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""col-md-6"">
                                <label>Name</label>
                                <input type=""text"" id=""Name-contact"" placeholder=""Enter Your name"" class=""form-control"" style="" margin-bottom: 15px;"" />
                                <span id=""ConNameError"" style=""color: orangered""></span>
                            </div>
                            <div class=""col-md-6"">
                                <label>Email</label><input type=""text""
                                                           id=""Email-contact""
                                                           placeholder=""Email""
                                                           class=""form-control"" style="" margin-bottom: 15px;""/>
                            </div>
                            <span id=""ConEmailError"" style=""color: orangered""></span>
                            <div class=""col-md-6"">
                                <label>Subject</label><input type=""t");
                WriteLiteral(@"ext""
                                                             id=""Subject-contact""
                                                             placeholder=""Subject""
                                                             class=""form-control"" style="" margin-bottom: 15px;""/>
                            </div>
                            <span id=""ConSubjectError"" style=""color: orangered""></span>
                            <div class=""col-md-12"">
                                <label for=""review"">Write Your Message</label><textarea placeholder=""Write Your Message""
                                                                                        id=""Message-contact""
                                                                                        rows=""6""
                                                                                        class=""form-control""></textarea>
                            </div>
                            <span id=""ConMessageError"" style=""color: o");
                WriteLiteral("rangered\"></span>\r\n");
#nullable restore
#line 125 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""col-md-6"">
                                <label for=""email"">Subject</label><input type=""text""
                                                                         id=""Subject-contact""
                                                                         placeholder=""Subject""");
                BeginWriteAttribute("required", "\r\n                                                                         required=\"", 6787, "\"", 6872, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                                                         class=""form-control"" style="" margin-bottom: 15px;""/>
                            </div>
                            <span id=""ConSubjectError"" style=""color: orangered""></span>
                            <div class=""col-md-12"">
                                <label for=""review"">Write Your Message</label><textarea placeholder=""Write Your Message""
                                                                                        id=""Message-contact""
                                                                                        rows=""6""
                                                                                        class=""form-control""></textarea>
                            </div>
                            <span id=""ConMessageError"" style=""color: orangered""></span>
");
#nullable restore
#line 143 "C:\Users\ASUS\Desktop\FinalProject-Shopping-\FinalProject\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""col-md-12"">
                            <button type=""submit"" class=""btn btn-solid"" id=""buttonCon"">
                                Send Your Message
                            </button>
                        </div>
                        <span id=""Form-contact"" class=""form-messege "" style=""padding-top: 20px !important; color: #EC1C23 !important;""></span>

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--Contact end-->\r\n");
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
