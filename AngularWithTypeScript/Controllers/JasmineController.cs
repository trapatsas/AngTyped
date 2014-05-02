using System;
using System.Web.Mvc;

namespace AngularWithTypeScript.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
