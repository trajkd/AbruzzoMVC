using System;
using System.Web.Optimization;
namespace AbruzzoMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
          "~/Content/style.css"));
        }
    }
}
