using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Collections;
using System.Data.SqlClient;
using System.Net;
using System.Text;

namespace SQL_Injection
{
    public partial class _Default : System.Web.UI.Page
    {
        string username, pass, db_n, db_p,sql;

        protected void Page_Load(object sender, EventArgs e)
        {
            username = TextBoxUser.Text;
            pass = TextBoxPWD.Text;
        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data source = " + Server.MapPath("~/App_Data/DatabaseTEST.mdb"));
            conn.Open();

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select * from Users where UserName = '" + username + "' and PassWord = '" + pass + "'";
            sql = cmd.CommandText;
            try
            {
               
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                db_n = rdr["UserName"].ToString();
                db_p = rdr["PassWord"].ToString();
                rdr.Close();
            }
            else
            {
                db_n = "Unknown and was not found in the system database";
                db_p = "Unknown and was not found in the system database";
            }
            rdr.Close();
            }
            catch
            {
                db_n = "Deny access to the Secret Info";
                db_p = "Deny access to the Secret Info";
            }

            LabelName.Text = db_n;
            LabelPWD.Text = db_p;
            LabelSQL.Text = sql;

        }

        protected void GetIP_Click(object sender, EventArgs e)
        {
            String whatIsMyIp = "http://automation.whatismyip.com/n09230945.asp";
            WebClient wc = new WebClient();
            UTF8Encoding utf8 = new UTF8Encoding();
            string requestHtml = "";
            try
            {
                requestHtml = utf8.GetString(wc.DownloadData(whatIsMyIp));
            }
            catch (WebException we)
            {
                // do something with exception
                Console.Write(we.ToString());
            }
            LabelSQL.Text = "Server external IP : " + requestHtml.ToString();
        }
    }
}
