using ControleEstoqueNETFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoqueNETFramework.DAO
{
    public class ProdutoDAO : TemplateDAO
    {
        protected override void Insert(EstoqueContext context, dynamic obj)
        {
            context.Produtos.Add(obj);
        }

        protected override void Update(EstoqueContext context, dynamic obj)
        {
            context.Produtos.Update(obj);
        }

        protected override void Delete(EstoqueContext context, dynamic obj)
        {
            context.Produtos.Remove(obj);
        }

        protected override dynamic Select(EstoqueContext context)
        {
            return context.Produtos
                .Include(produto => produto.Categoria)
                .ToList();
                
        }

        protected override dynamic SelectId(EstoqueContext context, int Id)
        {
            return context.Produtos
                .Where(produto => produto.Id == Id)
                .Include(produto => produto.Categoria)
                .First();
        }

        protected override void VerificaTipoObjeto(dynamic obj)
        {
            if (!(obj is Produto))
            {
                ErroArgumento();
            }
        }
    }
}