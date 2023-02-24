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
    public partial class UserRegister : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            if ((con.State & ConnectionState.Open) > 0)
            {
                Response.Write("Connection OK!");
                con.Close();
            }
            else
            {
                Response.Write("No Connection!");
                con.Close();
            }
        }

        protected void reg_btn_click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (checkEmail()==true)
            {
                checkmail.Text = "Email address already exists!";
            }
            else
            {
                string insertUser = "insert into [userInfo] (Email,Password,FullName) values(@email_id,@pwd,@fname)";
                SqlCommand cmUser = new SqlCommand(insertUser, con);
                cmUser.Parameters.AddWithValue("@email_id", mail.Text.ToString());
                cmUser.Parameters.AddWithValue("@pwd", password.Text.ToString());
                cmUser.Parameters.AddWithValue("@fname", fullname.Text.ToString());
                cmUser.ExecuteNonQuery();
                con.Close();
                Response.Redirect("UserLogin.aspx");
            }
        }

        private bool checkEmail()
        {
            Boolean emailavailable = false;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [userInfo] where Email='" + mail.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                emailavailable = true;
            }
            return emailavailable;
        }
    }
}