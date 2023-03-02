using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Event_Managment
{
    public partial class UserLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_btn_click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
            string checkUser = "select * from [userInfo] where Email='" + mail.Text.Trim() + "'and Password='" + Password.Text.Trim() + "';";
            SqlCommand cmdCheck = new SqlCommand(checkUser, con);
            SqlDataReader read = cmdCheck.ExecuteReader();

            if (read.Read())
            {
                Session["Email"] = read.GetValue(0).ToString();
                con.Close();

                Response.Redirect("Home.aspx");
            }
            else
            {
                errorMsg.Text = "Invalid Email or Password";
                errorMsg.ForeColor = System.Drawing.Color.Red;
                con.Close();
            }
        }
    }
}