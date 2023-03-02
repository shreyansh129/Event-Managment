using System;
using System.Web.UI;

namespace Event_Managment
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*try
            {
                if (Session["Role"].Equals(""))
                {
                    CE.Visible = false;
                   *//* Lo.Visible = false;
                    Li.Visible = true;
                    Ri.Visible = true;*//*

                    
                }
                else if (Session["Role"].Equals("User"))
                {
                    CE.Visible = true;
                    *//*Lo.Visible = true;
                    Li.Visible = false;
                    Ri.Visible = false;*//*
                    Uname.Visible = true;
                    Uname.Text = "Hello" + Session["Email"];
                }
            }
            catch { }*/


        }

        public void Btn_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            Session.Clear();
            Response.Redirect("UserLogin.aspx");
        }

        protected void Li_Click(object sender, EventArgs e)
        {

            Response.Redirect("UserLogin.aspx");
        }

        protected void Ri_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegister.aspx");
        }

        protected void CE_Click(object sender, EventArgs e)
        {
            Response.Redirect("createEvents");
        }
    }
}