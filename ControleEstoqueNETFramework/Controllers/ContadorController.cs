using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueNETFramework.Controllers
{
    public class ContadorController : Controller
    {
        public ActionResult Index()
        {

            var contador = Session["contador"];
            int qtdAcessos = Convert.ToInt32(contador);
            qtdAcessos++;
            Session["contador"] = qtdAcessos;

            return View(qtdAcessos);
        }
    }
}