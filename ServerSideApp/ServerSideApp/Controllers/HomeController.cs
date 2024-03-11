using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;

namespace ServerSideApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }
        

        public IActionResult DocumentViewer(
            [FromServices] IWebDocumentViewerClientSideModelGenerator viewerModelGenerator,
            [FromQuery] string reportName) {
            reportName = string.IsNullOrEmpty(reportName) ? "TestReport" : reportName;
            var viewerModel = viewerModelGenerator.GetModel(reportName, CustomWebDocumentViewerController.DefaultUri);
            return View(viewerModel);
        }
    }
}