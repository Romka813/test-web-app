using System.Web.Optimization;

namespace WebApp.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/main").Include("~/Scripts/main_page.js"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap-js").Include("~/Scripts/bootstrap.js"));
			bundles.Add(new StyleBundle("~/bundles/style").Include("~/Content/style.css"));
			bundles.Add(new StyleBundle("~/bundles/bootstrap").Include("~/Content/bootstrap.css"));
		}
	}
}
