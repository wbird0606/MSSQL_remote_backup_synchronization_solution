
namespace BackupClient
{
    partial class BackupClient
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupClient));
            this.label2 = new System.Windows.Forms.Label();
            this.bak_server_url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bak_floder = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.get_filename_list = new System.Windows.Forms.Button();
            this.listBoxFileNames = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sql_ip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sql_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.mdf_path = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ldf_path = new System.Windows.Forms.TextBox();
            this.select_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_time_click = new System.Windows.Forms.Button();
            this.download_Record = new System.Windows.Forms.TextBox();
            this.time_num = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.log_Path = new System.Windows.Forms.TextBox();
            this.log_Path_Click = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.restore_Record = new System.Windows.Forms.TextBox();
            this.delete_Record = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "BackUpServer URL";
            // 
            // bak_server_url
            // 
            this.bak_server_url.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bak_server_url.Location = new System.Drawing.Point(261, 15);
            this.bak_server_url.Name = "bak_server_url";
            this.bak_server_url.Size = new System.Drawing.Size(770, 36);
            this.bak_server_url.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(56, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "備份資料夾";
            // 
            // bak_floder
            // 
            this.bak_floder.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bak_floder.Location = new System.Drawing.Point(261, 64);
            this.bak_floder.Name = "bak_floder";
            this.bak_floder.Size = new System.Drawing.Size(715, 36);
            this.bak_floder.TabIndex = 5;
            // 
            // browse
            // 
            this.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.browse.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.browse.Location = new System.Drawing.Point(982, 64);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(49, 36);
            this.browse.TabIndex = 6;
            this.browse.Text = "...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // get_filename_list
            // 
            this.get_filename_list.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.get_filename_list.Location = new System.Drawing.Point(693, 405);
            this.get_filename_list.Name = "get_filename_list";
            this.get_filename_list.Size = new System.Drawing.Size(338, 48);
            this.get_filename_list.TabIndex = 7;
            this.get_filename_list.Text = "獲取備份檔檔名";
            this.get_filename_list.UseVisualStyleBackColor = true;
            this.get_filename_list.Click += new System.EventHandler(this.get_filename_list_Click);
            // 
            // listBoxFileNames
            // 
            this.listBoxFileNames.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxFileNames.FormattingEnabled = true;
            this.listBoxFileNames.ItemHeight = 16;
            this.listBoxFileNames.Location = new System.Drawing.Point(693, 109);
            this.listBoxFileNames.Name = "listBoxFileNames";
            this.listBoxFileNames.Size = new System.Drawing.Size(338, 292);
            this.listBoxFileNames.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "還原SQL SERVER IP";
            // 
            // sql_ip
            // 
            this.sql_ip.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sql_ip.Location = new System.Drawing.Point(261, 115);
            this.sql_ip.Name = "sql_ip";
            this.sql_ip.PasswordChar = '*';
            this.sql_ip.Size = new System.Drawing.Size(426, 36);
            this.sql_ip.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(95, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "資料庫名稱";
            // 
            // sql_name
            // 
            this.sql_name.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sql_name.Location = new System.Drawing.Point(261, 160);
            this.sql_name.Name = "sql_name";
            this.sql_name.PasswordChar = '*';
            this.sql_name.Size = new System.Drawing.Size(426, 36);
            this.sql_name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(170, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "帳號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(420, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "密碼";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.username.Location = new System.Drawing.Point(261, 204);
            this.username.Name = "username";
            this.username.PasswordChar = '*';
            this.username.Size = new System.Drawing.Size(127, 36);
            this.username.TabIndex = 15;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password.Location = new System.Drawing.Point(501, 202);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(179, 36);
            this.password.TabIndex = 16;
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Execute.Location = new System.Drawing.Point(451, 338);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(181, 60);
            this.Execute.TabIndex = 17;
            this.Execute.Text = "開始執行";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // mdf_path
            // 
            this.mdf_path.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mdf_path.Location = new System.Drawing.Point(142, 246);
            this.mdf_path.Name = "mdf_path";
            this.mdf_path.Size = new System.Drawing.Size(472, 36);
            this.mdf_path.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(2, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "資料庫路徑";
            // 
            // ldf_path
            // 
            this.ldf_path.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ldf_path.Location = new System.Drawing.Point(142, 286);
            this.ldf_path.Name = "ldf_path";
            this.ldf_path.Size = new System.Drawing.Size(472, 36);
            this.ldf_path.TabIndex = 20;
            // 
            // select_file
            // 
            this.select_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.select_file.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.select_file.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select_file.Location = new System.Drawing.Point(631, 245);
            this.select_file.Name = "select_file";
            this.select_file.Size = new System.Drawing.Size(49, 36);
            this.select_file.TabIndex = 21;
            this.select_file.Text = "...";
            this.select_file.UseVisualStyleBackColor = true;
            this.select_file.Click += new System.EventHandler(this.select_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(170, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "固定每天           點執行";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_time_click
            // 
            this.btn_time_click.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_time_click.Location = new System.Drawing.Point(501, 423);
            this.btn_time_click.Name = "btn_time_click";
            this.btn_time_click.Size = new System.Drawing.Size(104, 39);
            this.btn_time_click.TabIndex = 26;
            this.btn_time_click.Text = "確定";
            this.btn_time_click.UseVisualStyleBackColor = true;
            this.btn_time_click.Click += new System.EventHandler(this.btn_time_click_Click);
            // 
            // download_Record
            // 
            this.download_Record.CausesValidation = false;
            this.download_Record.Font = new System.Drawing.Font("標楷體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.download_Record.Location = new System.Drawing.Point(60, 509);
            this.download_Record.Multiline = true;
            this.download_Record.Name = "download_Record";
            this.download_Record.ReadOnly = true;
            this.download_Record.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.download_Record.Size = new System.Drawing.Size(302, 191);
            this.download_Record.TabIndex = 27;
            this.download_Record.TabStop = false;
            // 
            // time_num
            // 
            this.time_num.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time_num.FormattingEnabled = true;
            this.time_num.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.time_num.Location = new System.Drawing.Point(282, 429);
            this.time_num.Name = "time_num";
            this.time_num.Size = new System.Drawing.Size(125, 24);
            this.time_num.TabIndex = 28;
            this.time_num.Text = "選擇時間單位";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "紀錄存放位置";
            // 
            // log_Path
            // 
            this.log_Path.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.log_Path.Location = new System.Drawing.Point(16, 365);
            this.log_Path.Name = "log_Path";
            this.log_Path.Size = new System.Drawing.Size(346, 36);
            this.log_Path.TabIndex = 30;
            // 
            // log_Path_Click
            // 
            this.log_Path_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.log_Path_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.log_Path_Click.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.log_Path_Click.Location = new System.Drawing.Point(369, 362);
            this.log_Path_Click.Name = "log_Path_Click";
            this.log_Path_Click.Size = new System.Drawing.Size(49, 36);
            this.log_Path_Click.TabIndex = 31;
            this.log_Path_Click.Text = "...";
            this.log_Path_Click.UseVisualStyleBackColor = true;
            this.log_Path_Click.Click += new System.EventHandler(this.Log_Path_Click_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 430);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 32;
            // 
            // restore_Record
            // 
            this.restore_Record.CausesValidation = false;
            this.restore_Record.Font = new System.Drawing.Font("標楷體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.restore_Record.Location = new System.Drawing.Point(385, 509);
            this.restore_Record.Multiline = true;
            this.restore_Record.Name = "restore_Record";
            this.restore_Record.ReadOnly = true;
            this.restore_Record.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.restore_Record.Size = new System.Drawing.Size(302, 191);
            this.restore_Record.TabIndex = 33;
            this.restore_Record.TabStop = false;
            // 
            // delete_Record
            // 
            this.delete_Record.CausesValidation = false;
            this.delete_Record.Font = new System.Drawing.Font("標楷體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete_Record.Location = new System.Drawing.Point(712, 509);
            this.delete_Record.Multiline = true;
            this.delete_Record.Name = "delete_Record";
            this.delete_Record.ReadOnly = true;
            this.delete_Record.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.delete_Record.Size = new System.Drawing.Size(302, 191);
            this.delete_Record.TabIndex = 34;
            this.delete_Record.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(124, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "download.txt";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label11.Location = new System.Drawing.Point(439, 473);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(153, 24);
            this.Label11.TabIndex = 36;
            this.Label11.Text = "restore.txt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(789, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "delete.txt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(631, 459);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(958, 459);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BackupClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 712);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.delete_Record);
            this.Controls.Add(this.restore_Record);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.log_Path_Click);
            this.Controls.Add(this.log_Path);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.time_num);
            this.Controls.Add(this.download_Record);
            this.Controls.Add(this.btn_time_click);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_file);
            this.Controls.Add(this.ldf_path);
            this.Controls.Add(this.mdf_path);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sql_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sql_ip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxFileNames);
            this.Controls.Add(this.get_filename_list);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.bak_floder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bak_server_url);
            this.Controls.Add(this.label2);
            this.Name = "BackupClient";
            this.Text = "BackupClient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bak_server_url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bak_floder;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button get_filename_list;
        private System.Windows.Forms.ListBox listBoxFileNames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sql_ip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sql_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.TextBox mdf_path;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ldf_path;
        private System.Windows.Forms.Button select_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_time_click;
        private System.Windows.Forms.TextBox download_Record;
        private System.Windows.Forms.ComboBox time_num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox log_Path;
        private System.Windows.Forms.Button log_Path_Click;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox restore_Record;
        private System.Windows.Forms.TextBox delete_Record;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

