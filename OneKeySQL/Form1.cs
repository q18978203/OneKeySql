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
        Dictionary<string, string> dicGG = new Dictionary<string, string>();//GameGameItem.sql
        Dictionary<string, string> dicGK = new Dictionary<string, string>();//GameKindItem.sql
        Dictionary<string, string> dicMK = new Dictionary<string, string>();//MobileKindItem.sql
        Dictionary<string, string> dicMKJJ = new Dictionary<string, string>();//MobileKindItemJJ.sql  精简版手机游戏列表
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String APP_VERSION = "1.0.1";
            lab_version.Text = "当前程序版本"+APP_VERSION;
        }

        private void initSQL(String sqlFilePath, Dictionary<string, string> dic) {
            try {
                //StreamReader sr = new StreamReader(new FileStream(sqlFilePath, FileMode.Open, FileAccess.Read), Encoding.Default);
                //StreamReader sr = new StreamReader(sqlFilePath);
                StringReader sr = new StringReader(sqlFilePath);
                content = sr.ReadLine();
                while (null != content)
                {
                    GameName = content.Split('\'')[1];
                    try
                    {
                        dic.Add(GameName, content);
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


        private void initCBGameName() {
            BindingSource bs = new BindingSource();
            bs.DataSource = dicGG;
            cb_GameName.DataSource = bs;
            cb_GameName.DisplayMember = "Key";
            cb_GameName.ValueMember = "Key";
        }

        private void btn_connet_Click(object sender, EventArgs e)
        {
            printLog("数据库连接中......");
            DB_USER = tb_dbuser.Text.ToString().Trim();
            DB_PWD = tb_dbpwd.Text.ToString().Trim();
            DB_ADDR = tb_DBAddr.Text.ToString().Trim();
            DB_NAME = cb_DBName.Text.ToString().Trim();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server="+DB_ADDR+ ";database="+DB_NAME+";uid=" + DB_USER+";pwd="+DB_PWD;
            try
            {
                con.Open();
                printLog("连接状态：数据库连接成功！");
                btn_query.Enabled = true;
                btn_checkGame.Enabled = true;
                btn_AddMoblieGame.Enabled = true;
                label_sqlServer.Text = "当前操作数据库："+DB_NAME;
            }
            catch(SqlException err) {
                printLog("连接状态：数据库连接失败，错误信息："+err.Message.ToString());
                btn_checkGame.Enabled = false;
                btn_query.Enabled = false;
                btn_AddMoblieGame.Enabled = false;
            }
            con.Close();
        }

        private void printLog(String s) {
            tb_log.Text += DateTime.Now.ToString()+":";
            tb_log.Text += s.Replace("\t","");
            tb_log.Text += "\r\n";
        }

        private void tb_log_TextChanged(object sender, EventArgs e)
        {
            tb_log.Select(tb_log.TextLength, 0);
            tb_log.ScrollToCaret();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            printLog("初始化中....");
            initSQL(Properties.Resources.GameGameItem,dicGG);
            initSQL(Properties.Resources.GameKindItem,dicGK);
            initSQL(Properties.Resources.MobileKindItem,dicMK);
            initSQL(Properties.Resources.MobileKindItemJJ,dicMKJJ);
            initCBGameName();
            printLog("初始化完毕！请连接数据库！");
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
                Common.printSql(tb_sql,sql);
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
            printLog("执行SQL语句："+sql);
            try {
                int i = new SqlCommand(sql, con).ExecuteNonQuery();
                printLog("执行成功！ "+i + "行受影响");
                tb_sql.Text = "";
                con.Close();
            } catch (SqlException err) {
                switch (err.Number) {
                    case 2627:
                        printLog("此游戏已存在数据库"+DB_NAME+"中！请检查SQL语句！");
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

        private void btn_checkGame_Click(object sender, EventArgs e)
        {
            try {
                String sql;
                String gameList = "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=" + DB_ADDR + ";database=" + DB_NAME + ";uid=" + DB_USER + ";pwd=" + DB_PWD;
                con.Open();
                sql = "select GameName from GameGameItem";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow[] arrayDR = dt.Select();
                foreach (DataRow dr in arrayDR)
                {
                    gameList += (dr[0].ToString()+"\r\n");
                }
                printLog("当前数据库有以下游戏：\r\n"+gameList);
                con.Close();
            }
            catch (Exception err) {
                printLog("读取错误："+err.Message);
            }
            
        }

        private void btn_AddMoblieGame_Click(object sender, EventArgs e)
        {

            String game;
            String sql;
            game = cb_GameName.Text.ToString().Trim();
            
            try
            {
                if (DB_NAME == "WHJJPlatformDB")
                {
                    sql = dicMKJJ[game];
                    sql += "\r\n";
                    printLog(sql);
                    Common.printSql(tb_sql, sql);
                }
                else {
                    sql = dicMK[game];
                    sql += "\r\n";
                    printLog(sql);
                    Common.printSql(tb_sql, sql);
                }
                
            }
            catch (KeyNotFoundException err)
            { printLog(err.Message.ToString()); }
        }

        private void cb_DBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_sql.Text = "";
            btn_AddMoblieGame.Enabled = false;
            btn_query.Enabled = false;
            btn_checkGame.Enabled = false;
            printLog("切换了数据库，请重新连接！");
        }
    }
}
