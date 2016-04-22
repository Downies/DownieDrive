using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DownieDrive.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            


            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                "~/lib/materialize/materialize.min.js"));

            bundles.Add(new StyleBundle("~/bundles/site").Include(
                "~/Content/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/lib/jquery/jquery-1.10.2.min.js"));
        }
    }
}