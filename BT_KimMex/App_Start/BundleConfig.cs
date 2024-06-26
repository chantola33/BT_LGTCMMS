﻿using System.Web;
using System.Web.Optimization;

namespace BT_KimMex
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
                      "~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            ScriptBundle scriptBndl = new ScriptBundle("~/bundles/custom");
            scriptBndl.Include(
                        "~/Scripts/custom-script.js",
                        //"~/Scripts/custom/boq-custom-script.js",
                        "~/Scripts/custom/ir-custom-script.js",
                        "~/Scripts/custom/po-custom-script.js"
                    );
            bundles.Add(scriptBndl);

            BundleTable.EnableOptimizations = true;
        }
    }
}
