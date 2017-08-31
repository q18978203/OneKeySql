namespace OneKeySQL
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_databaseuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dbuser = new System.Windows.Forms.TextBox();
            this.tb_dbpwd = new System.Windows.Forms.TextBox();
            this.btn_connet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_DBAddr = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_sql = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_GameName = new System.Windows.Forms.ComboBox();
            this.cb_DBName = new System.Windows.Forms.ComboBox();
            this.label_sqlServer = new System.Windows.Forms.Label();
            this.btn_checkGame = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddMoblieGame = new System.Windows.Forms.Button();
            this.lab_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_databaseuser
            // 
            this.label_databaseuser.AutoSize = true;
            this.label_databaseuser.Location = new System.Drawing.Point(364, 15);
            this.label_databaseuser.Name = "label_databaseuser";
            this.label_databaseuser.Size = new System.Drawing.Size(47, 12);
            this.label_databaseuser.TabIndex = 0;
            this.label_databaseuser.Text = "DB_User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB_Pwd";
            // 
            // tb_dbuser
            // 
            this.tb_dbuser.Location = new System.Drawing.Point(423, 11);
            this.tb_dbuser.Name = "tb_dbuser";
            this.tb_dbuser.Size = new System.Drawing.Size(100, 21);
            this.tb_dbuser.TabIndex = 2;
            this.tb_dbuser.Text = "sa";
            // 
            // tb_dbpwd
            // 
            this.tb_dbpwd.Location = new System.Drawing.Point(603, 11);
            this.tb_dbpwd.Name = "tb_dbpwd";
            this.tb_dbpwd.Size = new System.Drawing.Size(100, 21);
            this.tb_dbpwd.TabIndex = 3;
            this.tb_dbpwd.Text = "123456";
            // 
            // btn_connet
            // 
            this.btn_connet.Location = new System.Drawing.Point(718, 10);
            this.btn_connet.Name = "btn_connet";
            this.btn_connet.Size = new System.Drawing.Size(75, 23);
            this.btn_connet.TabIndex = 4;
            this.btn_connet.Text = "连接";
            this.btn_connet.UseVisualStyleBackColor = true;
            this.btn_connet.Click += new System.EventHandler(this.btn_connet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "DB_Addr";
            // 
            // tb_DBAddr
            // 
            this.tb_DBAddr.Location = new System.Drawing.Point(71, 12);
            this.tb_DBAddr.Name = "tb_DBAddr";
            this.tb_DBAddr.Size = new System.Drawing.Size(100, 21);
            this.tb_DBAddr.TabIndex = 1;
            this.tb_DBAddr.Text = ".";
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(12, 89);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.Size = new System.Drawing.Size(428, 292);
            this.tb_log.TabIndex = 8;
            this.tb_log.TextChanged += new System.EventHandler(this.tb_log_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "DB_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "GameName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "添加游戏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_sql
            // 
            this.tb_sql.Location = new System.Drawing.Point(449, 60);
            this.tb_sql.Multiline = true;
            this.tb_sql.Name = "tb_sql";
            this.tb_sql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sql.Size = new System.Drawing.Size(347, 286);
            this.tb_sql.TabIndex = 13;
            this.tb_sql.TextChanged += new System.EventHandler(this.tb_sql_TextChanged);
            // 
            // btn_query
            // 
            this.btn_query.Enabled = false;
            this.btn_query.Location = new System.Drawing.Point(449, 353);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(347, 28);
            this.btn_query.TabIndex = 14;
            this.btn_query.Text = "执行以上SQL语句";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "日志输出：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "SQL语句输出：";
            // 
            // cb_GameName
            // 
            this.cb_GameName.FormattingEnabled = true;
            this.cb_GameName.Location = new System.Drawing.Point(71, 42);
            this.cb_GameName.Name = "cb_GameName";
            this.cb_GameName.Size = new System.Drawing.Size(279, 20);
            this.cb_GameName.TabIndex = 17;
            // 
            // cb_DBName
            // 
            this.cb_DBName.FormattingEnabled = true;
            this.cb_DBName.Items.AddRange(new object[] {
            "RYPlatformDB",
            "WHJJPlatformDB",
            "THPlatformDB"});
            this.cb_DBName.Location = new System.Drawing.Point(247, 11);
            this.cb_DBName.Name = "cb_DBName";
            this.cb_DBName.Size = new System.Drawing.Size(111, 20);
            this.cb_DBName.TabIndex = 18;
            this.cb_DBName.Tag = "";
            this.cb_DBName.Text = "RYPlatformDB";
            this.cb_DBName.SelectedIndexChanged += new System.EventHandler(this.cb_DBName_SelectedIndexChanged);
            // 
            // label_sqlServer
            // 
            this.label_sqlServer.AutoSize = true;
            this.label_sqlServer.ForeColor = System.Drawing.Color.Red;
            this.label_sqlServer.Location = new System.Drawing.Point(536, 45);
            this.label_sqlServer.Name = "label_sqlServer";
            this.label_sqlServer.Size = new System.Drawing.Size(0, 12);
            this.label_sqlServer.TabIndex = 19;
            // 
            // btn_checkGame
            // 
            this.btn_checkGame.Enabled = false;
            this.btn_checkGame.Location = new System.Drawing.Point(196, 64);
            this.btn_checkGame.Name = "btn_checkGame";
            this.btn_checkGame.Size = new System.Drawing.Size(98, 23);
            this.btn_checkGame.TabIndex = 20;
            this.btn_checkGame.Text = "检查已有PC游戏";
            this.btn_checkGame.UseVisualStyleBackColor = true;
            this.btn_checkGame.Click += new System.EventHandler(this.btn_checkGame_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(533, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "使用说明：启动程序后请填写数据库地址、选择数据库、填写数据库用户名密码，点击连接数据库。";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(575, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "然后在GameName中输入游戏中文名称或在下拉框中选择，点击添加游戏，确认SQL语句无误后点击执行即可。";
            // 
            // btn_AddMoblieGame
            // 
            this.btn_AddMoblieGame.Enabled = false;
            this.btn_AddMoblieGame.Location = new System.Drawing.Point(346, 64);
            this.btn_AddMoblieGame.Name = "btn_AddMoblieGame";
            this.btn_AddMoblieGame.Size = new System.Drawing.Size(95, 23);
            this.btn_AddMoblieGame.TabIndex = 23;
            this.btn_AddMoblieGame.Text = "添加手机游戏";
            this.btn_AddMoblieGame.UseVisualStyleBackColor = true;
            this.btn_AddMoblieGame.Click += new System.EventHandler(this.btn_AddMoblieGame_Click);
            // 
            // lab_version
            // 
            this.lab_version.AutoSize = true;
            this.lab_version.Location = new System.Drawing.Point(670, 404);
            this.lab_version.Name = "lab_version";
            this.lab_version.Size = new System.Drawing.Size(0, 12);
            this.lab_version.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(809, 421);
            this.Controls.Add(this.lab_version);
            this.Controls.Add(this.btn_AddMoblieGame);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_checkGame);
            this.Controls.Add(this.label_sqlServer);
            this.Controls.Add(this.cb_DBName);
            this.Controls.Add(this.cb_GameName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.tb_sql);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.tb_DBAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_connet);
            this.Controls.Add(this.tb_dbpwd);
            this.Controls.Add(this.tb_dbuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_databaseuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OneKeySQL(Beta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_databaseuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dbuser;
        private System.Windows.Forms.TextBox tb_dbpwd;
        private System.Windows.Forms.Button btn_connet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_DBAddr;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_sql;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_GameName;
        private System.Windows.Forms.ComboBox cb_DBName;
        private System.Windows.Forms.Label label_sqlServer;
        private System.Windows.Forms.Button btn_checkGame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_AddMoblieGame;
        private System.Windows.Forms.Label lab_version;
    }
}

