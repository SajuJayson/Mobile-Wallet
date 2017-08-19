using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Report : System.Web.UI.Page
{
    DataBaseHandler cls = new DataBaseHandler();
    DataSet ds1 = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserInfo"] != null)
            {
                DataSet ds = new DataSet();
                ds = Session["UserInfo"] as DataSet;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["Userid"] = ds.Tables[0].Rows[0]["CustomerID"];
                    Control c = this.Master.FindControl("login");// "masterDiv"= the Id of the div.
                    c.Visible = false;
                    c = this.Master.FindControl("Register");// "masterDiv"= the Id of the div.
                    c.Visible = false;
                    c = this.Master.FindControl("LogOut");// "masterDiv"= the Id of the div.
                    c.Visible = true;
                    Label mpLabel = (Label)Master.FindControl("welcome");
                    mpLabel.Text = "Welcome " + ds.Tables[0].Rows[0]["firstname"];
                    mpLabel.Visible = true;
                    //Flag = 1;
                    if (ds.Tables[0].Rows[0]["rollid"].ToString() == "1")
                        ds1 = cls.ShowTransactions(1, 0);
                    else
                    {
                       ds1= cls.ShowTransactions(2, Convert.ToInt16(Request.QueryString["CustID"]));
                        GridView1.Columns[0].Visible = false;
                    }
                    GridView1.DataSource = ds1;
                    GridView1.DataBind();
                }
                else
                    Response.Redirect("login.aspx");

            }
            ViewState["RefUrl"] = Request.UrlReferrer.ToString();
        }
        
        
    }

    

    protected void ReportGridView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   

    protected void BtnReportBack_Click1(object sender, EventArgs e)
    {
        object refUrl = ViewState["RefUrl"];
        if (refUrl != null)
            Response.Redirect((string)refUrl);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "revert")
        {
            GridViewRow gvr = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            int ID=Convert.ToInt16( GridView1.Rows[gvr.RowIndex].Cells[8].Text);           

        }
    }
}