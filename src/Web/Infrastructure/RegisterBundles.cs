namespace Web.Infrastructure
{
    using System.Web.Optimization;
    using BundleTransformer.Core.Orderers;
    using BundleTransformer.Core.Transformers;
    using BundleTransformer.Less.Translators;
    using BundleTransformer.Yui.Minifiers;
    using MvcExtensions;

    public class RegisterBundles : BootstrapperTask
    {
        public override TaskContinuation Execute()
        {
            var cssTransformer = new CssTransformer(new YuiCssMinifier(), new[] {new LessTranslator()});
            cssTransformer.ForceReleaseMode();
            var jsTransformer = new JsTransformer(new YuiJsMinifier());
            jsTransformer.ForceReleaseMode();
            var nullOrderer = new NullOrderer();

            var commonStylesBundle = new Bundle("~/CommonStyles", cssTransformer);
            commonStylesBundle.AddFile("~/Content/site.less", false);
            commonStylesBundle.AddFile("~/Content/themes/base/jquery-ui.css", false);
            commonStylesBundle.AddFile("~/Content/bootstrap.min.css", false);
            commonStylesBundle.AddFile("~/Content/bootstrap-responsive.min.css", false);
            commonStylesBundle.Orderer = nullOrderer;

            BundleTable.Bundles.Add(commonStylesBundle);

            var modernizrBundle = new Bundle("~/Modernizr", jsTransformer);
            modernizrBundle.AddFile("~/Scripts/modernizr-2.5.3.js", false);
            modernizrBundle.Orderer = nullOrderer;

            BundleTable.Bundles.Add(modernizrBundle);

            var commonScriptsBundle = new Bundle("~/CommonScripts", jsTransformer);
            commonScriptsBundle.AddFile("~/Scripts/jquery-1.7.2.min.js", false);
            commonScriptsBundle.AddFile("~/Scripts/jquery-ui-1.8.19.min.js", false);
            commonScriptsBundle.AddFile("~/Scripts/jquery.validate.min.js", false);
            commonScriptsBundle.AddFile("~/Scripts/jquery.validate.unobtrusive.min.js", false);
            commonScriptsBundle.AddFile("~/Scripts/jquery.unobtrusive-ajax.min.js", false);
            commonScriptsBundle.AddFile("~/Scripts/bootstrap.min.js", false);
            commonScriptsBundle.Orderer = nullOrderer;

            BundleTable.Bundles.Add(commonScriptsBundle);
            return TaskContinuation.Continue;
        }
    }
}