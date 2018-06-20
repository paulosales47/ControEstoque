using ControleEstoqueNETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoqueNETFramework.DAO
{
    public class UsuarioDAO : TemplateDAO
    {
        protected override void Insert(EstoqueContext context, dynamic obj)
        {
            context.Usuarios.Add(obj);
        }

        protected override void Update(EstoqueContext context, dynamic obj)
        {
            context.Update(obj);
        }

        protected override void Delete(EstoqueContext context, dynamic obj)
        {
            context.Usuarios.Remove(obj);
        }

        protected override dynamic Select(EstoqueContext context)
        {
            return context.Usuarios.ToList();
        }

        protected override dynamic SelectId(EstoqueContext context, int Id)
        {
            return context.Usuarios
                .Where(usuario => usuario.Id == Id)
                .First();
        }

        protected override void VerificaTipoObjeto(dynamic obj)
        {
            if (!(obj is Usuario))
            {
                ErroArgumento();
            }
        }

        public Usuario Login(Usuario entidade)
        {
            using (var context = new EstoqueContext())
            {
                var usuario = context.Usuarios
                    .Where(u => u.Nome.Equals(entidade.Nome) && u.Senha.Equals(entidade.Senha))
                    .FirstOrDefault();

                return usuario;
            }
        }
    }
}