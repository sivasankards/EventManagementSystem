﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagementSystem.Controllers
{
    public class FriendsController : Controller
    {
        // GET: Friends
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}