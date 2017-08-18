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
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["RefUrl"] = Request.UrlReferrer.ToString();
        }
        int Flag = Convert.ToInt32(Request.QueryString["Flag"]) ;
        
        if (Flag == 2)
        {
            ds = cls.ShowTransactions(2, Convert.ToInt16(Request.QueryString["CustID"]));

        }
        else
        {
            ds = cls.ShowTransactions(1, Convert.ToInt16(Session["Userid"]));

        }
        GridView1.DataSource = ds;
        GridView1.DataBind();
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

            cls.RevertTransaction(ID,1);
            int Flag = Convert.ToInt32(Request.QueryString["Flag"]);

            if (Flag == 2)
            {
                ds = cls.ShowTransactions(2, Convert.ToInt16(Request.QueryString["CustID"]));

            }
            else
            {
                ds = cls.ShowTransactions(1, Convert.ToInt16(Session["Userid"]));

            }
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}