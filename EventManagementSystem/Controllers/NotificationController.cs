﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagementSystem.Controllers
{
    public class NotificationController : Controller
    {
        // GET: Notification
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}