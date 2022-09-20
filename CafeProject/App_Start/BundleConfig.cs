using System.Web;
using System.Web.Optimization;

namespace CafeProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.js",
                        "~/Scripts/jquery-3.4.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
            "~/Content/JQWidgets/jqx.base.css",
            "~/Content/JQWidgets/jqx.arctic.css",
            "~/Content/JQWidgets/jqx.black.css",
            "~/Content/JQWidgets/jqx.bootstrap.css",
            "~/Content/JQWidgets/jqx.classic.css",
            "~/Content/JQWidgets/jqx.darkblue.css",
            "~/Content/JQWidgets/jqx.energyblue.css",
            "~/Content/JQWidgets/jqx.fresh.css",
            "~/Content/JQWidgets/jqx.highcontrast.css",
            "~/Content/JQWidgets/jqx.metro.css",
            "~/Content/JQWidgets/jqx.metrodark.css",
            "~/Content/JQWidgets/jqx.office.css",
            "~/Content/JQWidgets/jqx.orange.css",
            "~/Content/JQWidgets/jqx.shinyblack.css",
            "~/Content/JQWidgets/jqx.summer.css",
            "~/Content/JQWidgets/jqx.web.css",
            "~/Content/JQWidgets/jqx.ui-darkness.css",
            "~/Content/JQWidgets/jqx.ui-lightness.css",
            "~/Content/JQWidgets/jqx.ui-le-frog.css",
            "~/Content/JQWidgets/jqx.ui-overcast.css",
            "~/Content/JQWidgets/jqx.ui-redmond.css",
            "~/Content/JQWidgets/jqx.ui-smoothness.css",
            "~/Content/JQWidgets/jqx.ui-start.css",
            "~/Content/JQWidgets/jqx.ui-sunny.css",
            "~/Content/bootstrap.css",
            "~/Content/bootstrap.min.css",
            "~/Content/site.css",
            "~/Content/Style.css"));

            bundles.Add(new ScriptBundle("~/bundles/JQWidgets").Include(
           "~/Scripts/JQWidgets/jqxcore.js",
           "~/Scripts/JQWidgets/jqxdata.js",
           "~/Scripts/JQWidgets/jqxgrid.js",
           "~/Scripts/JQWidgets/jqxgrid.selection.js",
           "~/Scripts/JQWidgets/jqxgrid.pager.js",
           "~/Scripts/JQWidgets/jqxlistbox.js",
           "~/Scripts/JQWidgets/jqxbuttons.js",
           "~/Scripts/JQWidgets/jqxscrollbar.js",
           "~/Scripts/JQWidgets/jqxdatatable.js",
           "~/Scripts/JQWidgets/jqxtreegrid.js",
           "~/Scripts/JQWidgets/jqxmenu.js",
           "~/Scripts/JQWidgets/jqxcalendar.js",
           "~/Scripts/JQWidgets/jqxgrid.sort.js",
           "~/Scripts/JQWidgets/jqxgrid.filter.js",
           "~/Scripts/JQWidgets/jqxgrid.edit.js",
           "~/Scripts/JQWidgets/jqxgrid.aggregates.js",
           "~/Scripts/JQWidgets/jqxgrid.selection.js",
           "~/Scripts/JQWidgets/jqxdatetimeinput.js",
           "~/Scripts/JQWidgets/jqxdropdownlist.js",
           "~/Scripts/JQWidgets/jqxslider.js",
           "~/Scripts/JQWidgets/jqxeditor.js",
           "~/Scripts/JQWidgets/jqxinput.js",
           "~/Scripts/JQWidgets/jqxdraw.js",
           "~/Scripts/JQWidgets/jqxchart.core.js",
           "~/Scripts/JQWidgets/jqxchart.rangeselector.js",
           "~/Scripts/JQWidgets/jqxtree.js",
           "~/Scripts/JQWidgets/globalization/globalize.js",
           "~/Scripts/JQWidgets/jqxbulletchart.js",
           "~/Scripts/JQWidgets/jqxcheckbox.js",
           "~/Scripts/JQWidgets/jqxradiobutton.js",
           "~/Scripts/JQWidgets/jqxvalidator.js",
           "~/Scripts/JQWidgets/jqxpanel.js",
           "~/Scripts/JQWidgets/jqxpasswordinput.js",
           "~/Scripts/JQWidgets/jqxnumberinput.js",
           "~/Scripts/JQWidgets/jqxcombobox.js"
           ));
        }
    }
}
