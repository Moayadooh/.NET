#pragma checksum "C:\Users\moaya\Documents\.NET\.NET Core\jsPDF\jsPDF\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd63c356ed49773cc279d8769eaa4601059cf8d5"
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
#line 1 "C:\Users\moaya\Documents\.NET\.NET Core\jsPDF\jsPDF\Views\_ViewImports.cshtml"
using jsPDF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moaya\Documents\.NET\.NET Core\jsPDF\jsPDF\Views\_ViewImports.cshtml"
using jsPDF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd63c356ed49773cc279d8769eaa4601059cf8d5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a04935b2bff10a9b8cde9480a923f5d318bbbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\moaya\Documents\.NET\.NET Core\jsPDF\jsPDF\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd63c356ed49773cc279d8769eaa4601059cf8d53452", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 11 "C:\Users\moaya\Documents\.NET\.NET Core\jsPDF\jsPDF\Views\Home\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - CustomPDF</title>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.5.3/jspdf.min.js"" integrity=""sha512-ToRWKKOvhBSS8EtqSflysM/S7v9bB9V0X3B1+E7xo7XZBEZCPL3VX5SFIp8zxY19r7Sz0svqQVbAOx+QcLQSAQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.5.6/jspdf.plugin.autotable.min.js""></script>
    <style>
        th, td {
            text-align: center;
            border: 1px solid black;
            border-collapse: collapse;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd63c356ed49773cc279d8769eaa4601059cf8d55346", async() => {
                WriteLiteral(@"
    <center>
        <h2>TOTAL MARKS OF STUDENTS</h2>
        <br />
        <table id=""simple_table"">
            <tr>
                <th>Roll No.</th>
                <th>Name</th>
                <th>Marks</th>
            </tr>
            <tr>
                <td>1</td>
                <td>?????? ???????? ?????? ???????????? ?????? ????????</td>
                <td>85</td>
            </tr>
            <tr>
                <td>2</td>
                <td>Bhavesh</td>
                <td>72</td>
            </tr>
            <tr>
                <td>3</td>
                <td>Sandhya</td>
                <td>63</td>
            </tr>
            <tr>
                <td>4</td>
                <td>Rohan</td>
                <td>90</td>
            </tr>
            <tr>
                <td>5</td>
                <td>Leena</td>
                <td>82</td>
            </tr>
            <tr>
                <td>6</td>
                <td>Nayan</td>
                <td>56</td>
            </tr");
                WriteLiteral(@">
        </table>
        <br />
        <input type=""button"" onclick=""generate()"" value=""Export To PDF"" />
    </center>
    <script type=""text/javascript"">
        function generate() {
            var doc = new jsPDF('p', 'pt', 'letter');
            var htmlstring = '';
            var tempVarToCheckPageHeight = 0;
            var pageHeight = 0;
            pageHeight = doc.internal.pageSize.height;
            specialElementHandlers = {
                // element with id of ""bypass"" - jQuery style selector
                '#bypassme': function (element, renderer) {
                    // true = ""handled elsewhere, bypass text extraction""
                    return true
                }
            };
            margins = {
                top: 150,
                bottom: 60,
                left: 40,
                right: 40,
                width: 600
            };
            var y = 20;
            doc.setLineWidth(2);
            doc.text(200, y = y + 30, ""?????? ???????? ");
                WriteLiteral(@"?????? ???????????? ?????? ????????"");

            //doc.autoTable({
            //    html: '#simple_table',
            //    startY: 70,
            //    theme: 'grid',
            //    columnStyles: {
            //        0: {
            //            cellWidth: 180,
            //        },
            //        1: {
            //            cellWidth: 180,
            //        },
            //        2: {
            //            cellWidth: 180,
            //        }
            //    },
            //    styles: {
            //        minCellHeight: 40
            //    }
            //})
            //doc.setFontSize(16)
            doc.setFont('Helvetica'); // set font
            doc.autoTable({
                html: '#simple_table',
                //startY: 70,
                //theme: 'grid',
                columnStyles: {
                    0: {
                        cellWidth: 180,
                    },
                    1: {
                        cellWidth:");
                WriteLiteral(@" 180,
                    },
                    2: {
                        cellWidth: 180,
                    }
                },
                styles: {
                    minCellHeight: 40,
                    lang: 'ar', align: 'right'
                },
                //headStyles: { fillColor: '#ffffff', textColor: '#333333', font: ""Amiri"", fontStyle: 'normal', lang: 'ar', align: 'right' },
                //bodyStyles: { fillColor: '#f5f5f5', textColor: '#333333', fontSize: 7, lineColor: '#c7c7c7', lineWidth: 0, font: ""Amiri"", fontStyle: 'normal', lang: 'ar', align: 'right' },




                startY: doc.autoTable() + 70,

                margin: { horizontal: 10 },
                styles: { overflow: ""linebreak"" },
                bodyStyles: { valign: ""top"" },
                columnStyles: { email: { cellWidth: ""wrap"" } },
                theme: ""striped"",
                showHead: ""everyPage"",
                didDrawPage: function (data) {

                    /");
                WriteLiteral(@"/ Header
                    doc.setFontSize(20);
                    doc.setTextColor(40);
                    doc.text(""Report"", data.settings.margin.left, 22);

                    // Footer
                    var str = ""Page "" + doc.internal.getNumberOfPages();

                    doc.setFontSize(10);

                    // jsPDF 1.4+ uses getWidth, <1.4 uses .width
                    var pageSize = doc.internal.pageSize;
                    var pageHeight = pageSize.height
                        ? pageSize.height
                        : pageSize.getHeight();
                    doc.text(str, data.settings.margin.left, pageHeight - 10);
                }
            })

            doc.save('Marks_Of_Students.pdf');
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
