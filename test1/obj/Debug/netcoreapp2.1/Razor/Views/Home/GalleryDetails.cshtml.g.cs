#pragma checksum "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8941f44e08382943e6e2191f04e2d98c946d2a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GalleryDetails), @"mvc.1.0.view", @"/Views/Home/GalleryDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GalleryDetails.cshtml", typeof(AspNetCore.Views_Home_GalleryDetails))]
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
#line 1 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8941f44e08382943e6e2191f04e2d98c946d2a70", @"/Views/Home/GalleryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57b3d1751bedbfc5b7e01716b419f1606be717e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GalleryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<test1.Models.GalleryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Park"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
  
    ViewData["Title"] = Model.name;

#line default
#line hidden
            BeginContext(78, 56, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n");
            EndContext();
            BeginContext(162, 250, true);
            WriteLiteral("        <div class=\"col-md-12 d-flex flex-lg-row flex-wrap justify-content-center my-5\">\r\n            <div class=\"container gallery-container\">\r\n                <div class=\"container-fluid mb-5\">\r\n                    <h1 class=\"text-center HeadText\">");
            EndContext();
            BeginContext(413, 10, false);
#line 12 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
                                                Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(423, 96, true);
            WriteLiteral("</h1>\r\n                    <div class=\"tz-gallery\">\r\n                        <div class=\"row\">\r\n");
            EndContext();
#line 15 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
                             foreach (var item in Model.images)
                            {

#line default
#line hidden
            BeginContext(615, 271, true);
            WriteLiteral(@"                                <div class=""col-md-4  d-flex w-100 my-1"">
                                    <div class=""justify-content-center align-self-center"">
                                        <div class=""card"">
                                            ");
            EndContext();
            BeginContext(886, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af8495f296a741ff929324c719c25cfd", async() => {
                BeginContext(952, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(1002, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5062ad6a884d41debb4911ccd6ec29ba", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1012, "~/lib/images/gallery/", 1012, 21, true);
#line 21 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
AddHtmlAttributeValue("", 1033, Model.path, 1033, 11, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1044, "/", 1044, 1, true);
#line 21 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
AddHtmlAttributeValue("", 1045, item, 1045, 5, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1084, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 912, "~/lib/images/gallery/", 912, 21, true);
#line 20 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
AddHtmlAttributeValue("", 933, Model.path, 933, 11, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 944, "/", 944, 1, true);
#line 20 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
AddHtmlAttributeValue("", 945, item, 945, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1134, 134, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 26 "C:\Users\emre\Desktop\PROJELER\OTOMASYON\WEB\Kronostech\test1\test1\Views\Home\GalleryDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(1299, 302, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js""></script>
<script>
    baguetteBox.run('.tz-gallery');
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<test1.Controllers.HomeController> SharedHtmlLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<test1.Models.GalleryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
