using System;
using System.Web;
using System.Web.Routing;

namespace backupserver
{
    public class Global : HttpApplication
    {
        private void Application_Start(object sender, EventArgs e)
        {
            // 應用程式啟動時執行的程式碼
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("ListFiles", "list", "~/ListFiles.aspx");
            routes.MapPageRoute("ListFiles_tra", "list_tra", "~/ListFiles_tra.aspx");
            routes.MapPageRoute("DownloadFile", "download/{fileName}", "~/DownloadFile.aspx");
        }
    }
}