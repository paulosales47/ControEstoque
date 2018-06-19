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
            ListaCategoria();
            ViewBag.produto = new Produto();
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            if (ProdutoValido(produto))
            {
                var dao = new CategoriaProdutoDAO();
                CategoriaProduto categoria = dao.SelectId(produto.Categoria.Id);
                categoria.Produtos.Add(produto);
                dao.Update(categoria);

                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ListaCategoria();
                ViewBag.produto = produto;
                return View("Form");
            }
        }

        public ActionResult Visualiza(int id)
        {
            var dao = new ProdutoDAO();
            ViewBag.produto = dao.SelectId(id);
            return View();
        }


        private void ListaCategoria()
        {
            var dao = new CategoriaProdutoDAO();
            ViewBag.Categorias = dao.Select();
        }

        private bool ProdutoValido(Produto produto)
        {
            bool categoriaValida = (produto.Categoria.Id > 0);

            if (!categoriaValida)
                ModelState.AddModelError("categoria", "Categoria inválida");
            
            return (
                       ModelState.IsValid
                    && categoriaValida
                   );
        }
    }
}