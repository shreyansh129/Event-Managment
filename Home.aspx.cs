using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
            var currentdate =  DateTime.Now.ToString("yyyy-MM-dd");
            string query = "SELECT * FROM [eventInfo] where sdate < '" + currentdate + "' ORDER BY sdate DESC ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "FillComent");
            ListView1.DataSource = ds.Tables["FillComent"];
            ListView1.DataBind();
            
            
            var currentdateup =  DateTime.Now.ToString("yyyy-MM-dd");
            string query2 = "SELECT * FROM [eventInfo] where sdate > '" + currentdateup + "' ORDER BY sdate ASC ";
            SqlDataAdapter da1 = new SqlDataAdapter(query2, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "FillComent");
            ListView2.DataSource = ds1.Tables["FillComent"];
            ListView2.DataBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            popupGrid();
        } 
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            popupgrid2();
           
        }
        

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs  e)
        {
            int customerId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);

            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM [eventInfo] WHERE id = @CustomerId", con))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Home.aspx");
                }
            }
            this.popupGrid();
        }
        protected void OnRowDeleting1(object sender, GridViewDeleteEventArgs  e)
        {
            int customerId = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Values[0]);

            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM [eventInfo] WHERE id = @CustomerId", con))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Home.aspx");
                }
            }
            this.popupgrid2();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.popupGrid();
        }
        protected void OnRowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            this.popupgrid2();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int customerId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string title = (row.Cells[1].Controls[0] as TextBox).Text;
            string sdate = (row.Cells[2].Controls[0] as TextBox).Text;
            string duration = (row.Cells[3].Controls[0] as TextBox).Text;
            string author = (row.Cells[4].Controls[0] as TextBox).Text;
            string location = (row.Cells[5].Controls[0] as TextBox).Text;


            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [eventInfo] SET title = @title, sdate = @sdate, duration=@duration, author=@author, location=@location WHERE id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@sdate", sdate);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@location", location);

                    cmd.ExecuteNonQuery();
                    Response.Redirect("Home.aspx");
                }
            }
            GridView1.EditIndex = -1;
            this.popupGrid();
        }
        protected void OnRowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView2.Rows[e.RowIndex];
            int customerId = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Values[0]);
            string title = (row.Cells[1].Controls[0] as TextBox).Text;
            string sdate = (row.Cells[2].Controls[0] as TextBox).Text;
            string duration = (row.Cells[3].Controls[0] as TextBox).Text;
            string author = (row.Cells[4].Controls[0] as TextBox).Text;
            string location = (row.Cells[5].Controls[0] as TextBox).Text;


            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [eventInfo] SET title = @title, sdate = @sdate, duration=@duration, author=@author, location=@location WHERE id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@sdate", sdate);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@location", location);

                    cmd.ExecuteNonQuery();
                    Response.Redirect("Home.aspx");
                }
            }
            GridView2.EditIndex = -1;
            this.popupgrid2();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.popupGrid();
        }
        protected void OnRowCancelingEdit1(object sender, EventArgs e)
        {
            GridView2.EditIndex = -1;
            this.popupgrid2();
        }
        private void popupGrid()
        {
            var currentdate = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "SELECT * FROM [eventInfo] where sdate < '" + currentdate + "' ORDER BY sdate DESC ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            mpe.Show();

        }
        private void popupgrid2()
        {
            var currentdateup = DateTime.Now.ToString("yyyy-MM-dd");
            string query2 = "SELECT * FROM [eventInfo] where sdate > '" + currentdateup + "' ORDER BY sdate ASC ";
            SqlDataAdapter da1 = new SqlDataAdapter(query2, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            GridView2.DataSource = ds1;
            GridView2.DataBind();
            mpe2.Show();
        }

        

        public void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (Session["Email"] == null)
                {
                    GridView1.AutoGenerateEditButton = false;
                    GridView1.AutoGenerateDeleteButton = false;
                    
                }
                else
                {
                    GridView1.AutoGenerateDeleteButton = true;
                    GridView1.AutoGenerateEditButton = true;
                    
                }
            }
           
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (Session["Email"] == null)
                {
                   
                    GridView2.AutoGenerateEditButton = false;
                    GridView2.AutoGenerateDeleteButton = false;
                }
                else
                {
                   
                    GridView2.AutoGenerateEditButton = true;
                    GridView2.AutoGenerateDeleteButton = true;
                }
            }
        }

        
    }
}
            
    

