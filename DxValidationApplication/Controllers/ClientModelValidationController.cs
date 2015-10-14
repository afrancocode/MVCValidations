using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DxValidationApplication.Models.ModelValidation;

namespace DxValidationApplication.Controllers
{
	public class ClientModelValidationController : Controller
	{
		public ActionResult Play()
		{
			return View(new DataViewModel());
		}

		[HttpPost]
		public ActionResult DoValidate(DataViewModel model)
		{
			if (ModelState.IsValid)
				return View("Info", model);
			return View("Play", model);
		}
	}
}
