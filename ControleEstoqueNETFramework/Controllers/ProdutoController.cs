using ControleEstoqueNETFramework.DAO;
using ControleEstoqueNETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueNETFramework.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var dao = new ProdutoDAO();
            
            return View(dao.Select());
        }

        public ActionResult Form()
        {
            var dao = new CategoriaProdutoDAO();
            ViewBag.Categorias = dao.Select();

            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {

            var dao = new CategoriaProdutoDAO();

            CategoriaProduto categoria = dao.SelectId(produto.Categoria.Id);
            categoria.Produtos.Add(produto);
            dao.Update(categoria);
            
            return RedirectToAction("Index");
        }
    }
}