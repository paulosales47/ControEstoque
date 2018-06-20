using ControleEstoqueNETFramework.DAO;
using ControleEstoqueNETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueNETFramework.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String Login, String Senha)
        {
            var dao = new UsuarioDAO();
            var usuario = new Usuario
            {
                Nome = Login
                ,
                Senha = Senha
            };

            var UsuarioLogin = dao.Login(usuario);

            if (UsuarioLogin is null)
            {
                return RedirectToAction("Index");
            }

            Session["usuarioLogado"] = UsuarioLogin;
            return RedirectToAction("Index", "Produto");
        }
    }
}