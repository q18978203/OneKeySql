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
            this.label_databaseuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dbuser = new System.Windows.Forms.TextBox();
            this.tb_dbpwd = new System.Windows.Forms.TextBox();
            this.btn_connet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_DBAddr = new System.Windows.Forms.TextBox();
            this.tb_GameName = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.tb_sql = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_GameName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
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
            this.btn_connet.Text = "测试连接";
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
            // tb_GameName
            // 
            this.tb_GameName.Location = new System.Drawing.Point(173, 66);
            this.tb_GameName.Name = "tb_GameName";
            this.tb_GameName.Size = new System.Drawing.Size(280, 21);
            this.tb_GameName.TabIndex = 7;
            this.tb_GameName.Visible = false;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(12, 89);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
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
            // tb_DBName
            // 
            this.tb_DBName.Location = new System.Drawing.Point(251, 12);
            this.tb_DBName.Name = "tb_DBName";
            this.tb_DBName.Size = new System.Drawing.Size(100, 21);
            this.tb_DBName.TabIndex = 10;
            this.tb_DBName.Text = "WHJJPlatformDB";
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
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "GameName";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "GameGameItem";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "GameKindItem";
            // 
            // tb_sql
            // 
            this.tb_sql.Location = new System.Drawing.Point(449, 60);
            this.tb_sql.Multiline = true;
            this.tb_sql.Name = "tb_sql";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 393);
            this.Controls.Add(this.cb_GameName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.tb_sql);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_DBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.tb_GameName);
            this.Controls.Add(this.tb_DBAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_connet);
            this.Controls.Add(this.tb_dbpwd);
            this.Controls.Add(this.tb_dbuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_databaseuser);
            this.Name = "Form1";
            this.Text = "OneKeySQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
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
        private System.Windows.Forms.TextBox tb_GameName;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.TextBox tb_sql;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_GameName;
    }
}

