using System;
using System.Collections.Generic;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.Data;
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
using System.Data;
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
=======
using System.Data;
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
using System.Data;
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Report : System.Web.UI.Page
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
    protected void Page_Load(object sender, EventArgs e)
    {

=======
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
<<<<<<< HEAD
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
    }

    

    protected void ReportGridView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   

    protected void BtnReportBack_Click1(object sender, EventArgs e)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
        Response.Redirect("Default.aspx");
=======
        object refUrl = ViewState["RefUrl"];
        if (refUrl != null)
            Response.Redirect((string)refUrl);
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
        object refUrl = ViewState["RefUrl"];
        if (refUrl != null)
            Response.Redirect((string)refUrl);
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
<<<<<<< HEAD
=======
        object refUrl = ViewState["RefUrl"];
        if (refUrl != null)
            Response.Redirect((string)refUrl);
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
        object refUrl = ViewState["RefUrl"];
        if (refUrl != null)
            Response.Redirect((string)refUrl);
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
    }
}