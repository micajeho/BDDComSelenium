using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IRPF.Controllers.IR
{
    public class IRController : Controller
    {
        //
        // GET: /IR/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.Irpf irpf)
        {
            irpf.CalcularValorIrpf();
            return View(irpf);
        }

    }
}
