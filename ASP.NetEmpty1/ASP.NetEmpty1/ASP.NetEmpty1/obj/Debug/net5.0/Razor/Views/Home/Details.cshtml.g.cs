#pragma checksum "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaa8b1c95ea7bbf04987f0b2a841ad242a7cd2ba"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa8b1c95ea7bbf04987f0b2a841ad242a7cd2ba", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NetEmpty3.ViewModel.HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 25 "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml"

    //@model aspnetcoreempty.modal.Employee;
   // Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1> ");
#nullable restore
#line 28 "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml"
    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 29 "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml"
    //<h1>@ViewBag.Title</h1>
    //var employee = ViewData["Employee"] as aspnetcoreempty.modal.Employee;
    // var employee = ViewData["Employee"] as aspnetcoreempty.modal.Employee;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"text-bg-danger\">Employee detailes\r\n    </h1>\r\n\r\n    <h3> Age: ");
#nullable restore
#line 37 "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml"
         Write(Model.Employee.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>  \r\n    <h3> Id: ");
#nullable restore
#line 38 "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml"
        Write(Model.Employee.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3> Name: ");
#nullable restore
#line 39 "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml"
          Write(Model.Employee.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>Email:");
#nullable restore
#line 40 "C:\Users\107012\Downloads\ASP.NetEmpty3Akshasend\ASP.NetEmpty3Aksha\ASP.NetEmpty3\Views\Home\Details.cshtml"
         Write(Model.Employee.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n</div>");
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
