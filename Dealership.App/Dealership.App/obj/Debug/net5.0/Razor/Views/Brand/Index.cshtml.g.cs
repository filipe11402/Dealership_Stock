#pragma checksum "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34606e0b7ef9041a06260c840da1499d842ccbc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Index), @"mvc.1.0.view", @"/Views/Brand/Index.cshtml")]
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
#line 1 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\_ViewImports.cshtml"
using Dealership.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\_ViewImports.cshtml"
using Dealership.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34606e0b7ef9041a06260c840da1499d842ccbc2", @"/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b5fd946d05503d6594acb71fc75662d1c64f91e", @"/Views/_ViewImports.cshtml")]
    public class Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dealership.App.Models.BrandViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"w3-panel\">\r\n    <div class=\"w3-row-padding\" style=\"margin:0 -16px\">\r\n        <div class=\"w3-twothird\">\r\n            <h5>Feeds</h5>\r\n");
#nullable restore
#line 7 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Brand\Index.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th scope=\"col\">Car brand</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Brand\Index.cshtml"
                         for (var counter = 0; counter < Model.Count(); counter++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 19 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Brand\Index.cshtml"
                                           Write(Model.ToList()[counter].CarBrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Brand\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 24 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Brand\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No Data in Db</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dealership.App.Models.BrandViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
