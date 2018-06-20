using ControleEstoqueNETFramework.DAO;
using ControleEstoqueNETFramework.Filters;
using ControleEstoqueNETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueNETFramework.Controllers
{
    [AutorizacaoFilter]
    public class ProdutoController : Controller
    {
        // GET: Produto
        [Route("produtos", Name="ListaProdutos")]
        public ActionResult Index()
        {
            var dao = new ProdutoDAO();
            
            return View(dao.Select());
        }

        [Route("produtos/form")]
        public ActionResult Form()
        {
            ListaCategoria();
            ViewBag.produto = new Produto();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        [Route("produtos/{id}", Name="VisualizaProduto")]
        public ActionResult Visualiza(int id)
        {
            var dao = new ProdutoDAO();
            ViewBag.produto = dao.SelectId(id);
            return View();
        }
        
        [HttpPost]
        public ActionResult DecrementaProduto(int id)
        {
            var dao = new ProdutoDAO();
            Produto entidade = dao.SelectId(id);
            entidade.Quantidade--;
            dao.Update(entidade);

            entidade.Categoria.Produtos = null;
            return Json(entidade);
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