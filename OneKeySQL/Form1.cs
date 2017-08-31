using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OneKeySQL
{
    public partial class Form1 : Form
    {
        String DB_USER;
        String DB_PWD;
        String DB_ADDR;
        String DB_NAME;
        String content;
        String GameName;
        Dictionary<string, string> dicGG = new Dictionary<string, string>();
        Dictionary<string, string> dicGK = new Dictionary<string, string>();
        AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void initSQL(String sqlFilePath, Dictionary<string, string> dic) {
            try {
                StreamReader sr = new StreamReader(new FileStream(sqlFilePath, FileMode.Open, FileAccess.Read), Encoding.Default);
                content = sr.ReadLine();
                while (null != content)
                {
                    GameName = content.Split('\'')[1];
                    try
                    {
                        dic.Add(GameName, content);
                        acsc.Add(GameName);
                    }
                    catch (ArgumentException err)
                    {
                        printLog("错误：" + err.Message.ToString()+GameName);
                        
                    }
                    content = sr.ReadLine();
                }
            }
            catch (IOException e) {
                printLog(e.Message.ToString()) ;
            }
            
        }

        private void initAutoComplete() { 
            this.tb_GameName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_GameName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_GameName.AutoCompleteCustomSource = acsc;
        }

        private void initCBGameName() {
            BindingSource bs = new BindingSource();
            bs.DataSource = dicGG;
            cb_GameName.DataSource = bs;
            cb_GameName.DisplayMember = "Key";
            cb_GameName.ValueMember = "Key";
        }

        private void btn_connet_Click(object sender, EventArgs e)
        {
            DB_USER = tb_dbuser.Text.ToString().Trim();
            DB_PWD = tb_dbpwd.Text.ToString().Trim();
            DB_ADDR = tb_DBAddr.Text.ToString().Trim();
            DB_NAME = tb_DBName.Text.ToString().Trim();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server="+DB_ADDR+ ";database="+DB_NAME+";uid=" + DB_USER+";pwd="+DB_PWD;
            try
            {
                con.Open();
                printLog("连接状态：数据库连接成功！");
                btn_query.Enabled = true;
            }
            catch(SqlException err) {
                printLog("连接状态：数据库连接失败，错误信息："+err.Message.ToString());
            }
            con.Close();
        }

        private void printLog(String s) {
            tb_log.Text += DateTime.Now.ToString()+":";
            tb_log.Text += s.Replace("\t","");
            tb_log.Text += "\r\n";
        }
        private void printSql(String s)
        {
            tb_sql.Text += s.Replace("\t","");
        }

        private void tb_log_TextChanged(object sender, EventArgs e)
        {
            tb_log.Select(tb_log.TextLength, 0);
            tb_log.ScrollToCaret();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            printLog("初始化中....");
            initSQL("D:/GameGameItem.sql",dicGG);
            initSQL("D:/GameKindItem.sql",dicGK);
            initAutoComplete();
            initCBGameName();
            printLog("初始化完毕！请测试连接数据库！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String game;
            String sql;
            game = cb_GameName.Text.ToString().Trim();
            try {
                sql = dicGG[game];
                sql += "\r\n";
                sql += dicGK[game];
                printLog(sql);
                printSql(sql);
            }
            catch (KeyNotFoundException err)
            { printLog(err.Message.ToString()); }
            
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            String sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=" + DB_ADDR + ";database=" + DB_NAME + ";uid=" + DB_USER + ";pwd=" + DB_PWD;
            con.Open();
            sql = tb_sql.Text.ToString().Replace("\r\n"," ");
            try {
                int i = new SqlCommand(sql, con).ExecuteNonQuery();
                printLog(i + "行受影响");
                con.Close();
            } catch (SqlException err) {
                switch (err.Number) {
                    case 2627:
                        printLog("此游戏已存在数据库中！");
                        break;
                    default:
                        printLog("执行SQL时遇到错误，错误代码"+err.Number.ToString());
                        break;
                }
            }
        }

        private void tb_sql_TextChanged(object sender, EventArgs e)
        {
            tb_sql.Select(tb_sql.TextLength, 0);
            tb_sql.ScrollToCaret();
        }
    }
}
