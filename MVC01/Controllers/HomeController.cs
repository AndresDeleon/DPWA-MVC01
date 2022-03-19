using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentHtml()
        {
            string contenidoHtml = "<html><head><title>Prueba de Content </title></head><body><p> Esto es una respuesta Content HTML</p></body></html> ";
            return Content(contenidoHtml);
        }

        public ActionResult ObtenerPdf(string id)
        {
            return File(Server.MapPath("~/Files/" + id + ".pdf"),
            "application/pdf");
        }

        public ActionResult RedireccionHttp(string server, string domain)
        {
            return Redirect("http://" + server + "." + domain);
        }

        public ActionResult BuscarComic(string id)
        {
            return RedirectToAction("Buscar", "Productos", new
            {
                tipoProducto = "Comics"
            ,
                nombreProducto = id
            });
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}