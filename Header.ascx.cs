using System;

namespace Event_Managment
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (Session["Email"]!=null)
                {
                    CE.Visible = true;
                    Li.Visible = false;
                    Lo.Visible = true;
                    Ri.Visible = false;
                }
                else
                {
                    Li.Visible = true;
                    Lo.Visible = false;
                    Ri.Visible = true;
                    CE.Visible = false;

                }
            }
            catch {  }
            }

        protected void Li_Click(object sender, EventArgs e)
        {

            Response.Redirect("UserLogin.aspx");
        }
        protected void Lo_Click(object sender, EventArgs e)
        {
            Session.Clear();
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