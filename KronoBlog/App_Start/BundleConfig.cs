using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace KronoBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // admin bundle style
            bundles.Add(new StyleBundle("~/admin/styles").
                Include("~/content/styles/bootstrap.css").
                Include("~/content/style/admin.css"));

            // site bundle style
            bundles.Add(new StyleBundle("~/styles").
                Include("~/content/styles/bootstrap.css").
                Include("~/content/style/site.css"));
           
            // admin scripts
            bundles.Add(new ScriptBundle("~/admin/scripts").
                Include("~/scripts/jquery-2.2.1.js").
                Include("~/scripts/jquery.validate.js").
                Include("~/scripts/jquery.validate.unobtrusive.js").
                Include("~/scripts/bootstrap.js"));

            // site scripts
            bundles.Add(new ScriptBundle("~/scripts").
                Include("~/scripts/jquery-2.2.1.js").
                Include("~/scripts/jquery.validate.js").
                Include("~/scripts/jquery.validate.unobtrusive.js").
                Include("~/scripts/bootstrap.js"));
        }
    }
}