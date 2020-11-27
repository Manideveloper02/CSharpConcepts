using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Online_food_ordering.Admin
{
    public partial class listofproduct : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string excelFilePath = $@"C:\Users\Mani\Downloads\Food.xlsx";
            //string provider = "Microsoft.ACE.OLEDB.12.0";
            //string connectionString = $"Provider={provider};Data Source={excelFilePath};Extended Properties='Excel 12.0 Xml;HDR=Yes';";
            //OleDbConnection oledbConn = new OleDbConnection(connectionString);
            //try
            //{
            //    oledbConn.Open();
            //    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Food$]", oledbConn);
            //    OleDbDataAdapter oleda = new OleDbDataAdapter();
            //    oleda.SelectCommand = cmd;
            //    DataSet ds = new DataSet();
            //    oleda.Fill(ds, "Food");
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        Repeater1.DataSource = ds.Tables[0];
            //        Repeater1.DataBind();
            //    }

            //}
            //catch (Exception EX )
            //{
            //    var A = EX;
            //}
            //finally
            //{
            //    oledbConn.Close();
            //}

            SqlCommand sqlCmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = null;
            sql = "Select * from tbl_listoffood";
            try
            {
                con.Open();
                sqlCmd = new SqlCommand(sql, con);
                adapter.SelectCommand = sqlCmd;
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Repeater1.DataSource = ds.Tables[0];
                    Repeater1.DataBind();
                }
                adapter.Dispose();
                sqlCmd.Dispose();
            }
            catch (Exception ex)
            {
            }
          
        }


    }
}