using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Event_Managment
{
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            /*SqlDataAdapter sqldata = new SqlDataAdapter("Select * From [eventInfo]", con);
            DataTable dt = new DataTable();
            sqldata.Fill(dt);
            greedview1.DataSource = dt;
            greedview1.DataBind();*/

                SqlDataAdapter da = new SqlDataAdapter("select * from [eventInfo]", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "FillComent");
                ListView1.DataSource = ds.Tables["FillComent"];
                ListView1.DataBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Write("");
            if (edit.OnClientClick =true)
            {
                edit.Visible = true;
                delete.Visible = true;
            }

        }
    }
}