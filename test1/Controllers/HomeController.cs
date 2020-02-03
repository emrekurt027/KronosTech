using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using test1.Models;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ILogger<HomeController> _logger;

        protected List<ReferenceSrc> Reflist = null;
        protected List<Product> ProductList = null;
        protected List<Appfield> AppFieldList = null;
        protected List<string> ProductNameList = null;
        protected List<string> AppfieldNameList = null;
        protected List<GalleryModel> GalleryList = null;

        public HomeController(IStringLocalizer<HomeController> localizer,
    ILogger<HomeController> logger)
        {
            //localization
            _localizer = localizer;
            _logger = logger;

            //read References
            using (StreamReader r = new StreamReader(@"Simulation\ref.json"))
            {
                string json = r.ReadToEnd();
                Reflist = JsonConvert.DeserializeObject<List<ReferenceSrc>>(json);
            }

            //Data Root for lang
            string appSRC = "";
            string productSRC = "";
            string gallerySRC = "";

            if (CultureInfo.CurrentCulture.TextInfo.CultureName == "en-US")
            {
                appSRC = @"Simulation\application_en.json";
                productSRC = @"Simulation\products_en.json";
                gallerySRC = @"Simulation\gallery_en.json";
            }
            else
            {
                appSRC = @"Simulation\application_tr.json";
                productSRC = @"Simulation\products_tr.json";
                gallerySRC = @"Simulation\gallery_tr.json";

            }

            //read Product
            using (StreamReader r = new StreamReader(productSRC, System.Text.Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                ProductList = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            ProductNameList = new List<string>();
            foreach (var item in ProductList)
            {
                ProductNameList.Add(item.name);
            }

            //read ApplicationField
            using (StreamReader r = new StreamReader(appSRC, System.Text.Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                AppFieldList = JsonConvert.DeserializeObject<List<Appfield>>(json);
            }
            AppfieldNameList = new List<string>();
            foreach (var item in AppFieldList)
            {
                AppfieldNameList.Add(item.name);
            }

            //read Gallery
            using (StreamReader r = new StreamReader(gallerySRC, System.Text.Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                GalleryList = JsonConvert.DeserializeObject<List<GalleryModel>>(json);
            }
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {   //global Viewbag
            ViewBag.appNameList = AppfieldNameList;
            ViewBag.appFieldList = AppFieldList;
            base.OnActionExecuting(context);
        }
        [Route("")]
        [Route("Home")]
        [Route("Anasayfa")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        [Route("Hakkında")]
        public IActionResult About()
        {
            return View(GalleryList.Where(p => p.id == 0).SingleOrDefault());
        }

        [Route("References")]
        [Route("Referanslar")]
        public IActionResult Reference()
        {
            return View(Reflist);
        }

        [Route("Vision")]
        [Route("Vizyon")]
        public IActionResult Vision()
        {
            return View(Reflist);
        }
        [Route("Enviroment-Quality")]
        [Route("Çevre-Kalite")]
        public IActionResult Enviroment()
        {
            return View(Reflist);
        }

        [Route("Healt-Safety-Security-Enviroment")]
        [Route("Sağlık-Emniyet-Çevre")]
        public IActionResult SECG()
        {
            return View(Reflist);
        }

        [Route("Products")]
        [Route("Ürünler")]
        public IActionResult Product()
        {
            return View(ProductList);
        }

        [Route("Products/{id:int}")]
        [Route("Ürünler/{id:int}")]
        public IActionResult ProductDetails(int id = 1)
        {
            ProductShowModel model = new ProductShowModel();
            model.Product = ProductList.Where(p => p.id == id).SingleOrDefault();
            model.ProductNameList = ProductNameList;
            return View(model);
        }


        [Route("Applications")]
        [Route("Uygulamalar")]
        public IActionResult Appfield()
        {
            return View(AppFieldList);
        }

        [Route("Applications/{name}")]
        [Route("Uygulamalar/{name}")]
        public IActionResult AppfieldDetails(string name)
        {
            AppfieldShowmodel model = new AppfieldShowmodel();
            model.Appfield = AppFieldList.Where(p => p.name == name).SingleOrDefault();
            model.AppFieldNameList = AppfieldNameList;
            return View(model);
        }

        [Route("Gallery")]
        [Route("Galeri")]
        public IActionResult Gallery()
        {
            return View(GalleryList);
        }

        [Route("Gallery/{id:int}")]
        [Route("Galeri/{id:int}")]
        public IActionResult GalleryDetails(int id)
        {
            GalleryModel model = GalleryList.Where(p => p.id == id).SingleOrDefault();
            return View(model);
        }

        [Route("Contact")]
        [Route("İletisim")]
        [HttpGet]
        public IActionResult Contact()
        {

            return View();
        }

        [Route("Contact")]
        [Route("İletisim")]
        [HttpPost]
        public async Task<IActionResult> Contact(MailModel model)
        {
            if (ModelState.IsValid)
            {
                await Services.MailOperations.receivedMail(model, _localizer.GetString("Mail.Subject"), _localizer.GetString("Mail.Body"));
                return View();
            }
            return View(model);
        }

        public IActionResult SetLanguage(string culture)
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), options);
            return RedirectToAction("Index");
        }
    }
}