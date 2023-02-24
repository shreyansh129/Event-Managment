using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Event_Managment
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Role"].Equals(""))
                {
                    Lo.Visible = false;
                    Li.Visible = true;
                    Ri.Visible = true;
                }
                else if (Session["Role"].Equals("User"))
                {
                    Lo.Visible = true;
                    Li.Visible = false;
                    Ri.Visible = false;
                    Uname.Visible = true;
                    Uname.Text = "Hello" + Session["Email"];
                }
            }
            catch { }
            
            
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
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
    }
}