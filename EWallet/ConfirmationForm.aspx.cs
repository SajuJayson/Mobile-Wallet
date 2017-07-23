using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ConfirmationForm : System.Web.UI.Page
{    
    eWalletEntities1 dbcontext = new eWalletEntities1();
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelCurrentBalance.Text = Request.QueryString["CurBal"];
        LabelAmountDeducted.Text= Request.QueryString["DeductedAmt"];
        LabelUpdatedBalance.Text = Request.QueryString["updatedAmt"];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AcknowledgementForm.aspx?RemBal="+ Request.QueryString["updatedAmt"] + "&CustID="+ Request.QueryString["CustID"]);
    }
}