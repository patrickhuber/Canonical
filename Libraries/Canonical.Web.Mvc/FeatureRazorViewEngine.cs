using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Canonical.Web.Mvc
{
    public class FeatureRazorViewEngine : RazorViewEngine
    {
        public FeatureRazorViewEngine()
        {
            var featureFolderViewLocationFormats = new[]
            {
                "~/Features/{1}/Views/{0}.cshtml",
                "~/Features/{1}/Views/{0}.vbhtml",
                "~/Features/Views/Shared/{0}.cshtml",
                "~/Features/Views/Shared/{0}.vbhtml",
            };

            ViewLocationFormats = featureFolderViewLocationFormats;
            MasterLocationFormats = featureFolderViewLocationFormats;
            PartialViewLocationFormats = featureFolderViewLocationFormats;
        }
    }
}
