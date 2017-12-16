using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Dao;
using Models.EF;

namespace WebTienAo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			USER user = new USER();
			UserDao dao = new UserDao();
			user = dao.selectUserbyId(1);

			//ViewBag.Message = user.Name;
			ViewBag.abc = user.Password;

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}