// <copyright file="BaseController.cs" company="CTS">
// Copyright (c) . All rights reserved.
// </copyright>
// <summary>
// Filter Config
// </summary>
//-----------------------------------------------------------------------
namespace Stationery.Web.Controllers
{   
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CWR.Utility;

    /// <summary>
    /// To define Base controller class
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// To get exception
        /// </summary>
        /// <param name="filterContext">filter Context</param>
        protected override void OnException(ExceptionContext filterContext)
        {
            //// get exception
            base.OnException(filterContext);
            //ExceptionLogger.LogException(filterContext.Exception);
        }
    }
}
