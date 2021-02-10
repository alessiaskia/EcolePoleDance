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
                "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/Content/contact").Include(
                "~/Content/contact-form.css",
                "~/Content/style.css"
                ));

            bundles.Add(new StyleBundle("~/Content/index").Include(
               "~/Content/touchTouch.css",
               "~/Content/camera.css",
               "~/Content/style.css"
               ));

            //SCRIPT BUNDLES
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/base").Include(
                        "~/Scripts/jquery.js",
                         "~/Scripts/jquery-migrate-1.1.1.js",
                         "~/Scripts/jquery.easing.1.3.js",
                         "~/Scripts/script.js",
                         "~/Scripts/superfish.js",
                         "~/Scripts/jquery.equalheights.js",
                         "~/Scripts/jquery.mobilemenu.js",
                         "~/Scripts/tmStickUp.js",
                         "~/Scripts/jquery.ui.totop.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/additionalForIndex").Include(
                         "~/Scripts/touchTouch.jquery.js",
                         "~/Scripts/camera.js",
                         "~/Scripts/jquery.mobile.customized.min.js"
                ));
           
            bundles.Add(new ScriptBundle("~/bundles/additionalForContacts").Include(
                         "~/Scripts/tTMForm.js",
                         "~/Scripts/modal.js"
                ));

        }
    }
}
