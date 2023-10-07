using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace backupserver
{
    public partial class ListFiles_tra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string clientIPAddress = Request.UserHostAddress;
            List<string> allowedIPs = new List<string>
            {
                "10.28.196.81",
                "10.28.196.82",
                "10.28.196.83",
                "10.28.196.84",
                "10.28.196.86",
                "10.28.196.91",
                "10.28.196.92",
                "10.28.196.93",
                "10.28.196.94",
                "10.28.196.96",
                "::1",
                "10.56.54.44",
                "10.149.196.82"
            };

            if (!allowedIPs.Contains(clientIPAddress))
            {
                Response.StatusCode = 403;
                Response.End();
                return;
            }

            string backupFolderPath = ConfigurationManager.AppSettings["backupFolderPath"].ToString();
            string[] fileNames = Directory.GetFiles(backupFolderPath)
                        .Where(o => Path.GetExtension(o).Equals(".tra", StringComparison.OrdinalIgnoreCase))
                        .Select(Path.GetFileName)
                        .ToArray();

            string fileList = string.Join("<br/>", fileNames);
            //byte[] buffer = System.Text.Encoding.UTF8.GetBytes(fileList);
            context.InnerHtml = fileList;
        }
    }
}