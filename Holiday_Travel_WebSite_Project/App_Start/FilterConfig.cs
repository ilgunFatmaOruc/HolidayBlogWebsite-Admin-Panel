﻿using System.Web;
using System.Web.Mvc;

namespace Holiday_Travel_WebSite_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
