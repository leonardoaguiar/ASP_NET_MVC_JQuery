using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialMVCJquery.Controllers
{
    public class CadastroController : Controller
    {
        //
        // GET: /Cadastro/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Cadastrar(FormCollection formulario)
        {
            string retorno = null;
            retorno = "Nome: " + formulario["nome"] + " Email: " + formulario["email"];
            return retorno;
        }

    }
}
