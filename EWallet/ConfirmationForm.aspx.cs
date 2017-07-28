using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ConfirmationForm : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelCurrentBalance.Text = Request.QueryString["CurBal"];
        LabelAmountDeducted.Text= Request.QueryString["DeductedAmt"];
        LabelUpdatedBalance.Text = Request.QueryString["updatedAmt"];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataBaseHandler cls = new DataBaseHandler();
        //Convert.ToInt16(Session["Userid"])
        int result =cls.TransferMoney(1003, Convert.ToInt16(Request.QueryString["CustID"]), Convert.ToDouble(Request.QueryString["DeductedAmt"]));
        Response.Redirect("AcknowledgementForm.aspx?RemBal="+ Request.QueryString["updatedAmt"] + "&CustID="+ Request.QueryString["CustID"]);
    }
}