using System.Web.Mvc;

namespace WebTienAo.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
				namespaces: new[] { "WebTienAo.Areas.Admin.Controllers" } // Insert area namespace here
			);
        }
    }
}