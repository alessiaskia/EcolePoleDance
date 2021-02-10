using System.Web;
using System.Web.Optimization;

namespace EcolePoleDance.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));
            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //STYLE BUNDLES 
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/contact").Include(
                "~/css/contact-form.css"
                               ));

            bundles.Add(new StyleBundle("~/Content/index").Include(
               "~/css/touchTouch.css",
               "~/css/camera.css"

               ));

            //SCRIPT BUNDLES
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/base").Include(
                        "~/js/jquery.js",
                         "~/js/jquery-migrate-1.1.1.js",
                         "~/js/jquery.easing.1.3.js",
                         "~/js/script.js",
                         "~/js/superfish.js",
                         "~/js/jquery.equalheights.js",
                         "~/js/jquery.mobilemenu.js",
                         "~/js/tmStickUp.js",
                         "~/js/jquery.ui.totop.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/additionalForIndex").Include(
                         "~/js/touchTouch.jquery.js",
                         "~/js/camera.js",
                         "~/js/jquery.mobile.customized.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/additionalForContacts").Include(
                         "~/js/tTMForm.js",
                         "~/js/modal.js"
                ));

        }
    }
}
