Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Content/js/jquery-3.3.1.min.js",
                  "~/Content/js/bootstrap.min.js",
                  "~/Content/js/jquery.magnific-popup.min.js",
                  "~/Content/js/mixitup.min.js",
                  "~/Content/js/jquery.slicknav.js",
                  "~/Content/js/owl.carousel.min.js",
                  "~/Content/js/main.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                        "~/Content/css/bootstrap.min.css",
                        "~/Content/css/font-awesome.min.css",
                        "~/Content/css/owl.carousel.min.css",
                        "~/Content/css/magnific-popup.css",
                        "~/Content/css/slicknav.min.css",
                        "~/Content/css/style.css"))

    End Sub
End Module

