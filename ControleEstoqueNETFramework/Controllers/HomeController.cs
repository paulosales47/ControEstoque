using ControleEstoqueNETFramework.DAO;
using ControleEstoqueNETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueNETFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var daoCategoria = new CategoriaProdutoDAO();

            //var entidade = new CategoriaProduto
            //{
            //    Descricao = "Produtos de informática"
            //    ,
            //    Nome = "Informática"
            //};

            //daoCategoria.Insert(entidade);

            //var daoProduto = new ProdutoDAO();

            //var entidadeProduto = new Produto
            //{
            //    Nome = "Placa de vídeo"
            //    ,
            //    Descricao = "NVIDIA GTX 1080TI"
            //    ,
            //    Preco = 3500
            //    ,
            //    Quantidade = 3
            //    ,
            //    Categoria = entidade
            //};

            //daoProduto.Insert(entidadeProduto);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}