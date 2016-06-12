using System.Web;
using System.Web.Optimization;

namespace SeudanBeaga
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                         "~/Scripts/blueimp-gallery.js",
                        "~/Scripts/jquery.blueimp-gallery.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/Scripts/angular.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/angular-ui-router.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                "~/Scripts/angular-gm/ng-map.js",
                "~/Scripts/angular-pagination/dirPagination.js"));

            bundles.Add(new ScriptBundle("~/bundles/sbApp")
                 .Include("~/App/app.js")
                 .Include("~/App/app.config.js")
                 .Include("~/App/app.routing.js")
                .IncludeDirectory("~/App","*.js", true));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-image-gallery.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/blueimp-gallery.css",
                      "~/Content/bootstrap-image-gallery.css",
                      "~/Content/bootstrap-gallery-indicator.css",
                      "~/Content/site.css"));
        }
    }
}
