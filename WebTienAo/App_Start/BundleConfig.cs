using System.Web;
using System.Web.Optimization;

namespace WebTienAo
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));

			// Css Admin
			bundles.Add(new StyleBundle("~/Areas/Admin/assets/vendor/bootstrap/css").Include(
				"~/Areas/Admin/assets/vendor/bootstrap/css/bootstrap.min.css",
				"~/Areas/Admin/assets/vendor/metisMenu/metisMenu.min.css",
				"~/Areas/Admin/assets/dist/css/sb-admin-2.css",
				"~/Areas/Admin/assets/vendor/font-awesome/css/font-awesome.min.css"
				));
			bundles.Add(new ScriptBundle("~/Areas/Admin/assets/jquery").Include(
				 "~/Areas/Admin/assets/vendor/jquery/jquery.min.js"
				));
			// Script Admin
			bundles.Add(new ScriptBundle("~/Areas/Admin/assets/Script").Include(
					  "~/Areas/Admin/assets/vendor/bootstrap/js/bootstrap.min.js",
					  "~/Areas/Admin/assets/vendor/metisMenu/metisMenu.min.js",
					  "~/Areas/Admin/assets/dist/js/sb-admin-2.js"));
			// Css Admin Index Morris Charts CSS
			bundles.Add(new StyleBundle("~/Areas/Admin/Index/Css").Include(
				"~/Areas/Admin/assets/vendor/morrisjs/morris.css"
				));

			bundles.Add(new ScriptBundle("~/Areas/Admin/Index/Script").Include(
					   "~/Areas/Admin/assets/vendor/raphael/raphael.min.js",
					  "~/Areas/Admin/assets/vendor/morrisjs/morris.min.js",
					  "~/Areas/Admin/assets/data/morris-data.js"
					  ));
		}
	}
}
