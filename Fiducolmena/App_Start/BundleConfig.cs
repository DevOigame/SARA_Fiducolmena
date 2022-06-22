using System.Web;
using System.Web.Optimization;

namespace Fiducolmena
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //
            bundles.Add(new StyleBundle("~/plugins/fontawesome-free/css").Include(
                "~/plugins/fontawesome-free/css/all.min.css"));
            //
            bundles.Add(new StyleBundle("~/dist/css").Include(
                "~/dist/css/adminlte.min.css"));
            //
            bundles.Add(new StyleBundle("~/Content/Sara.css").Include(
                      "~/Content/Sara.css"));
            bundles.Add(new StyleBundle("~/Content/StyleFidu.css").Include(
          "~/Content/StyleFidu.css"));
            //css datatables
            bundles.Add(new StyleBundle("~/dist/DataTableExport/css").Include(
                "~/dist/DataTableExport/css/jquery.dataTables.min.css",
                "~/dist/DataTableExport/css/buttons.dataTables.min.css"));

            //
            bundles.Add(new StyleBundle("~/fonts/style.css").Include(
                "~/fonts/style.css"));

            //
            bundles.Add(new ScriptBundle("~/plugins/jquery").Include(
                      "~/plugins/jquery/jquery.min.js"));
            //
            bundles.Add(new ScriptBundle("~/plugins/bootstrap/js").Include(
                "~/plugins/bootstrap/js/bootstrap.bundle.min.js"));
            //

            //estilos js botones tablas
            bundles.Add(new ScriptBundle("~/dist/DataTableExport/js").Include(
                "~/dist/DataTableExport/js/jquery.dataTables.min.js",
                "~/dist/DataTableExport/js/dataTables.buttons.min.js",
                "~/dist/DataTableExport/js/buttons.flash.min.js",
                "~/dist/DataTableExport/js/jszip.min.js",
                "~/dist/DataTableExport/js/pdfmake.min.js",
                "~/dist/DataTableExport/js/vfs_fonts.js",
                "~/dist/DataTableExport/js/buttons.html5.min.js",
                "~/dist/DataTableExport/js/buttons.print.min.js"));


            bundles.Add(new ScriptBundle("~/dist/js").Include(
                "~/dist/js/adminlte.min.js",
                "~/dist/js/demo.js"));

            bundles.Add(new ScriptBundle("~/Scripts/sara").Include(
            "~/Scripts/SARA.js"));
        }
    }
}
