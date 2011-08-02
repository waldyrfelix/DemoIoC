using System.Web.Mvc;
using DemoIoC.Domain;

namespace DemoIoC.Web.Controllers
{
    public class HomeController : Controller
    {
        public IProductService ProductService { get; set; }

        public HomeController(IProductService productService)
        {
            this.ProductService = productService;

            // OBTENDO INSTANCIA COM SERVICE LOCATOR
            // this.productService = ServiceLocator.Resolve<IProductService>();
        }

        public ActionResult Index()
        {
            var products = ProductService.GetAllActiveProducts();
            return View(products);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
