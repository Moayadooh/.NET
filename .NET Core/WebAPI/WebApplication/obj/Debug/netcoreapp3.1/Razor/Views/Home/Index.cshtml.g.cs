#pragma checksum "C:\Users\moaya\Documents\.NET\.NET Core\WebAPI\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f80e051244662d3a9fb6de5a871f7c4c689d73fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\moaya\Documents\.NET\.NET Core\WebAPI\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f80e051244662d3a9fb6de5a871f7c4c689d73fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af4f83a82d48dc1960075312910d3055ea16ddc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\moaya\Documents\.NET\.NET Core\WebAPI\WebApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row text-center"">
        <div class=""col-md-4 form-group"">

        </div>
        <div class=""col-md-4 form-group"">
            <h1>COUNTRIES</h1>
        </div>
        <div class=""col-md-4 form-group"">

        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6 form-group"">
            <input type=""hidden"" id=""ID""");
            BeginWriteAttribute("value", " value=\"", 438, "\"", 446, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            <input type=""text"" class=""form-control"" id=""txtName"" placeholder=""Country Name"" />
        </div>
        <div class=""col-md-6 form-group"">
            <input type=""text"" class=""form-control"" id=""txtContinent"" placeholder=""Continent"" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""form-group"">
                <button class=""form-control btn btn-success"" id=""btnAdd"" type=""button"">
                    <i class=""fas fa-plus""></i> Add New Country
                </button>
            </div>
            <div class=""form-group"">
                <button class=""form-control btn btn-primary"" id=""btnSave"" type=""button"">
                    <i class=""fas fa-save""></i> Save Changes
                </button>
            </div>
            <div class=""form-group"">
                <button class=""form-control btn btn-danger"" id=""btnCancel"" type=""button"">
                    <i class=""fas fa-ban""></i> Cancel
                </butt");
            WriteLiteral("on>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div id=\"table\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
