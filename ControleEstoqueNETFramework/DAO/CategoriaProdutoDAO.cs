using ControleEstoqueNETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoqueNETFramework.DAO
{
    public class CategoriaProdutoDAO : TemplateDAO
    {
        protected override void Delete(EstoqueContext context, dynamic obj)
        {
            context.CategoriaProdutos.Remove(obj);
        }

        protected override void Insert(EstoqueContext context, dynamic obj)
        {
            context.CategoriaProdutos.Add(obj);
        }

        protected override dynamic Select(EstoqueContext context)
        {
            return context.CategoriaProdutos.ToList();
        }

        protected override dynamic SelectId(EstoqueContext context, int Id)
        {
            return context.CategoriaProdutos
                .Where(ct => ct.Id == Id)
                .First();
        }

        protected override void Update(EstoqueContext context, dynamic obj)
        {
            context.CategoriaProdutos.Update(obj);
        }

        protected override void VerificaTipoObjeto(dynamic obj)
        {
            if (!(obj is CategoriaProduto))
            {
                ErroArgumento();
            }
        }
    }
}