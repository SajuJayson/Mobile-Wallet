using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConfirmationForm : System.Web.UI.Page
{

   // eWalletEntities dbcontext = new eWalletEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
      //  LabelCurrentBalance.Text = "You are a Billionaire";
      //  LabelUpdatedBalance.Text= dbcontext.AccountInfoes.ToList().ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AcknowledgementForm.aspx");
    }
}