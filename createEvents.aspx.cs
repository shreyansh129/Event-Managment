using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Event_Managment
{
    public partial class createEvents : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubBtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }  
            string insertUser = "insert into [eventInfo] (title,sdate,stime,duration,description,location,author) values(@title,@sdate,@stime,@duration,@description,@location,@author)";
                SqlCommand cmUser = new SqlCommand(insertUser, con);
                cmUser.Parameters.AddWithValue("@title", title.Text.ToString());
                cmUser.Parameters.AddWithValue("@sdate", sdate.Text.ToString());
                cmUser.Parameters.AddWithValue("@stime", stime.Text.ToString());
                cmUser.Parameters.AddWithValue("@duration", duration.Text.ToString());
                cmUser.Parameters.AddWithValue("@description", description.Text.ToString());
                cmUser.Parameters.AddWithValue("@location", location.Text.ToString());
                cmUser.Parameters.AddWithValue("@author", author.Text.ToString());
                cmUser.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Home.aspx");
        }
    }
}