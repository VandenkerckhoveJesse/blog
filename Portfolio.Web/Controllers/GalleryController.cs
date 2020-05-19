using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Controllers
{
    public class GalleryController : Controller
    {
        private IHostingEnvironment _env;

        // inject a hosting env so that we can get the wwwroot path
        public GalleryController(IHostingEnvironment env)
        {
            this._env = env;
        }

        // GET: Gallery
        public ActionResult Index()
        {
            var rootDir = this._env.WebRootPath + "/images/gallery";
            var allowedExtensions = new String[] { ".png", ".jpg" };
            var baseUrl = "/images/gallery";

            var imgUrls = Directory.EnumerateFiles(rootDir, "*.*", SearchOption.AllDirectories)
                .Where(fileName => allowedExtensions.Any(extension => fileName.EndsWith(extension)))
                .Select(fileName => Path.GetRelativePath(rootDir, fileName))
                .Select(fileName => Path.Combine(baseUrl, fileName))
                .Select(fileName => fileName.Replace("\\", "/"));


            return View(imgUrls);
        }


    }
}