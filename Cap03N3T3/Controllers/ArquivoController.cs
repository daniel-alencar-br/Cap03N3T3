using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cap03N3T3.Controllers
{
    public class ArquivoController : Controller
    {
        public ActionResult pesquisar(int anopesquisa)
        {
            if (anopesquisa < 2000) 
                return View("Antes2000");
            else
                return View("Atual");             
        }
    }
}