#pragma checksum "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74bc5841c385d84762a7de267a3901b7bfe9fa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmailService), @"mvc.1.0.view", @"/Views/Home/EmailService.cshtml")]
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
#line 1 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/_ViewImports.cshtml"
using SEAKNOW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/_ViewImports.cshtml"
using SEAKNOW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74bc5841c385d84762a7de267a3901b7bfe9fa0", @"/Views/Home/EmailService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfe532ceaa739984aa99d731c92471d80b61b78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmailService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"
  
    ViewData["Title"] = "E-mail Service";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p></p>\n\n");
#nullable restore
#line 8 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Email</h3>\n");
#nullable restore
#line 14 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"
Write(Html.TextBox("email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <br />\n    <br />\n    <br />\n");
            WriteLiteral("    <h3>Company Name</h3>\n");
#nullable restore
#line 22 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"
Write(Html.TextBox("firmname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 24 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"
Write(ViewData["emailValidation"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"
                                ;



#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <button type=\"submit\">Submit</button>\n");
#nullable restore
#line 29 "/Users/cerenbahcekapili/Projects/SEAKNOW/SEAKNOW/Views/Home/EmailService.cshtml"

}

#line default
#line hidden
#nullable disable
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
