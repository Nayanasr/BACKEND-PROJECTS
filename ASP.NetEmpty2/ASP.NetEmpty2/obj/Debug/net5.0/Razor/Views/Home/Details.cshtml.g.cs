#pragma checksum "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36297124d9230310c61d24c670b08b723bb14533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36297124d9230310c61d24c670b08b723bb14533", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NetEmpty3.ViewModel.HomeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/emp.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("    <h1> ");
#nullable restore
#line 26 "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml"
    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 27 "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml"
    //<h1>@ViewBag.Title</h1>
	//var employee = ViewData["Employee"] as ASP.NetEmpty3.Model.Employee;
	// var employee = ViewData["Employee"] as ASP.NetEmpty3.Model.Employee;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<");
            WriteLiteral("\r\n    \r\n<div class=\"row justify-content-center m-3\">\r\n\t<div class=\"col-sm-8\">\r\n\t\t<div class=\"card\">\r\n\t\t\t<div class=\"card-header\">\r\n\t\t\t\t<h1>");
#nullable restore
#line 63 "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"card-body text-center\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36297124d9230310c61d24c670b08b723bb145334488", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t<h3>Employee ID: ");
#nullable restore
#line 68 "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml"
                            Write(Model.Employee.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t<h3>Employee Name: ");
#nullable restore
#line 69 "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml"
                              Write(Model.Employee.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t<h3>Employee Age: ");
#nullable restore
#line 70 "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml"
                             Write(Model.Employee.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t<h3>Employee Email: ");
#nullable restore
#line 71 "C:\Users\107012\Downloads\ASP.NetEmpty3 (1)\ASP.NetEmpty3\Views\Home\Details.cshtml"
                               Write(Model.Employee.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"card-footer text-center\">\r\n\t\t\t\t<a href=\"#\" class=\"btn btn-primary\">Back</a>\r\n\t\t\t\t<a href=\"#\" class=\"btn btn-primary\">Update</a>\r\n\t\t\t\t<a href=\"#\" class=\"btn btn-danger\">Delete</a>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NetEmpty3.ViewModel.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
