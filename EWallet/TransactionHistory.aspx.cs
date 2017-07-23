using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TransactionHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnHistoryBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountInfo.aspx");
    }

    protected void BtnHistoryNext_Click(object sender, EventArgs e)
    {

    }
}