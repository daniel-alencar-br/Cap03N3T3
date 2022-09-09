using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.IO;

namespace Cap03N3T3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
               
        public ActionResult Alunos()
        {
            // BD ou outro lugar

            ViewBag.Codigo = "1";       //
            ViewData["Nome"] = "Joao";  // apagam em seguida

            Session["Idade"] = "15";    // enquanto sessão no ar
            
            return View();
        }

        public string NomesXML()
        {
            string sCaminho = Server.MapPath("~/Arqs/ArqXML.xml");

            XmlDocument Doc = new XmlDocument();
            Doc.Load(sCaminho);

            XmlNodeList Lista = Doc.GetElementsByTagName("aluno");

            string sNomes = "";

            foreach (XmlNode Item in Lista)
                sNomes += Item["nome"].InnerText;

            return sNomes;
        }

        public string Ola()
        {
            return "Ola!!!!";
        }
        public string Dados()
        {
            return "<aluno><cod>1</cod></aluno>";
        }
        public ActionResult Foto()
        {
            var Arq = Server.MapPath("~/Arqs/Img01.jpg");
            return base.File(Arq, "image/jpeg");
        }
        public ActionResult Doc()
        {
            var Arq = Server.MapPath("~/Arqs/Doc01.pdf");
            return base.File(Arq, "application/pdf");
        }

        public ActionResult VerArquivo()
        {
            StreamReader Arq = 
                new StreamReader(Server.MapPath("~/Arqs/Texto.txt"));

            //ViewBag.Arquivo = Arq.ReadToEnd();

            string sConteudo = "";

            while (Arq.Peek() != -1)
               sConteudo += Arq.ReadLine() + " - ";

            ViewBag.Arquivo = sConteudo;

            return View();
        }

    }
}









