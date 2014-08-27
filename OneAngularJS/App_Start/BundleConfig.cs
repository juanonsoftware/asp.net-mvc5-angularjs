using System.Web.Optimization;

namespace OneAngularJS
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Custom").Include("~/Scripts/Custom/app.js"));

            bundles.Add(new ScriptBundle("~/Scripts/AngularJS").Include("~/Scripts/angular.js"));
        }
    }
}