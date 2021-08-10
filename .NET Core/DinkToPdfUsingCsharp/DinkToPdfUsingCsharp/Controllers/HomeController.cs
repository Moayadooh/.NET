using DinkToPdf;
using DinkToPdf.Contracts;
using DinkToPdfUsingCsharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinkToPdfUsingCsharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConverter _converter;

        public HomeController(ILogger<HomeController> logger, IConverter converter)
        {
            _logger = logger;
            this._converter = converter;
        }

        //DinkToPdf:
        //https://github.com/rdvojmoc/DinkToPdf

        public IActionResult Index()
        {
            var result = GetHTMLString();
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 8, Right = 8, Left = 8 },
                DocumentTitle = "invitation Letter"
            };
            //var agm = await _apiClient.GetAgmAsync(reference);
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = result,
                //IncludeInOutline = true,
                //Page = "http://localhost:9990/en/Issuer/Services/test1",
                //WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, HtmUrl = null, Left = null, Center = "Title", Right = "Page [page] of [toPage]", Line = true },
                WebSettings = { DefaultEncoding = "utf-8" },
                //HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 },
                FooterSettings = { FontName = "Arial", FontSize = 9, Center = "[page]" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            var file = _converter.Convert(pdf);
            return File(file, "application/pdf");
        }

        public string GetHTMLString()
        {

            var sb = new StringBuilder();
            sb.Append(@"<center><table border=1>
                                    <tr>
                <th>Roll No.</th>
                <th>Name</th>
                <th>Marks</th>
            </tr>
            <tr>
                <td>1</td>
                <td>انا الذي نظر الاعمى الى ادبي</td>
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
                                  </table></center>");
            return sb.ToString();
            //sb.Append(@"
            //            <html>
            //                <head>
            //                    <meta charset='utf-8'>
            //                </head>
            //                <body>");
            //sb.Append(@"

            //                </body>
            //            </html>");

            //foreach (var inv in sl)
            //{
            //                sb.AppendFormat(@"<table class='top_table_inv'>
            //                                    <tr><td>أسم المساهم : {0}</td></tr>
            //                                    <tr><td>العنوان : ص.ب : {1}, ر.م : {2}, {3}</td></tr>                                    
            //                                    <tr><td>الدولة : {4}</td></tr>
            //                                    <tr><td>رقم المساهم : {5}</td></tr>
            //                                    <tr><td>رمز الترقيم الدولي : {6}</td></tr>
            //                                  </table>
            //                                <div style='text-align: right;direction: rtl;'>
            //                                    <table class='center_table_inv'>
            //                                    <tr><td>الاسهم : {7}</td></tr>
            //                                  </table>
            //                                </div>
            //                                <table class='bottom_table_inv'>
            //                                    <tr><td><img id='img' src='{9}' runat='server' alt='' /></td></tr>          
            //                                    < tr><td>{5}</td><td>{8}</td><td>{7}</td></tr>
            //                                    <tr><td>{0}</td></tr> 
            //                                  </table>
            //<div style='page-break-after: always;'></div>", inv.InvestorName, inv.PostalCode, inv.PostOfficeBox, inv.City,
            //        inv.Country, inv.InvestorID, inv.ISIN, inv.Shares, DateTime.Now.ToString("dd/MM/yyyy"), inv.QR_Code);
            //}

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
