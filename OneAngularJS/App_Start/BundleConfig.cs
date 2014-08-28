using System.Web.Optimization;

namespace OneAngularJS
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Custom").Include("~/Scripts/Custom/app.js"));

            bundles.Add(new ScriptBundle("~/Scripts/AngularJS").Include("~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include("~/Content/bootstrap.css"));
        }
    }
}