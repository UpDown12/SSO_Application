#pragma checksum "E:\Study and work\OAuth2.0\SSO_Application\Auth.System\ClientApi\Views\Home\GetSecret.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9005a7cfca71b9c750d7240034a35c63b8a69abe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetSecret), @"mvc.1.0.view", @"/Views/Home/GetSecret.cshtml")]
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
#line 1 "E:\Study and work\OAuth2.0\SSO_Application\Auth.System\ClientApi\Views\_ViewImports.cshtml"
using ClientApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Study and work\OAuth2.0\SSO_Application\Auth.System\ClientApi\Views\_ViewImports.cshtml"
using ClientApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9005a7cfca71b9c750d7240034a35c63b8a69abe", @"/Views/Home/GetSecret.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"083185ea8e8cf3bf99443fb71930511b38d19a55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetSecret : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n");
#nullable restore
#line 2 "E:\Study and work\OAuth2.0\SSO_Application\Auth.System\ClientApi\Views\Home\GetSecret.cshtml"
     if (!string.IsNullOrEmpty(ViewData["Message"]?.ToString()))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 4 "E:\Study and work\OAuth2.0\SSO_Application\Auth.System\ClientApi\Views\Home\GetSecret.cshtml"
      Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 5 "E:\Study and work\OAuth2.0\SSO_Application\Auth.System\ClientApi\Views\Home\GetSecret.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Nothing Found</p>\r\n");
#nullable restore
#line 9 "E:\Study and work\OAuth2.0\SSO_Application\Auth.System\ClientApi\Views\Home\GetSecret.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
