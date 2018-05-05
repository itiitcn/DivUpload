using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DivUpload.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            HttpFileCollectionBase File = Request.Files;
            string FileName = "/images/img/"+DateTime.Now.ToString("YYYYMMDDHHmmssfff");
            if (File != null && File.Count > 0)
            {
                FileName += System.IO.Path.GetExtension(File[0].FileName);
                File[0].SaveAs(Server.MapPath(FileName));
            }
            return Json(FileName);
        }

    }
}
