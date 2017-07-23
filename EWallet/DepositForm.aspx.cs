using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DepositForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Calendar1.Visible =false;
        }
    }

    protected void BtnConfirmDeposit_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConfirmationForm.aspx");
    }

    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible == false)
        {
            Calendar1.Visible = true;
        }
        else
        {
            Calendar1.Visible = false;
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TxtBoxExDate.Text =Convert.ToString (Calendar1.SelectedDate);
        Calendar1.Visible = false;
    }
}