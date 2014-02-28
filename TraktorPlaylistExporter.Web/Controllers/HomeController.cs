using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IvanZ.Traktor;
using TraktorPlaylistExporter.Web.Commands;

namespace TraktorPlaylistExporter.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Export(HttpPostedFileBase file)
        {
            if (file == null) {
                ViewBag.Message = "You need to upload your COLLECTION.NML file to proceed";
                return View("Index");
            }

            MemoryStream collectionMemoryStream = new MemoryStream();
            file.InputStream.CopyTo(collectionMemoryStream);
            collectionMemoryStream.Position = 0;

            MemoryStream zipStream = new MemoryStream();
            new CollectionToM3uExporter(new Collection(collectionMemoryStream)).Export(zipStream);
            zipStream.Position = 0;

            return File(zipStream, "application/octet-stream", "TraktorExported.zip");
        }
    }
}