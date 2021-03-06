﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace testumbraco.Controller
{
    public class HomeController : SurfaceController
    {
        // GET: Home

        private const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Home/";
        public ActionResult RenderFeatured()
        {
            return PartialView(PARTIAL_VIEW_FOLDER+"_Featured.cshtml");
        }

        public ActionResult RenderSevices()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Services.cshtml");
        }

        public ActionResult RenderBlog()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Blog.cshtml");
        }

        public ActionResult RenderClients()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Client.cshtml");
        }
    }
}