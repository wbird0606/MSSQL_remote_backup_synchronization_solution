using System;

//using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupClient
{
    public partial class BackupClient : Form
    {
        //private const int chunk = 1024*1024;

        public BackupClient()
        {
            InitializeComponent();

            if (log_Path.Text != "")
            {
                if (!File.Exists(log_Path.Text + @"\download.txt"))
                {
                    File.Create(log_Path.Text + @"\download.txt").Close();
                }
                if (!File.Exists(log_Path.Text + @"\restore.txt"))
                {
                    File.Create(log_Path.Text + @"\restore.txt").Close();
                }
                if (!File.Exists(log_Path.Text + @"\delete.txt"))
                {
                    File.Create(log_Path.Text + @"\delete.txt").Close();
                }
                pictureBox1_Click(null, null);
                pictureBox2_Click(null, null);
                pictureBox3_Click(null, null);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "請選擇資料夾";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = dialog.SelectedPath;
                bak_floder.Text = filepath;
                if (log_Path.Text != "")
                {
                    if (!File.Exists(log_Path.Text + @"\download.txt"))
                    {
                        File.Create(log_Path.Text + @"\download.txt").Close();
                    }
                    if (!File.Exists(log_Path.Text + @"\restore.txt"))
                    {
                        File.Create(log_Path.Text + @"\restore.txt").Close();
                    }
                    if (!File.Exists(log_Path.Text + @"\delete.txt"))
                    {
                        File.Create(log_Path.Text + @"\delete.txt").Close();
                    }
                    pictureBox1_Click(null, null);
                    pictureBox2_Click(null, null);
                    pictureBox3_Click(null, null);
                }
            }
        }

        private void Log_Path_Click_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "請選擇資料夾";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = dialog.SelectedPath;
                log_Path.Text = filepath;
            }
        }

        private void get_filename_list_Click(object sender, EventArgs e)
        {
            // 列出伺服器端的備份檔案
            listBoxFileNames.Items.Clear();
            string[] fileNames = GetFileListFromServer();
            if (fileNames != null)
            {
                listBoxFileNames.Items.AddRange(fileNames);
            }
        }

        public string GetParagrspContext(string html)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var paragraphs = doc.DocumentNode.SelectNodes("//p");
            if (paragraphs == null)
            {
                return string.Empty;
            }

            var content = new StringBuilder();
            foreach (var p in paragraphs)
            {
                content.AppendLine(p.InnerText);
            }
            return content.ToString();
        }

        private string[] GetFileListFromServer()
        {
            // 送出 GET 請求並取得回應
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(bak_server_url.Text + "/list").Result;

                // 確認回應狀態碼是否為成功 (200 OK)
                if (response.IsSuccessStatusCode)
                {
                    string htmlContent = (response.Content.ReadAsStringAsync().Result).Replace("<br/>", "/");
                    string[] fileNames = GetParagrspContext(htmlContent).Split('/');
                    fileNames[(fileNames.Length) - 1] = fileNames[(fileNames.Length) - 1].Replace("\r\n", "/").TrimEnd('/');
                    return fileNames;
                }
                else
                {
                    string[] Error = { "URL錯誤" };
                    return Error;
                }
            }
            catch (Exception ex)
            {
                string[] Error = { ex.Message.ToString() };
                return Error;
            }
        }

        private string[] GetFileListFromServer_tra()
        {
            // 送出 GET 請求並取得回應
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(bak_server_url.Text + "/list_tra").Result;

                // 確認回應狀態碼是否為成功 (200 OK)
                if (response.IsSuccessStatusCode)
                {
                    string htmlContent = (response.Content.ReadAsStringAsync().Result).Replace("<br/>", "/");
                    string[] fileNames = GetParagrspContext(htmlContent).Split('/');
                    fileNames[(fileNames.Length) - 1] = fileNames[(fileNames.Length) - 1].Replace("\r\n", "/").TrimEnd('/');
                    return fileNames;
                }
                else
                {
                    string[] Error = { "URL錯誤" };
                    return Error;
                }
            }
            catch (Exception ex)
            {
                string[] Error = { ex.Message.ToString() };
                return Error;
            }
        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            await Identify_download();
            try
            {
                await RestoreDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤:{ex.Message}");
            }
        }

        private async Task Identify_download()
        {
            pictureBox1_Click(null, null);
            pictureBox2_Click(null, null);
            pictureBox3_Click(null, null);
            string[] selectedFileName = GetFileListFromServer();
            string[] downloadFileName = download_Record.Text.Trim().Replace("\r\n", "/").Split('/');
            string[] deleteFileName = delete_Record.Text.Trim().Replace("\r\n", "/").Split('/');
            for (int i = 0; i < selectedFileName.Length; i++)
            {
                //bool exist = false;
                if (!File.Exists(Path.Combine(bak_floder.Text, selectedFileName[i])))
                {
                    if(!Array.Exists(downloadFileName,element=>element== selectedFileName[i]))
                    {
                        if (!Array.Exists(deleteFileName, element => element == selectedFileName[i]))
                        {
                            try
                            {
                                await DownloadBackup(selectedFileName[i].Trim(), Path.Combine(bak_floder.Text, selectedFileName[i].Trim()));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"發生錯誤:{ex.Message}");
                            }
                        }
                    }
                    //for (int j = 0; j < downloadFileName.Length; j++)
                    //{
                    //    for (int k = 0; k < deleteFileName.Length; k++)
                    //    {
                    //        if (selectedFileName[i].Trim() == downloadFileName[j].Trim() || selectedFileName[i].Trim() == deleteFileName[k].Trim())
                    //        {
                    //            exist = true;
                    //            break;
                    //            //exist = false;
                    //        }
                    //    }
                    //}
                }
                //if (!exist)
                //{
                //    try
                //    {
                //        await DownloadBackup(selectedFileName[i].Trim(), Path.Combine(bak_floder.Text, selectedFileName[i].Trim()));
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show($"發生錯誤:{ex.Message}");
                //    }
                //    //await MainLOgic(selectedFileName[i]);

                //    //MessageBox.Show(selectedFileName[i]+"還原成功。");
                //}
            }
        }


        private async Task DownloadBackup(string fileName, string localFilePath)
        {
            string URL = bak_server_url.Text + "/download/" + fileName;
            using (var httpClient = new HttpClient())
            {
                try
                {
                    using (var response = await httpClient.GetAsync(URL, HttpCompletionOption.ResponseHeadersRead))
                    {
                        response.EnsureSuccessStatusCode();
                        long fileSize = response.Content.Headers.ContentLength ?? -1;

                        string savePath = localFilePath;
                        using (var fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            using (var responseStream = await response.Content.ReadAsStreamAsync())
                            {
                                byte[] buffer = new byte[8192 * 1024];
                                int bytesRead;
                                long totalBytesRead = 0;

                                while ((bytesRead = await responseStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                                    totalBytesRead += bytesRead;

                                    int progressPercentage = (int)((double)totalBytesRead / fileSize * 100);
                                    progressBar1.Value = progressPercentage;
                                }
                            }
                        }
                        StreamWriter sw = new StreamWriter(log_Path.Text + @"\download.txt", true);
                        sw.Write(fileName + "\r\n");
                        sw.Flush();
                        sw.Close();
                        pictureBox1_Click(null, null);
                        pictureBox2_Click(null, null);
                        pictureBox3_Click(null, null);
                        //MessageBox.Show("檔案下載成功!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"請求失敗:{fileName}:{ex.Message}");
                }
            }
        }

        private async Task RestoreDatabase()
        {
            string[] fileNames = Directory.GetFiles(bak_floder.Text)
                        .Where(o => Path.GetExtension(o).Equals(".bak", StringComparison.OrdinalIgnoreCase))
                        .Select(Path.GetFileName)
                        .OrderBy(fileName => fileName)
                        .ToArray();
            string[] restoredFileName = restore_Record.Text.Trim().Replace("\r\n", "/").Trim().Split('/');
            for (int i = 0; i < fileNames.Length; i++)
            {
                if (!Array.Exists(restoredFileName, element => element == fileNames[i]))
                {
                    try
                    {
                        string databaseName = sql_name.Text;
                        string backupFilePath = bak_floder.Text + @"\" + fileNames[i];
                        // 建立 SqlConnectionStringBuilder，用於建立連線字串
                        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder
                        {
                            DataSource = sql_ip.Text,
                            UserID = username.Text.ToString(),
                            Password = password.Text.ToString(),
                            InitialCatalog = "master",
                            IntegratedSecurity = true
                        };

                        // 使用 SqlConnectionStringBuilder 來建立 SqlConnection
                        using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
                        {
                            // 開啟 SqlConnection
                            await connection.OpenAsync();

                            // 建立還原命令字串
                            string restoreCommandText = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;" +
                            $"RESTORE DATABASE [{databaseName}] FROM  DISK = N'{backupFilePath}' WITH  FILE = 1," +
                            $"MOVE N'{databaseName}' TO N'{mdf_path.Text}' ,MOVE N'{databaseName}_log' TO N'{ldf_path.Text}'," +
                            $"NOUNLOAD,  REPLACE,  STATS = 5;" +
                            $"ALTER DATABASE [{databaseName}] SET MULTI_USER;";

                            // 使用 SqlCommand 執行還原命令
                            using (SqlCommand command = new SqlCommand(restoreCommandText, connection))
                            {
                                command.CommandTimeout = 30000000;
                                await command.ExecuteNonQueryAsync();
                            }

                            // 關閉 SqlConnection
                            connection.Close();
                        }

                        StreamWriter sw = new StreamWriter(log_Path.Text + @"\restore.txt", true);
                        sw.Write(fileNames[i] + "\r\n");
                        sw.Flush();
                        sw.Close();
                        pictureBox1_Click(null, null);
                        pictureBox2_Click(null, null);
                        pictureBox3_Click(null, null);
                        //MessageBox.Show("還原成功。");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("還原資料庫時發生錯誤：" + ex.Message);
                    }
                }

            }
        }

        private void DeleteBackup()
        {
            pictureBox1_Click(null, null);
            pictureBox2_Click(null, null);
            pictureBox3_Click(null, null);
            //string[] filenames = filename.Split('_');
            //string datetime = filenames[2] + filenames[3] + filenames[4]+filenames[5].Substring(0,4); //FlightSequence_backup_2023_08_04_090001_8320353.bak
            string[] fileNames_List = Directory.GetFiles(bak_floder.Text)
                        .Where(backupFolderPath => Path.GetExtension(backupFolderPath).Equals(".bak", StringComparison.OrdinalIgnoreCase))
                        .Select(Path.GetFileName)
                        .ToArray();
            for (int i = 0; i < fileNames_List.Length; i++)
            {
                string[] filenames = fileNames_List[i].Split('_');
                string hour = filenames[5].Substring(0, 2);
                string status = " 上午 ";
                if (Convert.ToInt32(hour) > 12)
                {
                    status = " 下午 ";
                    hour = (Convert.ToInt32(hour) - 12).ToString();
                    if (hour.Substring(0, 1) == "-")
                    {
                        hour = "0" + hour.Substring(1, 1);
                    }
                }

                string datetime = filenames[2] + "/" + filenames[3] + "/" + filenames[4] + status + hour + ":00:00";
                DateTime parsedDate = DateTime.Parse(datetime);
                if (parsedDate < DateTime.Now.AddDays(-2))
                {
                    File.Delete(Path.Combine(bak_floder.Text, fileNames_List[i]));
                    //sw.Write(fileNames_List[i] + '\n');
                    //sw.Close();
                    StreamWriter sw = new StreamWriter(log_Path.Text + @"\delete.txt", true);
                    sw.Write(fileNames_List[i] + "\r\n");
                    sw.Flush();
                    sw.Close();
                    pictureBox1_Click(null, null);
                    pictureBox2_Click(null, null);
                    pictureBox3_Click(null, null);
                    string[] traNames_List = Directory.GetFiles(bak_floder.Text)
                        .Where(backupFolderPath => Path.GetExtension(backupFolderPath).Equals(".tra", StringComparison.OrdinalIgnoreCase))
                        .Select(Path.GetFileName)
                        .ToArray();

                    for (int j = 0; j < traNames_List.Length; j++)
                    {
                        string[] tranames = traNames_List[j].Split('_');
                        string hour1 = tranames[5].Substring(0, 2);
                        string status1 = " 上午 ";
                        if (Convert.ToInt32(hour1) > 12)
                        {
                            status1 = " 下午 ";
                            hour1 = (Convert.ToInt32(hour1) - 12).ToString();
                            if (hour1.Substring(0, 1) == "-")
                            {
                                hour1 = "0" + hour1.Substring(1, 1);
                            }
                        }
                        string datetime1 = tranames[2] + "/" + tranames[3] + "/" + tranames[4] + status1 + hour1 + ":00:00";
                        DateTime parsedDate1 = DateTime.Parse(datetime1);
                        if (parsedDate1 < DateTime.Now.AddDays(-2))
                        {
                            File.Delete(Path.Combine(bak_floder.Text, traNames_List[j]));
                            StreamWriter sw1 = new StreamWriter(log_Path.Text + @"\delete.txt", true);
                            sw1.Write(traNames_List[j] + "\r\n");
                            sw1.Flush();
                            sw1.Close();
                            pictureBox1_Click(null, null);
                            pictureBox2_Click(null, null);
                            pictureBox3_Click(null, null);
                        }
                    }
                }
            }
        }

        private void select_file_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "請選擇資料夾";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = dialog.SelectedPath;
                mdf_path.Text = filepath + "\\" + sql_name.Text + ".mdf";
                ldf_path.Text = filepath + "\\" + sql_name.Text + "_log.ldf";
            }
        }

        private void btn_time_click_Click(object sender, EventArgs e)
        {
            if (btn_time_click.Text == "停止")
            {
                timer.Enabled = false;
                Execute.Enabled = true;
                btn_time_click.Text = "啟用";
                time_num.Text = "選擇時間單位";
            }
            else
            {
                if (time_num.Text != null && time_num.Text != "選擇時間單位")
                {
                    timer.Enabled = true;
                    Execute.Enabled = false;
                    btn_time_click.Text = "停止";
                }
            }
        }

        private async Task Execute_Downloadtra()
        {
            pictureBox1_Click(null, null);
            pictureBox2_Click(null, null);
            pictureBox3_Click(null, null);
            string[] selectedFileName = GetFileListFromServer_tra();
            string[] downloadFileName = download_Record.Text.Trim().Replace("\r\n", "/").Split('/');
            string[] deleteFileName = delete_Record.Text.Trim().Replace("\r\n", "/").Split('/');
            for (int i = 0; i < selectedFileName.Length; i++)
            {
                //bool exist = false;
                if (!File.Exists(Path.Combine(bak_floder.Text, selectedFileName[i])))
                {
                    if (!Array.Exists(downloadFileName, element => element == selectedFileName[i]))
                    {
                        if (!Array.Exists(deleteFileName, element => element == selectedFileName[i]))
                        {
                            try
                            {
                                await DownloadBackup(selectedFileName[i].Trim(), Path.Combine(bak_floder.Text, selectedFileName[i].Trim()));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"發生錯誤:{ex.Message}");
                            }
                        }
                    }

                }
            }
        }
        private async void timer_Tick(object sender, EventArgs e)
        {
            if (time_num.Text != null && time_num.SelectedItem.ToString() != "選擇時間單位")
            {
                if (DateTime.Now.Minute == 5 && DateTime.Now.Second == 0)
                {
                    Execute_Downloadtra();
                    DeleteBackup();
                }
                if (DateTime.Now.Minute == 10 && DateTime.Now.Second == 0 && DateTime.Now.Hour == Convert.ToInt16(time_num.Text.Substring(0, 2)))
                {
                    await Identify_download();
                    try
                    {
                        RestoreDatabase();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"發生錯誤:{ex.Message}");
                    }
                    DeleteBackup();
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(log_Path.Text + @"\download.txt");
            string ReadLine;
            download_Record.Clear();
            while ((ReadLine = sr.ReadLine()) != null)
            {
                download_Record.AppendText(ReadLine + "\r\n");
            }
            sr.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(log_Path.Text + @"\restore.txt");
            string ReadLine;
            restore_Record.Clear();
            while ((ReadLine = sr.ReadLine()) != null)
            {
                restore_Record.AppendText(ReadLine + "\r\n");
            }
            sr.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(log_Path.Text + @"\delete.txt");
            string ReadLine;
            delete_Record.Clear();
            while ((ReadLine = sr.ReadLine()) != null)
            {
                delete_Record.AppendText(ReadLine + "\r\n");
            }
            sr.Close();
        }
    }
}