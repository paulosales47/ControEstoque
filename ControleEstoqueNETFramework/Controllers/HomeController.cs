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
            //var dao = new UsuarioDAO();

            //var entidade = new Usuario
            //{
            //    Nome = "Paulo Henrique Sales Sampaio"
            //    ,
            //    Senha = "123456"
            //};

            //dao.Insert(entidade);

            //var usuarios = dao.Select();

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