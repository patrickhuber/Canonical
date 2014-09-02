using Canonical.Web.Mvc.ViewEngines;
using System.Web.Mvc;

namespace Canonical.WebApp
{
    public class ViewEngineConfig
    {
        public static void RegisterViewEngines(ViewEngineCollection viewEngines)
        {
            viewEngines.Clear();
            viewEngines.Add(new FeatureRazorViewEngine());
        }
    }
}