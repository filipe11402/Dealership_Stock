#pragma checksum "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4318659a376a73039435ffee52128c59b69627b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4318659a376a73039435ffee52128c59b69627b2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b5fd946d05503d6594acb71fc75662d1c64f91e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-bar-item w3-button w3-padding w3-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-light-grey"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4318659a376a73039435ffee52128c59b69627b24824", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 4 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Dealership.App</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <style>
        html, body, h1, h2, h3, h4, h5 {
            font-family: ""Raleway"", sans-serif
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4318659a376a73039435ffee52128c59b69627b26620", async() => {
                WriteLiteral(@"

    <!-- Top container -->
    <div class=""w3-bar w3-top w3-black w3-large"" style=""z-index:4"">
        <button class=""w3-bar-item w3-button w3-hide-large w3-hover-none w3-hover-text-light-grey"" onclick=""w3_open();""><i class=""fa fa-bars""></i> &nbsp;Menu</button>
        <span class=""w3-bar-item w3-right"">Logo</span>
    </div>

<!-- Sidebar/menu -->
<nav class=""w3-sidebar w3-collapse w3-white w3-animate-left"" style=""z-index:3;width:300px;"" id=""mySidebar"">
    <br>
    <div class=""w3-container w3-row"">
        <div class=""w3-col s4"">
            <img src=""/w3images/avatar2.png"" class=""w3-circle w3-margin-right"" style=""width:46px"">
        </div>
        <div class=""w3-col s8 w3-bar"">
            <span>Welcome, <strong>Mike</strong></span><br>
            <a href=""#"" class=""w3-bar-item w3-button""><i class=""fa fa-envelope""></i></a>
            <a href=""#"" class=""w3-bar-item w3-button""><i class=""fa fa-user""></i></a>
            <a href=""#"" class=""w3-bar-item w3-button""><i class=""fa fa-cog""></i");
                WriteLiteral(@"></a>
        </div>
    </div>
    <hr>
    <div class=""w3-container"">
        <h5>Dashboard</h5>
    </div>
    <div class=""w3-bar-block"">
        <a href=""#"" class=""w3-bar-item w3-button w3-padding-16 w3-hide-large w3-dark-grey w3-hover-black"" onclick=""w3_close()"" title=""close menu""><i class=""fa fa-remove fa-fw""></i>&nbsp; Close Menu</a>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4318659a376a73039435ffee52128c59b69627b28357", async() => {
                    WriteLiteral("<i class=\"fa fa-users fa-fw\"></i>&nbsp; Create New Model");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
</nav>


<!-- Overlay effect when opening sidebar on small screens -->
<div class=""w3-overlay w3-hide-large w3-animate-opacity"" onclick=""w3_close()"" style=""cursor:pointer"" title=""close side menu"" id=""myOverlay""></div>

<!-- !PAGE CONTENT! -->
<div class=""w3-main"" style=""margin-left:300px;margin-top:43px;"">
<!-- Header -->
<header class=""w3-container"" style=""padding-top:22px"">
    <h5><b><i class=""fa fa-dashboard""></i> My Dashboard</b></h5>
</header>
    ");
#nullable restore
#line 58 "C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.App\Dealership.App\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer class=""w3-container w3-padding-16 w3-light-grey"">
        <h4>FOOTER</h4>
        <p>Powered by <a href=""https://www.w3schools.com/w3css/default.asp"" target=""_blank"">w3.css</a></p>
    </footer>
    <!-- End page content -->
</div>

    <script>
        // Get the Sidebar
        var mySidebar = document.getElementById(""mySidebar"");

        // Get the DIV with overlay effect
        var overlayBg = document.getElementById(""myOverlay"");

        // Toggle between showing and hiding the sidebar, and add overlay effect
        function w3_open() {
            if (mySidebar.style.display === 'block') {
                mySidebar.style.display = 'none';
                overlayBg.style.display = ""none"";
            } else {
                mySidebar.style.display = 'block';
                overlayBg.style.display = ""block"";
            }
        }

        // Close the sidebar with the close button
        function w3_close() {
            mySidebar.style.display = ""none"";
");
                WriteLiteral("            overlayBg.style.display = \"none\";\r\n        }\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
