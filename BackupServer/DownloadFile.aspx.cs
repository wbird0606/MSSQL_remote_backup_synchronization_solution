using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace backupserver
{
    public partial class DownloadFile : System.Web.UI.Page
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
            string fileName = Request.QueryString["filename"];
            string filePath = Path.Combine(backupFolderPath, fileName);

            if (File.Exists(filePath))
            {
                //計算檔案總大小
                long fileSize = new FileInfo(filePath).Length;

                //取得Client請求的範圍
                long startRange = 0;
                long endRange = fileSize - 1;

                string rangeHeader = Request.Headers["Range"];
                if (!string.IsNullOrEmpty(rangeHeader))
                {
                    rangeHeader = rangeHeader.Replace("bytes=", "");
                    string[] range = rangeHeader.Split('-');
                    startRange = long.Parse(range[0]);
                    if (range.Length > 1 && !string.IsNullOrEmpty(range[1]))
                    {
                        endRange = Math.Min(long.Parse(range[1]), fileSize - 1);
                    }
                }

                //設定Content-Range 標頭，指定下載範圍
                Response.AddHeader("Content-Range", "bytes " + startRange + "-" + endRange + "/" + fileSize);

                //設定狀態碼206 Partital Content
                Response.StatusCode = 206;
                //設定檔案的ContentType和檔名
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
                //設定Content-Length標頭，指定下載的大小
                Response.AddHeader("Content-Length", (endRange - startRange + 1).ToString());
                //讀取檔案並傳送到Response
                Response.TransmitFile(filePath, startRange, endRange - startRange + 1);
                Response.End();
            }
            else
            {
                Response.StatusCode = 404;
                Response.End();
            }
        }
    }
}