﻿using ControleEstoqueNETFramework.Filters;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueNETFramework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
