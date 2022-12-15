using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _111_1HW5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_str = ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString;
            if(!IsPostBack)
            try
            {
                SqlConnection o_str = new SqlConnection(s_str);
                o_str.Open();
                SqlDataAdapter o_A = new SqlDataAdapter("SELECT * from Users", o_str);
                DataSet o_Set = new DataSet();
                o_A.Fill(o_Set, "zz");
                gd_View.DataSource = o_Set;
                gd_View.DataBind();
                o_str.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void btn_Insert_Click(object sender, EventArgs e)
        {
            string s_str = ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString;
            try
            {
                SqlConnection o_str = new SqlConnection(s_str);
                SqlDataAdapter o_A = new SqlDataAdapter("SELECT * from Users", o_str);
                o_str.Open();
                SqlCommand o_cmd = new SqlCommand("Insert into Users (Id, Name, Birthday) "+"value(@Name, @DataTime)",o_str);
                o_cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                o_cmd.Parameters["@Name"].Value = "阿貓阿狗";
                o_cmd.Parameters.Add("@DataTime", SqlDbType.DateTime);
                o_cmd.Parameters["@DataTime"].Value = "2000/10/10";
                o_cmd.ExecuteNonQuery();
                Response.Redirect("https://localhost:44393/WebForm1.aspx",false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
                o_str.Close();
            }
            catch(Exception o_e)
            {
                Response.Write(o_e.ToString());
            }
        }
    }
}