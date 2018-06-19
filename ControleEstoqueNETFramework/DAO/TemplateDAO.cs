using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoqueNETFramework.DAO
{
    public abstract class TemplateDAO
    {
        public void Insert(dynamic obj)
        {
            using (var context = new EstoqueContext())
            {
                using (var contextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        VerificaTipoObjeto(obj);
                        this.Insert(context, obj);
                        context.SaveChanges();

                        contextTransaction.Commit();
                    }
                    catch (Exception Ex)
                    {
                        contextTransaction.Rollback();
                        throw Ex;
                    }
                }
            }
        }

        public void Update(dynamic obj)
        {
            using (var context = new EstoqueContext())
            {
                using (var contextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        VerificaTipoObjeto(obj);
                        this.Update(context, obj);
                        context.SaveChanges();

                        contextTransaction.Commit();
                    }
                    catch (Exception Ex)
                    {
                        contextTransaction.Rollback();
                        throw Ex;
                    }
                }
            }
        }

        public void Delete(dynamic obj)
        {
            using (var context = new EstoqueContext())
            {
                using (var contextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        VerificaTipoObjeto(obj);
                        this.Delete(context, obj);

                        context.SaveChanges();
                        contextTransaction.Commit();
                    }
                    catch (Exception Ex)
                    {
                        contextTransaction.Rollback();
                        throw Ex;
                    }
                }
            }
        }

        public dynamic Select()
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    return this.Select(context);
                }

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public dynamic SelectId(dynamic obj)
        {
            try
            {
                int Id = (int)obj;

                using (var context = new EstoqueContext())
                {
                    return this.SelectId(context, Id);
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        protected void ErroArgumento()
        {
            throw new ArgumentException($"O parametro deve ser do tipo {this}");
        }
        protected abstract void VerificaTipoObjeto(dynamic obj);
        protected abstract void Insert(EstoqueContext context, dynamic obj);
        protected abstract void Update(EstoqueContext context, dynamic obj);
        protected abstract void Delete(EstoqueContext context, dynamic obj);
        protected abstract dynamic Select(EstoqueContext context);
        protected abstract dynamic SelectId(EstoqueContext context, int Id);

    }
}