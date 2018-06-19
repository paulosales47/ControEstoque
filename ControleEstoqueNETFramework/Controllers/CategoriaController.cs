using ControleEstoqueNETFramework.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueNETFramework.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var dao = new CategoriaProdutoDAO();

            return View(dao.Select());
        }
    }
}