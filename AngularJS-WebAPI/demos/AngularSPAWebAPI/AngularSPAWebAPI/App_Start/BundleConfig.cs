using System.Web;
using System.Web.Optimization;

namespace AngularSPAWebAPI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/compatibility").Include(
                    "~/Scripts/html5shiv.js",
                    "~/Scripts/respond.js",
                    "~/Scripts/modernizr*"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                    "~/Scripts/angular.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                    "~/Scripts/App/app.js",
                    "~/Scripts/App/Models/*.js",
                    "~/Scripts/App/Directives/*.js",
                    "~/Scripts/App/Controllers/*.js",
                    "~/Scripts/App/Services/*.js",
                    "~/Scripts/App/Filters/*.js"
                ));

            bundles.Add(new StyleBundle("~/content/bootstrap").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/content/glyphs").Include("~/Content/glyphicons.css"));
            bundles.Add(new StyleBundle("~/content/css").Include("~/Content/App/site.css"));
            bundles.Add(new StyleBundle("~/content/authenticated").Include("~/Content/App/sidebar.css"));

        }
    }
}